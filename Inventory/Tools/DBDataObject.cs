using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    public class DBDataObject
    {
        public string code { get; set; }
        public string message { get; set; }
        public ArrayList items { get; set; }
        public DataTable data { get; set; }
    }
}
