namespace CloudBnB.API.Services.Interfaces
{
    public interface ICrudRepository<T> where T : class, IIdentifiable
    {
        /// <summary>
        /// Fetches entity based on an Id
        /// </summary>
        /// <param name="id">Id to check for</param>
        /// <param name="cancellationToken">Token to cancel execution</param>
        /// <returns>Found <typeparamref name="T"/></returns>
        public Task<T?> GetById(int id, CancellationToken cancellationToken);

        /// <summary>
        /// Fetches all entities
        /// </summary>
        /// <param name="cancellationToken">Token to cancel execution</param>
        /// <returns>A list of <typeparamref name="T"/></returns>
        public Task<List<T>> GetAll(CancellationToken cancellationToken);

        /// <summary>
        /// Create entity
        /// </summary>
        /// <param name="entity">Entity to be created</param>
        /// <param name="cancellationToken">Token to cancel execution</param>
        /// <returns>Given entity</returns>
        public Task<T> Create(T entity, CancellationToken cancellationToken);

        /// <summary>
        /// Updates entity
        /// </summary>
        /// <param name="entity">Entity to be updated</param>
        /// <param name="cancellationToken">Token to cancel execution</param>
        /// <returns>Given entity</returns>
        public Task<T> Update(T entity, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes an entity
        /// </summary>
        /// <param name="id">Id of entity to be deleted</param>
        /// <param name="cancellationToken">Token to cancel execution</param>
        /// <returns>Boolean determining success</returns>
        public Task<bool> Delete(int id, CancellationToken cancellationToken);
    }
}