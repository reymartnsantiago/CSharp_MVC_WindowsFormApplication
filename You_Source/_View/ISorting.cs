using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace You_Source._View
{
   public interface ISorting
    {
        String SortingMethod { get; set; }
        String Output { get; set; }
        String StringValue { get; set; }
    }
}
