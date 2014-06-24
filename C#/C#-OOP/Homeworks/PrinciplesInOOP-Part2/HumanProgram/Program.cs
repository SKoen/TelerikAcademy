using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanProgram
{
    class Program
    {
        static void Main()
        {
            Student[] listOfStudents = new Student[] 
            {
                new Student("Pesho", "Kirov", 5),
                new Student("Ivan", "Kirov", 4),
                new Student("Gosho", "Kirov", 2),
                new Student("Mirko", "Kirov", 3),
                new Student("Sasho", "Kirov", 3),
                new Student("Pesho", "Salov", 5),
                new Student("Ivan", "Geogov", 4),
                new Student("Gosho", "Nikolov", 2),
                new Student("Mirko", "Zarov", 3),
                new Student("Sasho", "Zoro", 3)
            };

            listOfStudents.OrderByDescending(p => p.Grade).ToList().ForEach(Console.WriteLine);
            Console.WriteLine();
            Worker[] listOfWorkers = new Worker[]
            {
                new Worker("Nikolai", "Zahirov", 300, 4),
                new Worker("Kristiqn", "Zahirov", 450, 8),
                new Worker("Zdravko", "Zahirov", 3000, 8),
                new Worker("Pesho", "Zahirov", 1000, 8),
                new Worker("Gosho", "Zahirov", 350, 4),
                new Worker("Kiro", "Zahirov", 800, 8),
                new Worker("Vlado", "Zahirov", 1200, 8),
                new Worker("Stankata", "Zahirov", 1300, 8),
                new Worker("Iliq", "Zahirov", 2300, 8),
                new Worker("Ilqn", "Zahirov", 500, 8),
                new Worker("Ceco", "Zahirov", 1500, 8)
            };

            listOfWorkers.OrderBy(p => p.MoneyPerHour()).ToList().ForEach(Console.WriteLine);

        }
    }
}
