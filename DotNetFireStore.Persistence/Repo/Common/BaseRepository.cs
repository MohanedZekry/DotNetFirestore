using DotNetFireStore.Application.Common.Exceptions;
using DotNetFireStore.Application.IService.ICommon;
using DotNetFireStore.Domain.Common;
using DotNetFireStore.Persistence.Context;
using Google.Cloud.Firestore;

namespace DotNetFireStore.Persistence.Repo.Common
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseModel
    {
        private readonly FirebaseDbContext _context;
        private readonly string _collectionName;

        public BaseRepository(FirebaseDbContext context, string collectionName)
        {
            _context = context;
            _collectionName = collectionName;
        }
        public async Task AddAsync(T entity)
        {
            CollectionReference collection = _context.GetCollection(_collectionName);
            await collection.AddAsync(entity);
        }

        public async Task DeleteAsync(T entity)
        {
            DocumentReference docRef = _context.GetCollection(_collectionName).Document(entity.ID.ToString());
            await docRef.DeleteAsync();
        }

        public async Task<List<T>> GetAllAsync()
        {
            CollectionReference collection = _context.GetCollection(_collectionName);
            QuerySnapshot snapshot = await collection.GetSnapshotAsync();
            return snapshot.Documents.Select(doc => doc.ConvertTo<T>()).ToList();
        }

        public async Task<T> GetByIdAsync(string id)
        {
            DocumentReference docRef = _context.GetCollection(_collectionName).Document(id.ToString());
            DocumentSnapshot snapshot = await docRef.GetSnapshotAsync();

            if (snapshot.Exists)
            {
                return snapshot.ConvertTo<T>();
            }

            throw new NoDataFoundException(id);
        }

        public async Task<List<T>> QueryAsync(Query query)
        {
            QuerySnapshot snapshot = await query.GetSnapshotAsync();
            return snapshot.Documents.Select(doc => doc.ConvertTo<T>()).ToList();
        }

        public async Task UpdateAsync(T entity)
        {
            DocumentReference docRef = _context.GetCollection(_collectionName).Document(entity.ID.ToString());
            await docRef.SetAsync(entity, SetOptions.Overwrite);
        }
    }
}
