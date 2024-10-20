﻿using DotNetFireStore.Domain.Common;
using Google.Cloud.Firestore;

namespace DotNetFireStore.Application.IRepo.ICommon
{
    public interface IBaseRepository<T> where T : BaseModel
    {
        Task<List<T>> GetAllAsync();
        Task<T> GetByIdAsync(Guid id);
        Task AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
        Task<List<T>> QueryAsync(Query query);
    }
}
