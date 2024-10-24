using Google.Cloud.Firestore;

namespace DotNetFireStore.Domain.Common
{
    [FirestoreData]
    public class BaseModel
    {
        [FirestoreProperty]
        public string ID { get; set; } = Guid.NewGuid().ToString();
        [FirestoreProperty]
        public DateTimeOffset DateCreated { get; set; } = DateTimeOffset.Now;
        [FirestoreProperty]
        public DateTimeOffset? DateUpdated { get; set; }
        [FirestoreProperty]
        public DateTimeOffset? DateDeleted { get; set; }
        public Guid? UserID { get; set; }
        [FirestoreProperty]
        public bool IsDeleted { get; set; } = false;
    }
}
