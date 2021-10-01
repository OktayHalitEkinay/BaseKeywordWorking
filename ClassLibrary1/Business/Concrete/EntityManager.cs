using ClassLibrary1.Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Business.Concrete
{
    public class EntityManager
    {
        public Result Add()
        {
            return new SuccessResult("Kayıt basarili");
        }
    }
}
