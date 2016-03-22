using System.Data;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace lynxs.classes
{
    internal class db_actions
    {
        private static IMongoClient _client;
        private static IMongoDatabase _database;

        private static void mongoInit()
        {
            _client = new MongoClient();
            _database = _client.GetDatabase("rth_dev");
        }

        public static async Task<DataTable> groupList()
        {
            mongoInit();

            var gtable = new DataTable();
            var firstrow = BsonValue.Create("All");

            gtable.Clear();
            gtable.BeginInit();
            gtable.Columns.Add("num", typeof(BsonValue));
            gtable.Rows.Add(firstrow);

            var collection = _database.GetCollection<BsonDocument>("groups");
            var projection = Builders<BsonDocument>.Projection.Exclude("_id").Include("groupno");
            var sort = Builders<BsonDocument>.Sort.Ascending("groupno");
            await
                collection.Find(new BsonDocument())
                    .Project(projection)
                    .Sort(sort)
                    .ForEachAsync(doc => gtable.Rows.Add(doc.Values.Single()));

            gtable.EndInit();
            return gtable;
        }
    }
}
