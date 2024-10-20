using Google.Cloud.Firestore;
using Microsoft.Extensions.Configuration;

namespace DotNetFireStore.Persistence.Context
{
    public class FirebaseDbContext
    {
        private readonly FirestoreDb _fireStoreDb;

        public FirebaseDbContext(IConfiguration configuration)
        {
            string projectId = configuration["Firestore:ProjectId"];
            _fireStoreDb = FirestoreDb.Create(projectId);
        }
        public CollectionReference GetCollection(string collectionName)
        {
            return _fireStoreDb.Collection(collectionName);
        }
    }
}
