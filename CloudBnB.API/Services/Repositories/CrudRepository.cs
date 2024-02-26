using CloudBnB.API.Data;
using CloudBnB.API.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CloudBnB.API.Repositories
{
    public abstract class CrudRepository<T> : ICrudRepository<T>
        where T : class, IIdentifiable
    {
        protected ApplicationDbContext _context;
        protected DbSet<T> _set;

        public CrudRepository(ApplicationDbContext context)
        {
            this._context = context;
            this._set = this._context.Set<T>();
        }

        public virtual async Task<T?> GetById(int id)
        {
            var entity = await this._set.FindAsync(id);
            return entity;
        }

        public virtual async Task<List<T>> GetAll()
        {
            var entities = await this._set.ToListAsync();
            return entities;
        }

        public virtual async Task<bool> Create(T entity)
        {
            this._set.Add(entity);
            int changed = await this._context.SaveChangesAsync();

            return changed == 1;
        }

        public virtual async Task<bool> Update(T entity)
        {
            this._set.Update(entity);
            int changed = await this._context.SaveChangesAsync();

            return changed == 1;
        }

        public virtual async Task<bool> Delete(int id)
        {
            var entity = await this.GetById(id);
            if (entity == null)
                return false;

            this._set.Remove(entity);
            int changed = await this._context.SaveChangesAsync();

            return changed == 1;
        }
    }
}
