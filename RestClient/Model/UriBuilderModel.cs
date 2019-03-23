using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestClient.Model
{
   public class UriBuilderModel
    {
        public string BaseUrl { get; set; }
        public string Path { get; set; }
        public string Query { get; set; }
    }
}
