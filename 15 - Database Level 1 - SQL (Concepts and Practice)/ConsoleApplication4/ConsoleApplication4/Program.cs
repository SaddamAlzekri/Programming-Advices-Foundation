using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class clsEmployee
    {
        private int _ID;
        private string _Name = string.Empty;

        public int ID
        {
            get
            {
                return _ID;
            }

            set
            {
                _ID = value;
            }

        }

        public string Name
        {
            get
            {
                return _Name;
            }

            set
            {
                _Name = value;
            }
 
        }
    }


    class clsCar
    {
        private string _Color = "Black";
        private int _TopSpeed = 270;

        public string color
        {
            get
            {
                return _Color;
            }
        }

        public int TopSpeed
        {
            get
            {
                return _TopSpeed;
            }
        }

    }

    class clsSoldier
    {
        public int NumberOfTheGun
        {
            get;
            set;
        }

        public int Salary
        {
            get;
            set;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            clsEmployee clsEmp = new clsEmployee();
            clsEmp.ID = 1;
            clsEmp.Name = "Saddam Hussein Al-zekri";
            Console.WriteLine("Employee ID = {0}", clsEmp.ID);
            Console.WriteLine("Employee Name = {0}", clsEmp.Name);

            Console.WriteLine("--------------------------------");

            clsCar Car = new clsCar();

            Console.WriteLine("Car Color = {0}", Car.color);
            Console.WriteLine("Car TopSpeed = {0}", Car.TopSpeed);

            Console.WriteLine("--------------------------------");

            clsSoldier Soldier = new clsSoldier();
            Soldier.NumberOfTheGun = 768575;
            Soldier.Salary = 75000;
            Console.WriteLine("Number Of The Gun = {0}", Soldier.NumberOfTheGun);
            Console.WriteLine("Salary = {0}", Soldier.Salary);

            Console.ReadLine();
        }
    }
}
