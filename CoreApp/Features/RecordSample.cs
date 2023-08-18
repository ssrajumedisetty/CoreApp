// See https://aka.ms/new-console-template for more information

namespace CoreApp.Features
{
    public class RecordSample
    {
        public record Employee(int Id, string Name, long Salary);

        public record Student
        {
            public int Id { get; set; }

            public string? Name { get; set; }
        }

        public void Run()
        {
            Employee employee = this.GetEmployee();
            Console.WriteLine(employee);

            var student = this.GetStudent();
            Console.WriteLine(student);

            var student2 = this.GetStudent();
            Console.WriteLine(student == student2);

            student2.Name = "Siva Sankara" + student2.Name;
            Console.WriteLine(student == student2);
        }

        private Employee GetEmployee()
        {
            var employee = new Employee(1, "Raju", 1500);
            //employee.Salary = 20000; //Error

            return employee;
        }

        private Student GetStudent()
        {
            var student = new Student
            {
                Id = 1,
                Name = "Raju"
            };

            student.Name += " Medisetty";
            return student;
        }
    }
}
