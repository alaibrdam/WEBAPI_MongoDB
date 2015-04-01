using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using LinqToTwitter;



namespace TwitterGate.DAL
{
    [Serializable]
    public class entTweet : Status
    {
        public ObjectId Id { get; set; }

    }
}
