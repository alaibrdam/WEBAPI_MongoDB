using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using LinqToTwitter;
using AlaaDamiri.Models;
using TwitterGate.DAL;


namespace AlaaDamiri.Controllers
{
    public class ValuesController : ApiController
    {
        [HttpGet]
        // GET api/values
        public List<Status> Get()
        {
            TwitterAccess srch = new TwitterAccess();
            cntMongo mongo = new cntMongo();

            List<Status> tweets = srch.ReadTweets();
            mongo.InsertTweets(tweets);
            return tweets;

            
           
        }

        [Route("api/getTweets")]
        public List<Status> GetTweets()
        {
            TwitterAccess srch = new TwitterAccess();
            
            List<Status> AllTweets = srch.ReadTweets();
            cntMongo m = new cntMongo();
            m.InsertTweets(AllTweets);
            return AllTweets;

        }

      

        [Route("api/getTopRetweets")]
        public List<entTweetView> GetTopFiveTweetsOrderedByRetweets()
        {

            cntMongo mongo = new cntMongo();
            List<entTweetView> lstTweets = mongo.GetTopFiveTweetsOrderedByRetweets();

            return lstTweets;

        }


        [Route("api/getTopFollowers")]
        public List<entTweetView> GetTopFiveTweetsOrderedByFollowers()
        {

            cntMongo mongo = new cntMongo();
            List<entTweetView> lstTweets = mongo.GetTopFiveTweetsOrderedByFollowers();
            return lstTweets;
            

        }


        [Route("api/getTopFavourite")]
        public List<entTweetView> GetTopFiveTweetsOrderedByFavorites()
        {

            cntMongo mongo = new cntMongo();
            List<entTweetView> lstTweets = mongo.GetTopFiveTweetsOrderedByFavorites();
            return lstTweets;

        }

      

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

       
   

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
