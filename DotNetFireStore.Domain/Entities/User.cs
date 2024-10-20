using DotNetFireStore.Domain.Common;
using Google.Cloud.Firestore;

namespace DotNetFireStore.Domain.Entities
{
    [FirestoreData]
    public class User : BaseModel
    {
        [FirestoreProperty]
        public string Name { get; set; }
        [FirestoreProperty]
        public string Email { get; set; }
    }
}
