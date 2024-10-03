namespace LearnWebAPI.Models
{
    public class CollegeRepository
    {
        public static List<Student> Students { get; set; } = new List<Student>{
                new Student()
                {
                    Id = 1,
                    StudentName = "Deez",
                    Email = "deez@abc.com",
                    Address = "Sk, India"
                },
                new Student()
                {
                    Id = 2,
                    StudentName = "Reez",
                    Email = "reez@abc.com",
                    Address = "BH, India"
                },
            };
    }
}
