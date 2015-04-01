using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using LinqToTwitter;

namespace TwitterGate.DAL
{
    public class cntMongo
    {
        MongoDatabase mongoDatabase;
        private void InitializeDB()
        {
            MongoClient mongoClient = new MongoClient("Server=localhost:27017");
            MongoServer MongoSrv = mongoClient.GetServer();
            mongoDatabase = MongoSrv.GetDatabase("TwitterDB");
        }

        public void InsertTweets(List<Status> AllTweets)
        {
            InitializeDB();

            mongoDatabase.GetCollection<BsonDocument>("Tweets").RemoveAll();
            MongoCollection<BsonDocument> Tweets = mongoDatabase.GetCollection<BsonDocument>("Tweets");

            foreach (Status item in AllTweets)
            {
                BsonDocument BsonDoc = MongoDB.Bson.Serialization.BsonSerializer.Deserialize<BsonDocument>(item.ToBson());

                Tweets.Insert(BsonDoc);
            }
        }

        public List<entTweetView> GetTopFiveTweetsOrderedByFollowers()
        {
            InitializeDB();

            var collection = mongoDatabase.GetCollection<entTweet>("Tweets");
            List<entTweetView> lstTweets = (from tw in collection.FindAll()
                                         orderby tw.User.FollowersCount descending
                                            select new entTweetView
                                {
                                    Text = tw.Text,
                                    Name = tw.User.Name,
                                    Type = tw.Type,
                                    RetweetCount = tw.RetweetCount,
                                    FavoriteCount = tw.FavoriteCount,
                                    FollowersCount = tw.User.FollowersCount,
                                    CreatedAt = tw.CreatedAt
                                }).Take(5).ToList();

            return lstTweets;
            
        }



        public List<entTweetView> GetTopFiveTweetsOrderedByRetweets()
        {
            InitializeDB();

            var collection = mongoDatabase.GetCollection<entTweet>("Tweets");
            List<entTweetView> lstTweets = (from tw in collection.FindAll()
                                        orderby tw.RetweetCount descending
                                        select new entTweetView
                                        {
                                            Text = tw.Text,
                                            Name = tw.User.Name,
                                            Type = tw.Type,
                                            RetweetCount = tw.RetweetCount,
                                            FavoriteCount = tw.FavoriteCount,
                                            FollowersCount = tw.User.FollowersCount,
                                            CreatedAt = tw.CreatedAt
                                        }).Take(5).ToList();

            return lstTweets;
        }
        public List<entTweetView> GetTopFiveTweetsOrderedByFavorites()
        {
            InitializeDB();

            var collection = mongoDatabase.GetCollection<entTweet>("Tweets");
            List<entTweetView> lstTweets = (from tw in collection.FindAll()
                                        orderby tw.FavoriteCount descending
                                        select new entTweetView
                                        {
                                            Text = tw.Text,
                                            Name = tw.User.Name,
                                            Type = tw.Type,
                                            RetweetCount = tw.RetweetCount,
                                            FavoriteCount = tw.FavoriteCount,
                                            FollowersCount = tw.User.FollowersCount,
                                            CreatedAt = tw.CreatedAt
                                        }).Take(5).ToList();

            return lstTweets;
        }

        public List<entTweetView> GetTopFiveTweetsOrderedByCreationDate()
        {
            InitializeDB();

            var collection = mongoDatabase.GetCollection<entTweet>("Tweets");
            List<entTweetView> lstTweets = (from tw in collection.FindAll()
                                        orderby tw.CreatedAt descending
                                        select new entTweetView
                                        {
                                            Text = tw.Text,
                                            Name = tw.User.Name,
                                            Type = tw.Type,
                                            RetweetCount = tw.RetweetCount,
                                            FavoriteCount = tw.FavoriteCount,
                                            FollowersCount = tw.User.FollowersCount,
                                            CreatedAt = tw.CreatedAt
                                        }).Take(5).ToList();

            return lstTweets;
        }


       
    }
}
