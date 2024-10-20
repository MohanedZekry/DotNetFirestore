using DotNetFireStore.Domain.Common;
using Google.Cloud.Firestore;

namespace DotNetFireStore.Domain.Entities
{
    [FirestoreData]
    public class Group : BaseModel
    {
        [FirestoreProperty]
        public string GroupName { get; set; }
    }
}
