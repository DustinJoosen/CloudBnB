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

        public virtual async Task<T?> GetById(int id, CancellationToken cancellationToken)
        {
            var entity = await this._set.FindAsync(id, cancellationToken);
            return entity;
        }

        public virtual async Task<List<T>> GetAll(CancellationToken cancellationToken)
        {
            var entities = await this._set.ToListAsync(cancellationToken);
            return entities;
        }

        public virtual async Task<T> Create(T entity, CancellationToken cancellationToken)
        {
            this._set.Add(entity);
            await this._context.SaveChangesAsync(cancellationToken);

            return entity;
        }

        public virtual async Task<T> Update(T entity, CancellationToken cancellationToken)
        {
            this._set.Update(entity);
            await this._context.SaveChangesAsync(cancellationToken);

            return entity;
        }

        public virtual async Task<bool> Delete(int id, CancellationToken cancellationToken)
        {
            var entity = await this.GetById(id, cancellationToken);
            if (entity == null)
                return false;

            this._set.Remove(entity);
            int changed = await this._context.SaveChangesAsync(cancellationToken);

            return changed == 1;
        }

        public virtual async Task<bool> Exists(int id, CancellationToken cancellationToken)
        {
            return await this._set.AnyAsync(entity => entity.Id == id, cancellationToken);
        }
    }
}
