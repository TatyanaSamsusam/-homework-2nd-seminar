int number = new int();
System.Console.WriteLine("\ninput a number: ");
number = Convert.ToInt32(Console.ReadLine());

int result = number / 10;

if (result < 10)
{
    Console.WriteLine($"there is no third digit");
}

if (result > 10)
{
    string str = number.ToString();
    Console.WriteLine($"third digit is " + str[2]);
}


