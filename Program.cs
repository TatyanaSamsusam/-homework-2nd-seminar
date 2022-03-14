int number = new int();
System.Console.WriteLine("\ninput a number from 100 till 999: ");
number = Convert.ToInt32(Console.ReadLine());

number = number / 10;
int result = number % 10;

Console.WriteLine($"second didgit is {result}");
