using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineLesson.Models
{
    internal class CourseItemModel
    {
        public string Cover { get; set; }
        public string Name { get; set; }
        public string Classify { get; set; }
        public int StudyCount { get; set; }
        public int Favorite { get; set; }
    }
}
