using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToManyAssociationApp {
    class Course {
        public string Code { get; set; }
        public string Title { get; set; }
        public double Credit { get; set; }
        public  List<Course> Courses { get; set; }
    }
}
