using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using lynxs.controls;
using lynxs.forms;
using MongoDB.Bson;
using MongoDB.Driver;

namespace lynxs.classes
{
    internal static class dbActions
    {
        private static IMongoClient _client;
        private static IMongoDatabase _database;
        private static IMongoCollection<BsonDocument> _groupcollection;
        private static IMongoCollection<BsonDocument> _stdcollection;

        public static int groupNo()
        {
            var projection = Builders<BsonDocument>.Projection.Exclude("_id").Include("groupno");
            var sort = Builders<BsonDocument>.Sort.Descending("groupno");
            var eq = _groupcollection.Find(new BsonDocument()).Project(projection).Sort(sort).First();
            var i = eq["groupno"].AsBsonValue.ToInt32();
            return i;
        }
        private static void mongoInit()
        {
            _client = new MongoClient();
            _database = _client.GetDatabase("rth_dev");
            _groupcollection = _database.GetCollection<BsonDocument>("groups");
            _stdcollection = _database.GetCollection<BsonDocument>("students");
        }

        public static async void stdInsert(BsonDocument stdoc)
        {
            await _stdcollection.InsertOneAsync(stdoc);
        }

        public static async void grpInsert(BsonDocument grpdoc)
        {
            await _groupcollection.InsertOneAsync(grpdoc);
        }

        public static async Task<List<BsonValue>> groupComboFill()
        {
            var grouplist = new List<BsonValue>();
            var projection = Builders<BsonDocument>.Projection.Exclude("_id").Include("groupno");
            var sort = Builders<BsonDocument>.Sort.Ascending("groupno");
            var eq = _groupcollection.Find(new BsonDocument()).Project(projection).Sort(sort);
            await eq.ForEachAsync(doc => grouplist.Add(doc.Values.Single()));

            return grouplist;
        }

        public static async Task<BsonDocument> stdDetail(string id)
        {
            var stdid = ObjectId.Parse(id);
            var filter = Builders<BsonDocument>.Filter.Eq("_id", stdid);
            var document = await _stdcollection.Find(filter).FirstAsync();
            return document;
        }

        public static async Task<BsonDocument> stdContacts(string id)
        {
            var stdid = ObjectId.Parse(id);

            var filter = Builders<BsonDocument>.Filter.Eq("_id", stdid);
            var document = await _stdcollection.Find(filter).FirstAsync();
            return document;
        }
        public static DataTable stdlist(string groupno)
        {
            var stable = new DataTable();
            
            stable.BeginInit();
            stable.Columns.Add("_id", typeof (string));
            stable.Columns.Add("name", typeof(string));

            var filter = Builders<BsonDocument>.Filter.Eq("groupno", groupno);
            var projection = Builders<BsonDocument>.Projection.Include("_id").Include("fullname");
            var sort = Builders<BsonDocument>.Sort.Ascending("lname");
            var cursor = _stdcollection.Find(filter).Project(projection).Sort(sort).ToCursor();
            foreach (var document in cursor.ToEnumerable())
            {
                stable.Rows.Add(document["_id"].ToString(), document["fullname"].ToString());
            }
            stable.EndInit();

            return stable;
        }
        public static DataTable stdFullList()
        {
            var stable = new DataTable();
            stable.BeginInit();
            stable.Columns.Add("_id", typeof(string));
            stable.Columns.Add("name", typeof(string));

            var projection = Builders<BsonDocument>.Projection.Include("_id").Include("fullname");
            var sort = Builders<BsonDocument>.Sort.Ascending("lname");
            var cursor = _stdcollection.Find(new BsonDocument()).Project(projection).Sort(sort).ToCursor();
            foreach (var document in cursor.ToEnumerable())
            {
                stable.Rows.Add(document["_id"].ToString(), document["fullname"].ToString());
            }
            stable.EndInit();

            return stable;
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
