namespace CloudBnB.API.Services.Interfaces
{
    public interface ICrudRepository<T> where T : class, IIdentifiable
    {
        /// <summary>
        /// Fetches entity based on an Id
        /// </summary>
        /// <param name="id">Id to check for</param>
        /// <returns>Found <typeparamref name="T"/></returns>
        public Task<T?> GetById(int id);

        /// <summary>
        /// Fetches all entities
        /// </summary>
        /// <returns>A list of <typeparamref name="T"/></returns>
        public Task<List<T>> GetAll();

        /// <summary>
        /// Create entity
        /// </summary>
        /// <param name="entity">Entity to be created</param>
        /// <returns>Given entity</returns>
        public Task<T> Create(T entity);

        /// <summary>
        /// Updates entity
        /// </summary>
        /// <param name="entity">Entity to be updated</param>
        /// <returns>Given entity</returns>
        public Task<T> Update(T entity);

        /// <summary>
        /// Deletes an entity
        /// </summary>
        /// <param name="id">Id of entity to be deleted</param>
        /// <returns>Boolean determining success</returns>
        public Task<bool> Delete(int id);
    }
}