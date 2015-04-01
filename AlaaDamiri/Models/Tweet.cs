using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MongoDB.Bson;
using LinqToTwitter;

namespace AlaaDamiri.Models
{
    public class Tweet : Status
    {
        public ObjectId Id { get; set; } 
    }
}
