using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using ModelData.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;

namespace ModelData.Repositorys
{
    internal class Repository<T> : IRepository<T> where T : class
    {
        private readonly DataContext data;

        public Repository(DataContext Data)
        {
            data = Data;
        }
        public bool Add(T entity)
        {
           data.Set<T>().Add(entity);
           data.SaveChanges();
           return true;
        }

        public bool Add(IEnumerable<T> entities)
        {
            data.Set<T>().AddRange(entities);
            data.SaveChanges();
            return true;
        }

        public async Task AddAsync(T entity)
        {
            await data.Set<T>().AddAsync(entity);
            await data.SaveChangesAsync();
        }

        public async Task AddAsync(IEnumerable<T> entities)
        {
            await data.Set<T>().AddRangeAsync(entities);
            await data.SaveChangesAsync();
        }

        public bool Any()
        {
            return data.Set<T>().Any();
        }

        public bool Any(Expression<Func<T, bool>> expression)
        {
            return data.Set<T>().Any(expression);
        }

        public async Task<bool> AnyAsync()
        {
            return await data.Set<T>().AnyAsync();
        }

        public async Task<bool> AnyAsync(Expression<Func<T, bool>> expression)
        {
            return await data.Set<T>().AnyAsync(expression);
        }

        public int Count(Expression<Func<T, bool>> expression)
        {
            return data.Set<T>().Count(expression);
        }

        public int Count()
        {
            return data.Set<T>().Count();
        }

        public bool Delete(T entity)
        {
            data.Set<T>().Remove(entity);
            data.SaveChanges();
            return true;
        }

        public bool Delete(IEnumerable<T> entity)
        {
            data.Set<T>().RemoveRange(entity);
            data.SaveChanges();
            return true;
        }

        public bool Delete(int? id)
        {
            if (id == null)
                return false;

            var model = data.Set<T>().Find(id);
            if(model != null)
            {
                Delete(model);
                return true;
            }
            return false;
        }

        public bool Delete(Expression<Func<T, bool>> Predicte)
        {
            var Models = data.Set<T>().Where(Predicte);
            if(Models != null)
            {
                Delete(Models);
                return true;
            }
            return false;
        }

        public T? Find(int? id)
        {
            return data.Set<T>().Find(id);
        }

        public T? Find(Expression<Func<T, bool>> Predicte)
        {
            return data.Set<T>().FirstOrDefault(Predicte); ;
        }

        public IEnumerable<T> FindAll()
        {
            return data.Set<T>().ToList();
        }

        public IQueryable<T> FindAll(Expression<Func<T, bool>> expression)
        {
            return data.Set<T>().Where(expression);
        }

        public async Task<IEnumerable<T>> FindAllAsync()
        {
            return await data.Set<T>().ToListAsync();
        }

        public async Task<IEnumerable<T>> FindAllAsync(Expression<Func<T, bool>> expression)
        {
            return await data.Set<T>().Where(expression).ToListAsync();
        }

        public async Task<T?> FindAsync(int? id)
        {
            return await data.Set<T>().FindAsync(id);
        }

        public async Task<T?> FindAsync(Expression<Func<T, bool>> Predicte)
        {
            return await data.Set<T>().FirstOrDefaultAsync(Predicte);
        }

        public T? FindSingel(Func<T, bool> expression)
        {
            return data.Set<T>().SingleOrDefault(expression);
        }

        public IIncludableQueryable<T, Proparty> INClude<Proparty>(Expression<Func<T, Proparty>> expression)
        {
            return data.Set<T>().Include(expression);
        }

        public IQueryable<T> Skip(Expression<Func<T, bool>> Predicte)
        {
            return data.Set<T>().SkipWhile(Predicte);
        }

        public IQueryable<T> Skip(int Count)
        {
            return data.Set<T>().Skip(Count);
        }

        public IQueryable<T> Take(Expression<Func<T, bool>> Predicte)
        {
            return data.Set<T>().TakeWhile(Predicte);
        }

        public IQueryable<T> Take(int Count)
        {
            return data.Set<T>().Take(Count);
        }

        public void Update(T entity)
        {
            if(entity != null)
            {
                data.Set<T>().Update(entity);
                data.SaveChanges();
            }
        }

        public void Update(IEnumerable<T> entities)
        {
            if (entities != null)
            {
                data.Set<T>().UpdateRange(entities);
                data.SaveChanges();
            }
        }

        public void Update(Action<T> action,Expression<Func<T, bool>> predicate)
        {
            var models =  FindAll(predicate).ToList();
            foreach (var item in models)
            {
                action.Invoke(item);
                Update(item);
            }
        }

        public void Update<Proparty>(Action<T> action, Expression<Func<T, bool>> predicate, Expression<Func<T, Proparty>> expressionInClude = null)
        {
            if (expressionInClude == null)
            {
                var models = FindAll(predicate).ToList();
                foreach (var item in models)
                {
                    action.Invoke(item);
                    Update(item);
                }
            }
            else
            {
                var models = FindAll(predicate).Include(expressionInClude).ToList();
                foreach (var item in models)
                {
                    action.Invoke(item);
                    Update(item);
                }
            }
        }
    }
}
