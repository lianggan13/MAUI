using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maui.App.Models
{
    public class FunctionItemModel
    {
        // 相对应的按钮图标 
        public string ButtonIcon { get; set; }
        // 功能名称
        public string Text { get; set; }
        // 跳转的路由
        public string ViewRoute { get; set; }
        // 跳转动作
        public Command<FunctionItemModel> OpenPage { get; set; }
    }
}
