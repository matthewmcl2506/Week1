using System.IO.Pipes;
using System.Linq.Expressions;

class Week1Practical
{
    public static void Main(string[] args) {
        string name = getName();
        int age = getAge();
        if (age < 13)
        {
            Console.WriteLine("You are {0} years old, therefore you are a child.", age);
        }
        else if (age >= 13 && age <=19)
        {
            Console.WriteLine("You are {0} years old, therefore you are a teenager.", age);
        }
        else
        {
            Console.WriteLine("You are {0} years old, therefore you are an adult.", age);
        }
        int year = System.DateTime.Now.Year;
        bool leapYear = false; ;
        if (((year - age) % 4 == 0) && ((year - age) % 100 != 0))
        {
            Console.WriteLine("You were born on a leap year");
        }
        else
        {
            Console.WriteLine("You were not born on a leap year");
        }
        if ((year - age) % 2 == 0)
        {
            Console.WriteLine("You were born on a year that is an even number");
        }
        else
        {
            Console.WriteLine("You were born on a year that is an odd number");
        }


    }

    static string getName()
    {
        string name;

        while (true)
        {
            Console.WriteLine("Please enter your name below:\n");
            name = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(name) &&  name.All(c => char.IsLetter(c) || c == ' '))
            {
                return name;
            }

            Console.WriteLine("Invalid input, please try again:\n");
        }
    }
    static int getAge()
    {

        while (true)
        {
            Console.WriteLine("Please enter your age below:\n");
            String age = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(age) && (int.TryParse(age, out int ageConvert) && ageConvert > 0 && ageConvert < 110))
            {
                return ageConvert;
            }

                Console.WriteLine("Invalid input, please try again:\n");
        }
    }

}