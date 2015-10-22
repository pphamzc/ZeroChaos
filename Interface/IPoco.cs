using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroChaos.Service.Interface
{
    public interface IPoco <T>
    {
        T AutoPopulate();
    }
}
