/* string? readResult;

Console.WriteLine("Enter a string:");
do{
    readResult = Console.ReadLine();
}while(readResult == null); */

/* string? readResult;
bool validEntry = false;
Console.WriteLine("Enter a string containing at least three characters:");

do{
    readResult = Console.ReadLine();
    if (readResult?.Length >= 3)
    {
        validEntry = true;
    }
    else
    {
        Console.WriteLine("You must enter at least three characters!");
    }
}while(validEntry == false); */

/* string? readResult;
bool validNumber = false;
Console.WriteLine("Enter a number containing at least three characters:");

do{
    readResult = Console.ReadLine();
    if (readResult?.Length >= 3)
    {
        validNumber = int.TryParse(readResult, out int number);
    }
    else
    {
        Console.WriteLine("You must enter at least three numbers!");
    }
}while(validNumber == false);

Console.WriteLine("You have entered three numbers!"); */

string? readResult;
/* Console.WriteLine("Enter a number between 5 and 10:");
do{
    readResult = Console.ReadLine();
    if (readResult != null){
        int number = int.Parse(readResult);
        if (number >= 5 && number <= 10){
            Console.WriteLine("Valid number entered!");
            break;
        }
        else{
            Console.WriteLine("Invalid number entered!");
            Console.WriteLine("Enter a number between 5 and 10:");
        }
    }
}while(true);
Console.WriteLine("Your number is between 5 and 10!"); */

Console.WriteLine("Enter one rol name: Admin, Manager, User");
do{
    readResult = Console.ReadLine();
    if (readResult != null){
        readResult = readResult.Trim().ToLower();
        if (readResult == "admin" || readResult == "manager" || readResult == "user"){
            Console.WriteLine("Valid role entered!");
            break;
        }
        else{
            Console.WriteLine("Invalid role entered!");
            Console.WriteLine("Enter one rol name: Admin, Manager, User");
        }
    }
}while(true);
Console.WriteLine("Your role is valid!");