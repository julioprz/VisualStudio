using Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFRepository
{
    public class RepositoryUnitOfWork : Repository, IRepository, IUnitOfWork, IDisposable
    {
        protected DbContext Context;
        public RepositoryUnitOfWork(DbContext context, bool autoDetectChangesEnable = false, bool proxyCreationEnable = false):
            base(context, autoDetectChangesEnable,proxyCreationEnable)//debido a que no se pueden heredar contructores, ebtonces se invoca al constructor de la clase base con los 2 parametros
        {
          
        }

        protected override int TrySaveChanges()
        {
            return 0;
        }
        int IUnitOfWork.Save()//implementacion de la interface, pra que el metodo save viva solo en la interface IUnitOfWork, disponible solo para tipos IUnitOfWork
        {
           int Result = 0;
            try
            {
                Result = Context.SaveChanges();
            }
            catch(Exception ex)
            {
                throw (ex);
            }
            return Result;
        }
    }
}
