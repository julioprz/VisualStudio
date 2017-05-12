using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using System.Data.Entity;

namespace EFRepository
{
    public class Repository : IRepository, IDisposable
    {
        protected DbContext Context;

        public Repository(DbContext context, bool autoDetectChangesEnable = false, bool proxyCreationEnable = false)
        {
            this.Context = context;
            this.Context.Configuration.AutoDetectChangesEnabled = autoDetectChangesEnable;
            this.Context.Configuration.ProxyCreationEnabled = proxyCreationEnable;
        }
        public TEntity Create<TEntity>(TEntity newEntity) where TEntity : class
        {
            //si retorna null no lo pudo crear
            TEntity Result = null;

            try
            {
                Result = Context.Set<TEntity>().Add(newEntity);
                TrySaveChanges();
            }
            catch (Exception ex)
            {
                throw (ex);
            }

            return Result;
        }

        protected virtual int TrySaveChanges() //implementacion de UnitOfWork y poder reutilizar el metodo
        {
            return Context.SaveChanges();
        }
        public bool Update<TEntity>(TEntity modifiedEntity) where TEntity : class
        {
            bool Result = false;

            try
            {
                Context.Set<TEntity>().Attach(modifiedEntity);//accede al contexto y lo meta al repositorio a la entiddad modificada
                Context.Entry<TEntity>(modifiedEntity).State = EntityState.Modified;//ingresar la entidad al contexto e indicarle si el estado es modifcado para que lo pueda ingresar, y pueda actulizarlo

                Result = TrySaveChanges() > 0; //Retorna TrySaveChanges y si es > 0 es true
            }
            catch (Exception ex)
            {
                throw (ex);
            }

            return Result;
        }
        public bool Delete<TEntity>(TEntity deletedEntity) where TEntity : class
        {
            bool Result = false;

            try
            {
                Context.Set<TEntity>().Attach(deletedEntity);//accede al contexto y lo meta al repositorio a la entiddad modificada, Se atacha la entidad para qe lo tenga el contexto...
                Context.Set<TEntity>().Remove(deletedEntity);//... y luego se elimina (Remove para que la marque como eliminada a la entidad)

                Result = TrySaveChanges() > 0; //Retorna TrySaveChanges y si es > 0 es true
            }
            catch (Exception ex)
            {
                throw (ex);
            }

            return Result;
        }

        public TEntity FindEntity<TEntity>(Expression<Func<TEntity, bool>> criteria) where TEntity : class
        {
            TEntity Result = null;
            try
            {
                Result = Context.Set<TEntity>().FirstOrDefault(criteria);
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            return Result;
        }

        public IEnumerable<TEntity> FinEntitySet<TEntity>(Expression<Func<TEntity, bool>> criteria) where TEntity : class
        {
            List<TEntity> Result = null;
            try
            {
                Result = Context.Set<TEntity>().Where(criteria).ToList();
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            return Result;
        }

        public void Dispose()
        {
            if (Context != null)
                Context.Dispose();
        }
    }
}
