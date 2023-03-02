using Maui.App.Models;
using System.Collections.ObjectModel;

namespace Maui.App.ViewModels
{
    public class MainViewModel : BindableObject, IQueryAttributable
    {
        public List<CarsouelItemModel> CarsouelList { get; set; }

        public ObservableCollection<FunctionItemModel> OftenList { get; set; }

        public List<FunctionGroupModel> FuncList { get; set; }

        public MainViewModel()
        {
            CarsouelList = new List<CarsouelItemModel>() {
               new CarsouelItemModel{Image= "banner.png" },
               new CarsouelItemModel{Image= "banner.png" },
               new CarsouelItemModel{Image= "banner.png" },
               new CarsouelItemModel{Image= "banner.png" },
               new CarsouelItemModel{Image= "banner.png" }
            };

            OftenList = new ObservableCollection<FunctionItemModel>()
            {
                new FunctionItemModel{
                    ButtonIcon="icon/icon_1.svg",
                    Text="设备看板",
                    ViewRoute="//DevicePage",// 对应的跳转页面
                    OpenPage=new Command<FunctionItemModel>(OpenPage)
                },
                new FunctionItemModel{
                    ButtonIcon="icon/icon_2.svg",
                    Text="仪表",
                     ViewRoute="//MeterPage",
                    OpenPage=new Command<FunctionItemModel>(OpenPage)
                },
                new FunctionItemModel{
                    ButtonIcon="icon/icon_4.svg",
                    Text="生产统计",
                },
                new FunctionItemModel{
                    ButtonIcon="icon/icon_5.svg",
                    Text="流程审批",
                },
                new FunctionItemModel{
                    ButtonIcon="icon/icon_6.svg",
                    Text="个人中心",
                },
            };


            #region 初始化全部功能 
            FuncList = new List<FunctionGroupModel>();
            FuncList.Add(new FunctionGroupModel("设备管理", new List<FunctionItemModel>
            {
               new FunctionItemModel
                {
                    Text = "功能一",
                    ButtonIcon = "icon_1_1.svg",
                    ViewRoute="//Device"
                },
                new FunctionItemModel
                {
                    Text = "功能二",
                    ButtonIcon = "icon_1_2.svg",
                },
                new FunctionItemModel
                {
                    Text = "功能三",
                    ButtonIcon = "icon_1_3.svg",
                },
                new FunctionItemModel
                {
                    Text = "功能四",
                    ButtonIcon = "icon_1_4.svg",
                },
                new FunctionItemModel
                {
                    Text = "功能五",
                    ButtonIcon = "icon_1_5.svg",
                },
                new FunctionItemModel
                {
                    Text = "功能六",
                    ButtonIcon = "icon_1_6.svg",
                }
            }));

            FuncList.Add(new FunctionGroupModel("生产管理", new List<FunctionItemModel>
            {
                new FunctionItemModel
                {
                     Text = "功能一",
                    ButtonIcon = "icon_2_1.svg",
                },
                new FunctionItemModel
                {
                     Text = "功能二",
                    ButtonIcon = "icon_2_2.svg",
                },
                new FunctionItemModel
                {
                     Text = "功能三",
                    ButtonIcon = "icon_2_3.svg",
                },
                new FunctionItemModel
                {
                     Text = "功能四",
                    ButtonIcon = "icon_2_4.svg",
                },
                new FunctionItemModel
                {
                     Text = "功能五",
                    ButtonIcon = "icon_2_5.svg",
                },
            }));
            FuncList.Add(new FunctionGroupModel("品质管理", new List<FunctionItemModel>
            {
                new FunctionItemModel
                {
                    Text = "功能一",
                    ButtonIcon = "icon_1_1.svg",
                    ViewRoute="//Device"
                },
                new FunctionItemModel
                {
                    Text = "功能二",
                    ButtonIcon = "icon_1_2.svg",
                },
                new FunctionItemModel
                {
                    Text = "功能三",
                    ButtonIcon = "icon_1_3.svg",
                },
                new FunctionItemModel
                {
                    Text = "功能四",
                    ButtonIcon = "icon_1_4.svg",
                },
                new FunctionItemModel
                {
                    Text = "功能五",
                    ButtonIcon = "icon_1_5.svg",
                },
                new FunctionItemModel
                {
                    Text = "功能六",
                    ButtonIcon = "icon_1_6.svg",
                }
            }));

            FuncList.Add(new FunctionGroupModel("物料管理", new List<FunctionItemModel>
            {
                new FunctionItemModel
                {
                     Text = "功能一",
                    ButtonIcon = "icon_2_1.svg",
                },
                new FunctionItemModel
                {
                     Text = "功能二",
                    ButtonIcon = "icon_2_2.svg",
                },
                new FunctionItemModel
                {
                     Text = "功能三",
                    ButtonIcon = "icon_2_3.svg",
                },
                new FunctionItemModel
                {
                     Text = "功能四",
                    ButtonIcon = "icon_2_4.svg",
                },
                new FunctionItemModel
                {
                     Text = "功能五",
                    ButtonIcon = "icon_2_5.svg",
                },
            }));
            #endregion
        }

        private async void OpenPage(FunctionItemModel model)
        {
            await Shell.Current.GoToAsync(model.ViewRoute);
        }

        public void ApplyQueryAttributes(IDictionary<string, object> query)
        {
            string username = query["username"].ToString();
            string pwd = query["pwd"].ToString();
        }
    }
}
