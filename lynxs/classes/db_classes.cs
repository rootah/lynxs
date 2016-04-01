using System;
using System.Collections.Generic;
using MongoDB.Bson;

namespace lynxs.classes
{
    internal class db_classes
    {
        public class groups
        {
            public ObjectId _id { get; set; }
            public string num { get; set; }
            public string lvl { get; set; }
            public string[] days { get; set; }
            public ObjectId[] stdsid { get; set; } /* list can be this.. */
            public List<ObjectId> anotherstdsid { get; set; } /* or can be that..  */
            public DateTime time { get; set; }
        }

        public class stds
        {
            public ObjectId _id { get; set; }
            public ObjectId _groupid { get; set; }
            public string fname { get; set; }
            public string lname { get; set; }
            public string fullname { get; set; }
            public BsonDocument[] contacts { get; set; }
            public int cost { get; set; }
        }
    }
}
