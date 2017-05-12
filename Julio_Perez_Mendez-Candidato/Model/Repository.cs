using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Repository:EFRepository.Repository, IDisposable, IRepository
    {
        public Repository(bool autoDetectChangesEnable=false, bool proxyCreationEnable=false)
            :base(new InterviewProjectEntities(), autoDetectChangesEnable, proxyCreationEnable)
        {

        }
    }
}
