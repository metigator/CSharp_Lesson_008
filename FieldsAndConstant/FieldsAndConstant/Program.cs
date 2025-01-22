namespace FieldsAndConstant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double TAX = 0.03;
            //-----------------------------------------
            //=======  First way   ===========
            //------------------------------------------
            //----- Second Employee
            Console.WriteLine("First Employee");
            Console.Write("First Name: ");
            var FName = Console.ReadLine();

            Console.Write("Last Name: ");
            var LName = Console.ReadLine();

            Console.Write("Wage: ");
            var wage = Convert.ToDouble(Console.ReadLine());

            Console.Write("LoggedHours: ");
            var loggedHours = Convert.ToDouble(Console.ReadLine());

            var netSalary = wage * loggedHours - (wage * loggedHours * TAX);

            Console.WriteLine($"First Name :{FName}");
            Console.WriteLine($"Last Name :{LName}");
            Console.WriteLine($"Wage :{wage}");
            Console.WriteLine($"Logged Hours :{loggedHours}");
            Console.WriteLine($"Net Salary :{netSalary}");

            //----- Second Employee

            Console.WriteLine("Second Employee");
            Console.Write("First Name: ");
            var FName1 = Console.ReadLine();

            Console.Write("Last Name: ");
            var LName1 = Console.ReadLine();

            Console.Write("Wage: ");
            var wage1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("LoggedHours: ");
            var loggedHours1 = Convert.ToDouble(Console.ReadLine());

            var netSalary1 = wage * loggedHours - (wage * loggedHours * TAX);

            Console.WriteLine($"First Name :{FName1}");
            Console.WriteLine($"Last Name :{LName1}");
            Console.WriteLine($"Wage :{wage1}");
            Console.WriteLine($"Logged Hours :{loggedHours1}");
            Console.WriteLine($"Net Salary :{netSalary}");

            //-------------------------------------------------------------
            //========= Second way   ==========
            //------------------------------------------------------------

            // Object (instance) Syntax
            // Declaration <Type> <ObjectName>
            // Assignment <ObjectName> = new <Type>();
            // Initialization <Type> <ObjectName> = new <Type>();


            //----- First Employee

            Console.WriteLine("\nFirst Employee");

            Employee[] emp = new Employee[2];

            Employee e1 = new Employee();
            Console.Write("First Name: ");
            e1.FName = Console.ReadLine();

            Console.Write("Last Name: ");
            e1.LName = Console.ReadLine();

            Console.Write("Wage: ");
            e1.Wage = Convert.ToDouble(Console.ReadLine());

            Console.Write("LoggedHours: ");
            e1.LoggedHours = Convert.ToDouble(Console.ReadLine());
            emp[0] = e1;

            //----- Second Employee

            Console.WriteLine("\nSecond Employee");

            Employee e2 = new Employee();
            Console.Write("First Name: ");
            e2.FName = Console.ReadLine();

            Console.Write("Last Name: ");
            e2.LName = Console.ReadLine();

            Console.Write("Wage: ");
            e2.Wage = Convert.ToDouble(Console.ReadLine());

            Console.Write("LoggedHours: ");
            e2.LoggedHours = Convert.ToDouble(Console.ReadLine());
            emp[1] = e2;

            Console.WriteLine($"-------------");
            foreach (Employee e in emp)
            {
                netSalary = e.Wage * e.LoggedHours - (e.Wage * e.LoggedHours * Employee.TAX);

                Console.WriteLine($"First Name :{e.FName}");
                Console.WriteLine($"Last Name :{e.LName}");
                Console.WriteLine($"Wage :{e.Wage}");
                Console.WriteLine($"Logged Hours :{e.LoggedHours}");
                Console.WriteLine($"Net Salary :{netSalary}");

                Console.WriteLine($"-------------");

            }
            Console.ReadKey();
        }
    }
}