Console.WriteLine("Enter username: ");
string username = Console.ReadLine();

if(username.ToLower() == "masha")
{
    Console.WriteLine("Hooray! It's Masha!");
}
else
{
    Console.Write("Hi, ");
    Console.WriteLine(username + ".");
}

