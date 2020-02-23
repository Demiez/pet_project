using code_first_EF.Model;
using System;

namespace code_first_EF_Console
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var ctx = new SchoolContext())
            {
                var stud = new Student() { StudentName = "Bill" };

                ctx.Students.Add(stud);
                ctx.SaveChanges();
            }
            //var ctx = new SchoolContext();
            //var stud = new Student() { StudentName = "Bill" };

            //ctx.Students.Add(stud);
            //ctx.SaveChanges();

            Console.Write("Student saved successfully!");
        }
    }
}
