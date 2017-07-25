using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDSample
{
    public class DbManager : IDbManager
    {
        public void SaveToDb(Item i)
        {
            Console.WriteLine($"{i.Name} - {i.Description} saved to database.");
        }
    }
}
