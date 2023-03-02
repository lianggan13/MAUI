using MeetingRoom.Models;
using System.Reflection;

namespace MeetingRoom.ViewModels
{
    public class MainViewModel : BindableObject
    {
        public List<MenuModel> Menus { get; set; } = new List<MenuModel>();
        public List<MenuModel> SubMenus { get; set; } = new List<MenuModel>();
        public List<MonitorItemModel> MonitorList { get; set; } = new List<MonitorItemModel>();
        public Command<object> TapCommand { get; set; }
        public List<LightModel> Lights { get; set; } = new List<LightModel>();
        public List<LightModel> Lights2 { get; set; } = new List<LightModel>();

        private bool _state;

        public bool State
        {
            get { return _state; }
            set
            {
                if (_state != value)
                {
                    _state = value;
                    OnPropertyChanged();
                }
            }
        }

        public Command<object> ShowPageCommand => new Command<object>(ShowPage);

        private ContentView viewContent;

        public ContentView ViewContent
        {
            get => viewContent;
            set
            {
                viewContent = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {

            Menus.Add(new Models.MenuModel()
            {
                IsSelected = true,
                MenuHeader = "首页",
                MenuIcon = "\ue62e",
                TargetView = "FirstView"
            });
            Menus.Add(new Models.MenuModel()
            {
                MenuHeader = "会议模式",
                MenuIcon = "\ue6af",
                TargetView = "MeetingView"
            });
            Menus.Add(new Models.MenuModel()
            {
                MenuHeader = "投影模式",
                MenuIcon = "\ue715",
                TargetView = "ProjectionView"
            });
            Menus.Add(new Models.MenuModel()
            {
                MenuHeader = "休息模式",
                MenuIcon = "\ue667",
                TargetView = "RestView"
            });
            Menus.Add(new Models.MenuModel()
            {
                MenuHeader = "离开模式",
                MenuIcon = "\ueb6e",
                TargetView = "ExitView"
            });
            Menus.Add(new Models.MenuModel()
            {
                MenuHeader = "分项控制",
                MenuIcon = "\ue638",
                TargetView = "DetailView"
            });


            // 从数据库获取
            MonitorList.Add(new MonitorItemModel
            {
                Icon = "\ue63d",
                Header = "PM2.5",
                Value = 8,
                Unit = "ug/m³",
                State = "优"
            });
            MonitorList.Add(new MonitorItemModel
            {
                Icon = "\ue637",
                Header = "二氧化碳",
                Value = 566,
                Unit = "ppm",
                State = "优"
            });
            MonitorList.Add(new MonitorItemModel
            {
                Icon = "\ue633",
                Header = "TVOC",
                Value = 125,
                Unit = "ppb",
                State = "优"
            });
            MonitorList.Add(new MonitorItemModel
            {
                Icon = "\ue618",
                Header = "温度",
                Value = 24,
                Unit = "℃",
                State = "舒适"
            });
            MonitorList.Add(new MonitorItemModel
            {
                Icon = "\ue60a",
                Header = "湿度",
                Value = 46,
                Unit = "%RH",
                State = "舒适"
            });
            MonitorList.Add(new MonitorItemModel
            {
                Icon = "\ueb66",
                Header = "亮度",
                Value = 350,
                Unit = "lx",
                State = "舒适"
            });

            SubMenus.Add(new MenuModel
            {
                IsSelected = true,
                MenuIcon = "\ue605",
                MenuHeader = "窗帘"
            });
            SubMenus.Add(new MenuModel
            {
                MenuIcon = "\ue622",
                MenuHeader = "投影"
            });
            SubMenus.Add(new MenuModel
            {
                MenuIcon = "\ue61e",
                MenuHeader = "电视"
            });
            SubMenus.Add(new MenuModel
            {
                MenuIcon = "\ue630",
                MenuHeader = "灯光"
            });
            SubMenus.Add(new MenuModel
            {
                MenuIcon = "\ue611",
                MenuHeader = "音量"
            });
            SubMenus.Add(new MenuModel
            {
                MenuIcon = "\ue60b",
                MenuHeader = "摄像"
            });


            for (int i = 0; i < 16; i++)
            {
                Lights.Add(new() { State = false });
            }
            for (int i = 0; i < 5; i++)
            {
                Lights2.Add(new() { State = false });
            }

            TapCommand = new Command<object>(obj =>
            {
                var model = obj as LightModel;
                if (model != null)
                {
                    model.State = !model.State;
                }
            });
        }


        private void ShowPage(object obj)
        {
            var model = obj as Models.MenuModel;
            if (model != null)
            {
                //model.TargetView
                var type = Assembly.GetExecutingAssembly().GetType("MeetingRoom.Pages." + model.TargetView);
                ViewContent = null;
                ViewContent = (ContentView)Activator.CreateInstance(type);
            }
        }
    }
}
