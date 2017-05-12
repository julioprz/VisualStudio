using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IUnitOfWork:IRepository
    {
        //implementa/define lo de Iterface Repository y va a permitir hacer las transacciones o guardar, si uno falla hace un rollback
        int Save();
    }
}
