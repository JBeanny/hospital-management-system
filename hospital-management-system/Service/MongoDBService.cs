using MongoDB.Bson;
using MongoDB.Driver;
using System.Configuration;
using System.Linq.Expressions;

namespace hospital_management_system.Service
{
    public class MongoDBService
    {
        private IMongoDatabase _database;

        public MongoDBService()
        {
            // connection
            string mongoUri = ConfigurationManager.AppSettings["MONGODB_URI"];
            string databaseName = ConfigurationManager.AppSettings["MONGODB_DB"];

            var client = new MongoClient(mongoUri);
            _database = client.GetDatabase(databaseName);
        }

        // insert action
        public void InsertDocument<T>(string collectionName, T document)
        {
            var collection = _database.GetCollection<T>(collectionName);
            collection.InsertOne(document);
        }

        // Read
        public List<T> GetAllDocuments<T>(string collectionName)
        {
            var collection = _database.GetCollection<T>(collectionName);
            return collection.Find(_ => true).ToList();
        }

        public T GetDocumentById<T>(string collectionName, ObjectId id)
        {
            var collection = _database.GetCollection<T>(collectionName);
            var filter = Builders<T>.Filter.Eq("_id", id);
            return collection.Find(filter).FirstOrDefault();
        }

        public List<T> FindDocuments<T>(string collectionName, Expression<Func<T, bool>> filterExpression)
        {
            var collection = _database.GetCollection<T>(collectionName);
            return collection.Find(filterExpression).ToList();
        }

        // Update
        public void UpdateDocument<T>(string collectionName, ObjectId id, T updatedDocument)
        {
            var collection = _database.GetCollection<T>(collectionName);
            var filter = Builders<T>.Filter.Eq("_id", id);
            collection.ReplaceOne(filter, updatedDocument);
        }

        // Delete
        public void DeleteDocument<T>(string collectionName, ObjectId id)
        {
            var collection = _database.GetCollection<T>(collectionName);
            var filter = Builders<T>.Filter.Eq("_id", id);
            collection.DeleteOne(filter);
        }

        public T GetDocumentByModelId<T>(string collectionName, string model_id_format, string model_id)
        {
            var collection = _database.GetCollection<T>(collectionName);
            var filter = Builders<T>.Filter.Eq(model_id_format, model_id);
            return collection.Find(filter).FirstOrDefault();
        }
    }
}
