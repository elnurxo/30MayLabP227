using System;

namespace _30MayLab
{
    class Program
    {
        static void Main(string[] args)
        {
            //Employee employee1 = new Employee("Eli","Nesrullayev")
            //{
            //    Position = "HR",
            //    Salary = 1200,
            //    Age = 21
            //};
            //Employee employee2 = new Employee("Rafet", "Memmedov")
            //{
            //    Position = "Development",
            //    Salary = 2200,
            //    Age = 24
            //};
            //Employee employee3 = new Employee("Vaqif", "Aliyev")
            //{
            //    Position = "Designer",
            //    Salary = 3000,
            //    Age = 33
            //};

            //Employee[] employees = new Employee[3];

            //employees[0] = employee1;
            //employees[1] = employee2;
            //employees[2] = employee3;

            ////FILTER 
            //Console.Write("Enter Position: ");
            //string position = Console.ReadLine();

            //for (int i = 0; i < employees.Length; i++)
            //{
            //    if (employees[i].Position==position)
            //    {
            //        employees[i].ShowInfo();
            //    }
            //}


            Bird robin = new Bird("robin");
            robin.Fly();

            Fish shark = new Fish("shark");
            shark.Swim();

        }
    }
}
