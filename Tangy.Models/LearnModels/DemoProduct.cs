using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tangy.Models.LearnModels
{
    public class DemoProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public decimal Price { get; set; }
        public List<DemoProductProp> ProductProperties { get; set; }

    }
}
