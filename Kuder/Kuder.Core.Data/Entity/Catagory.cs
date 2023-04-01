using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuder.Core.Data.Entity
{
    public class Category:EntityBase
    {
        public int? ParentId { get; set; }
        public bool IsActive { get; set; }
        public int OrderNo{ get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public string Url { get; set; }
    }
}
