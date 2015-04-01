using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Security.Cryptography;
using System.Net;
using System.IO;
using LinqToTwitter;
using AlaaDamiri.Models;

namespace AlaaDamiri.Models
{
    public class TwitterAccess
    {
        private SingleUserAuthorizer authorizer = new SingleUserAuthorizer
        {
            Credentials = new SingleUserInMemoryCredentials
            {
                //Please fill the following parameters

                ConsumerKey = "87BuYh2cVCQNvHd9sG2AGXasB",
                ConsumerSecret = "FmUIfrxu5qwU02LSX3dORnn9mf2b3lECIwfso4V8qnFhqWkm5O",
                TwitterAccessToken = "180738131-bI5TznXPQNcDtBHs9iu2qAXrGJX1Gm4DrkYSzZb2",
                TwitterAccessTokenSecret = "VG9BE4eHzKORwhtRsjUZlZGo6KP2gh9i1MRxSUfBpCtya"

                
            }
        };
        public List<Status> ReadTweets()
        {
            var twitterContext = new TwitterContext(authorizer);
            List<Status> statusList = new List<Status>();

            List<Search> searchList = (from srch in twitterContext.Search
                                       where srch.Type == SearchType.Search &&
                                       srch.Query == "#BBC" && 
                                       srch.Count == 50                                       
                                       select srch).ToList();

            if (searchList.Count > 0) 
                statusList = searchList[0].Statuses;  

            return statusList;
        }
    }
}