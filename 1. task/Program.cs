// See https://aka.ms/new-console-template for more information
Console.WriteLine("Name:");
String firstName = Console.ReadLine();
Console.WriteLine("Last Name:");
String lastName = Console.ReadLine();
Console.WriteLine("Age:");
int age = Convert.ToInt32(Console.ReadLine());
if (age < 21)
{
    Console.WriteLine("You're not allowed to use the app");
}

else
{
    Console.WriteLine("Wellcome");
}