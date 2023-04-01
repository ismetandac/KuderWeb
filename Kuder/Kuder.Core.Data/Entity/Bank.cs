using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuder.Core.Data.Entity
{
    public class Bank:EntityBase
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public string StoreKey { get; set; }
        public string PostUrl { get; set; }
        public string TerminalID { get; set; }
    }
}
