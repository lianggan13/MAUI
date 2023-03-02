using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maui.App.Models
{
    public class FunctionGroupModel : List<FunctionItemModel>
    {
        // 组的名称 
        public string Name { get; private set; }

        public FunctionGroupModel(string name, List<FunctionItemModel> funcs) : base(funcs)
        {
            Name = name;
        }
    }
}
