using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SerializeDeserializeJsonXml
{
    public class ProductModelRoot
    {
        public ProductModel ProductModel { get; set; }
    }
    public class ProductModel
    {
        public string produto { get; set; }
        public float preco { get; set; }
        public int quantidade { get; set; }
    }

}
