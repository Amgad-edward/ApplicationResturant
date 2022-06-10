using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;


namespace ModelData.Repositorys
{
    public interface IRepository<Entity>
    {
        bool Add(Entity entity);

        bool Add(IEnumerable<Entity> entities);

        void Update(Entity entity);

        void Update(IEnumerable<Entity>  entities);

        void Update(Action<Entity> action , Expression<Func<Entity, bool> > predicate);
        void Update<Proparty>(Action<Entity> action, Expression<Func<Entity, bool>> predicate, Expression<Func<Entity, Proparty>> expressionInClude = null);


        bool Delete(Entity entity);

        bool Delete(IEnumerable<Entity> entity);

        bool Delete(int? id);

        bool Delete(Expression<Func<Entity, bool>> Predicte);

        Entity Find(int? id);

        Entity Find(Expression<Func<Entity, bool>> Predicte);

        IEnumerable<Entity> FindAll();

        Entity FindSingel(Func<Entity ,bool> expression);
        IQueryable<Entity> FindAll(Expression<Func<Entity, bool>> expression );

        IQueryable<Entity> Take(Expression<Func<Entity, bool>> Predicte);

        IQueryable<Entity> Take(int Count);

        IQueryable<Entity> Skip(Expression<Func<Entity, bool>> Predicte);

        IQueryable<Entity> Skip(int Count);

        IIncludableQueryable<Entity , Proparty> INClude<Proparty>(Expression<Func<Entity, Proparty>> expression);

        bool Any();

        bool Any(Expression<Func<Entity, bool>> expression);

        int Count();
        int Count(Expression<Func<Entity, bool>> expression);

        ////Async
        Task AddAsync(Entity entity);

        Task AddAsync(IEnumerable<Entity> entities);

        Task<Entity> FindAsync(int? id);

        Task<Entity> FindAsync(Expression<Func<Entity, bool>> Predicte);

        Task<IEnumerable<Entity>> FindAllAsync();

        Task<IEnumerable<Entity>> FindAllAsync(Expression<Func<Entity, bool>> expression);

        Task<bool> AnyAsync();

        Task<bool> AnyAsync(Expression<Func<Entity, bool>> expression);

    }
}
