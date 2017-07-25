using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDSample
{
    public interface IDbManager
    {
        void SaveToDb(Item i);
    }
}
