using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccessValues
{
    public class connectionValues
    {
        private string server = string.Empty;

        public string Server
        {
            get { return server; }
            set { server = value; }
        }
        private string database = string.Empty;

        public string Database
        {
            get { return database; }
            set { database = value; }
        }

    }
}
