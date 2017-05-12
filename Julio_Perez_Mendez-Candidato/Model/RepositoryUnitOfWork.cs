using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class RepositoryUnitOfWork:EFRepository.RepositoryUnitOfWork, IDisposable, IUnitOfWork
    {
        public RepositoryUnitOfWork(bool autoDetectChangesEnable = false, bool proxyCreationEnable = false)
            :base(new InterviewProjectEntities(), autoDetectChangesEnable, proxyCreationEnable){}
    }
}
