namespace Basics.Models
{
    public class Repository
    {
        private static readonly List<Course> _courses = new();
        static Repository()
        {
            _courses = new List<Course>()
            {
            new Course(){
                Id=1,
                Title="ASP",
                Description="Güzel kurs valla",
                Image="aspnet.jpg",
                isActive=false,
                isHome=false,
                Tags=new string[]{"asp", "web geliştirme"}
            },
            new Course(){
                Id=2,
                Title="Javascript",
                Description="Güzel kurs valla",
                Image="javascript.png",
                isActive=true,
                isHome=true,
                Tags=new string[]{"javascript", "web geliştirme"}
            },
            new Course(){
                Id=3,
                Title="NodeJS",
                Description="Güzel kurs valla",
                Image="nodejs.jpg",
                isActive=true,
                isHome=true,
                Tags=new string[]{"nodejs", "web geliştirme"}
            },
            new Course(){
                Id=4,
                Title="PHP",
                Description="Güzel kurs valla",
                Image="aspnet.jpg",
                isActive=false,
                isHome=false,
                Tags=new string[]{"php", "web geliştirme"}
            },
            };
        }
        public static List<Course> Courses
        {
            get
            {
                return _courses;
            }
        }
        public static Course? GetById(int? id)
        {
            return _courses.FirstOrDefault(c => c.Id == id);
        }
    }
}