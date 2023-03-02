using OnlineLesson.Models;

namespace OnlineLesson.ViewModels
{
    internal class HomeViewModel
    {
        public List<CarouselItemModel> CarouselItems { get; set; } = new List<CarouselItemModel>();

        public List<TeacherItemModel> Teachers { get; set; } = new List<TeacherItemModel>();

        public List<CourseItemModel> Courses { get; set; } = new List<CourseItemModel>();

        public HomeViewModel()
        {
            for (int i = 0; i < 5; i++)
            {
                CarouselItems.Add(new CarouselItemModel()
                {
                    Title = "如何成为年薪60W的.NET架构师",
                    Description = "拓展技术视野，加强技术深度，蜕变架构师"
                });

            }

            for (int i = 0; i < 10; i++)
            {
                Teachers.Add(new TeacherItemModel()
                {
                    Avatar = "Images/eleven.jpg",
                    Name = "Eleven"
                });
            }

            for (int i = 0; i < 20; i++)
            {
                Courses.Add(new CourseItemModel
                {
                    Cover = "https://www.zhaoxiedu.net/file/11/dbc91389-5c84-40af-97dd-686279b0723c.jpg",
                    Name = "【薪选T9】C#/.NET架构师蜕变营VIP班",
                    Classify = ".NET",
                    StudyCount = 6212,
                    Favorite = 1204
                });
            }
        }
    }
}
