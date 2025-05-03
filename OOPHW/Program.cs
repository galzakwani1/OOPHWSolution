namespace OOPHW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***This is the answer of question 1***");
            Rectangle rect = new Rectangle();
            Console.WriteLine("the area with no argument"+ rect.Area());
            Console.WriteLine("");
            Console.Write("Type the length:");
            int.TryParse(Console.ReadLine(), out int length);
            Console.Write("Type the width");
            int.TryParse(Console.ReadLine(), out int width);
            Console.WriteLine(rect.Area(length, width));
            Console.WriteLine("Giving the number of times in the program itself");
            Console.WriteLine(rect.Area(4,10));
            Console.WriteLine(" ");
            Console.WriteLine(" ");

            Console.WriteLine("***This is the answer of question 2***");
            Calculator cal = new Calculator();
            Console.WriteLine(cal.Add1(5, 6));
            Console.WriteLine(cal.Add2(9, 4, 2));
            Console.WriteLine(" ");
            Console.WriteLine(" ");

            Console.WriteLine("***This is the answer of question 3***");
            Person person = new Person("Jawaher", 25);
            Console.WriteLine("Getting the number of printing times from user");
            Console.Write("How many times do you want to print the details? ");
            int.TryParse(Console.ReadLine(), out int times);
            person.Print(times);
            Console.WriteLine("Giving the number of times in the program itself");
            person.Print(5);
            Console.WriteLine(" ");
            Console.WriteLine(" ");

            Console.WriteLine("***This is the answer of question 4***");
            Product product = new Product();
            Console.WriteLine("the TotalPrice is:" + product.TotalCost());
            Console.WriteLine("");
            Console.Write("Type the price:");
            double.TryParse(Console.ReadLine(), out double price);
            Console.Write("Type the quantity");
            double.TryParse(Console.ReadLine(), out double quantity);
            Console.WriteLine(product.TotalCost(price, quantity));
            Console.WriteLine("Giving the values of TotalPrice in the program itself");
            Console.WriteLine(product.TotalCost(4, 10));
            Console.WriteLine(" ");
            Console.WriteLine(" ");

            Console.WriteLine("***This is the answer of question 5***");
            Employee employee = new Employee("Jawaher", 25, 1700.00);
            Console.WriteLine("Getting the number of printing times from user");
            Console.Write("How many times do you want to print the details? ");
            int.TryParse(Console.ReadLine(), out int repeat);
            employee.Print(repeat);
            Console.WriteLine("Giving the number of times in the program itself");
            employee.Print(3);
            Console.WriteLine(" ");
        }
    }
}
