// See https://aka.ms/new-console-template for more information

// Random to heads or tails
Console.WriteLine($"{(new Random().Next(0, 2) == 0 ? "heads" : "tails")}");

string permission = "Admin|Manager";
int level = 55;
if (permission.Contains("Admin"))
    Console.WriteLine($"{(level > 50 ? "Welcome, Super Admin user." : "Welcome, Super Admin user.")}");
else if (permission.Contains("Manager"))
    Console.WriteLine($"{(level < 20 ? "Contact an Admin for access." : "You do not have sufficient privileges.")}");
else
    Console.WriteLine("You do not have sufficient privileges.");
