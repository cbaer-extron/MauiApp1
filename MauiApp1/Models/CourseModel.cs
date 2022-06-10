using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Models
{
    public class CourseModel
    {
        public string Name { get; set; }
        public int Grade { get; set; }
        public string Subject { get; set; } 
        public DateTime StartTime { get; set; }
        public int Duration { get; set; }

    }
}
