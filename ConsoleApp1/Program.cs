using System.IO.Pipes;
using System.Linq.Expressions;

class Week1Practical
{
    public static void Main(string[] args) {
        string name = getName();
        int age = getAge();
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

            if (!string.IsNullOrWhiteSpace(age) && (int.TryParse(age, out int ageConvert) && ageConvert > 0))
            {
                return ageConvert;
            }

                Console.WriteLine("Invalid input, please try again:\n");
        }
    }

}