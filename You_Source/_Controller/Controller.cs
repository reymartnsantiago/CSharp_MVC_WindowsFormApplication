using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using You_Source._Model;
using You_Source._View;

namespace You_Source._Controller
{
  
    public class Controller
    {
        private readonly ISorting sortView;
        
        public Controller(ISorting view){
            sortView = view;
        }

        public void SortString(){
            Model model = new Model();
            model.SortingMethod = sortView.SortingMethod;
            model.StringValue = sortView.StringValue;
            sortView.Output = model.SorrtArray();
        }

    }
}
