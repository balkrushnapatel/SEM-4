

namespace Lab_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Program 1

            //1.Write a program to print your name, address, contact number & city.

            //Console.WriteLine("Enter Your Name : ");
            //Console.ReadLine();
            //Console.WriteLine();
            //Console.WriteLine("Enter Your Address : ");
            //Console.ReadLine();
            //Console.WriteLine();
            //Console.WriteLine("Enter Your Contact Number : ");
            //Console.ReadLine();
            //Console.WriteLine();
            //Console.WriteLine("Enter Your City : ");
            //Console.ReadLine();
            //Console.WriteLine();

            //Program 2

            //2.Write a program to get two numbers from user and print those two numbers.

            //Console.WriteLine("Enter a number x :");
            //int x = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter a number y:");
            //int y = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine();
            //Console.WriteLine("The number x is :");
            //Console.WriteLine(x);
            //Console.WriteLine("The number y is :");
            //Console.WriteLine(y);

            //Program 3

            //3.Write program to prompt a user to input his/ her name and country name and 
            //  then output will be shown as given: Hello<yourname> from country <countryname>

            //Console.WriteLine("Enter Your Name :");
            //String name = Console.ReadLine();
            //Console.WriteLine("Enter Your Country :");
            //String country = Console.ReadLine();

            //Console.WriteLine("Hello "+name+" from country "+country);

            //Program 4

            //4.Write a program to calculate the size of the area in square - feet based on 
            //  Specified length and width.

            //Console.WriteLine("Enter Length in Feet :");
            //double Length = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Enter Width in Feet :");
            //double Width = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine();

            //double Area = Length * Width;
            //Console.WriteLine("The Size Of The Area is : " +Area+ " sq.ft");

            //Program 5

            //5.Write a program to calculate area of Square, Rectangle and Circle.

            //Console.WriteLine("Enter 1 For Square .");
            //Console.WriteLine("Enter 2 For Rectangle .");
            //Console.WriteLine("Enter 3 For Circle .");
            //int x = Convert.ToInt32(Console.ReadLine());

            //if (x == 1)
            //{
            //    Console.WriteLine("Enter the value of Length of Square :");
            //    double length = Convert.ToDouble(Console.ReadLine());

            //    double area = length * length;

            //    Console.WriteLine("The area of the Square is : " + area + " sq.");
            //}

            //else if (x == 2)
            //{
            //    Console.WriteLine("Enter the value of Length of Rectangle :");
            //    double length = Convert.ToDouble(Console.ReadLine());

            //    Console.WriteLine("Enter the value of Breadth of Rectangle :");
            //    double breadth = Convert.ToDouble(Console.ReadLine());

            //    double area = length * breadth;

            //    Console.WriteLine("The area of the Rectangle is : " + area + " sq.");
            //}

            //else if (x == 3)
            //{
            //    Console.WriteLine("Enter the value of Radius of Circle :");
            //    double radius = Convert.ToDouble(Console.ReadLine());

            //    double area = 3.14*radius*radius;

            //    Console.WriteLine("The area of the Circle is : " + area + " sq.");
            //}

            //else
            //{
            //    Console.WriteLine("Enter a Valid Selection .");
            //}

            //Program 6

            //6. Write a program to calculate Celsius to Fahrenheit and vice-versa using function.

            //Console.WriteLine("1 = your Temprature is in Celsius");
            //Console.WriteLine("2 = your Temprature is in Fahrenheit");

            //int x = Convert.ToInt32(Console.ReadLine());

            //if (x == 1)
            //{
            //    Console.Write("Enter Celsius : ");
            //    double c = Convert.ToDouble(Console.ReadLine());
            //    double f = Ferenhit(c);

            //    Console.WriteLine(f + " F");
            //}
            //else if (x == 2)
            //{
            //    Console.Write("Enter  Fahrenheit: ");
            //    double f = Convert.ToDouble(Console.ReadLine());
            //    double c = Celsius(f);

            //    Console.WriteLine(c + " C");

            //}


            //}

            //Program 7
            //7.Write a program to find out Simple Interest using function. (I = PRN / 100)

        public static double Celsius(double f)
        {
            return ((f - 32) * 5 / 9);
        }

        public static double Ferenhit(double c)
        {
            return ((c * 9) / 5) + 32;
        }

    }
}