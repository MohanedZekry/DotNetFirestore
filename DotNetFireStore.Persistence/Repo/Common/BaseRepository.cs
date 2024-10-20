using DotNetFireStore.Application.IRepo.ICommon;
using DotNetFireStore.Domain.Common;
using Google.Cloud.Firestore;

namespace DotNetFireStore.Persistence.Repo.Common
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseModel
    {
        public FirestoreDb _firestoreDb;
        public Task AddAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<T>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<T> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<T>> QueryAsync(Query query)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
