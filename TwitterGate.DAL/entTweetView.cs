using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TwitterGate.DAL
{
   public  class entTweetView
    {
        public string Text{ get; set; }
        public string Name { get; set; }

        public DateTime CreatedAt { get; set; }


        public LinqToTwitter.StatusType Type { get; set; }

        public int RetweetCount { get; set; }

        public int? FavoriteCount { get; set; }

        public int FollowersCount { get; set; }
    }
}
