using PersonelBilgiSistemiDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelBilgiSistemiBL
{
    public class DBInstance
    {
        private static ProjectContext _instance;
        public static ProjectContext Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ProjectContext();
                }
                return _instance;
            }

        }
    }
}
