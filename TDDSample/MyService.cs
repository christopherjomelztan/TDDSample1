using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDSample
{
    public class MyService
    {
        private IDbManager _dbManager;


        public MyService(IDbManager dbManager)
        {
            _dbManager = dbManager;
        }

        public void Save(Item i)
        {
            //var dbManager = new DbManager();
            _dbManager.SaveToDb(i);
        }
    }
}
