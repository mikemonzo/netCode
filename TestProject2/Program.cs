// See https://aka.ms/new-console-template for more information
Random random = new Random();

int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;
string message = "";

if (daysUntilExpiration <1)
{
    message = "Your subscription has expired.";
}
else if (daysUntilExpiration == 1)
{
    discountPercentage = 20;
    message = "Your subscription expires in " + daysUntilExpiration + " days!";
}
else if (daysUntilExpiration <= 5){
    discountPercentage = 10;
    message = "Your subscription expires in " + daysUntilExpiration + " days!";
}
else if (daysUntilExpiration <= 10)
{
    message = "Your subscription will expire soon. Renew now!";
}
else{
    return;
}
Console.WriteLine(message);
if (discountPercentage > 0)
{
    Console.WriteLine("Renew now and save " + discountPercentage + "%!");
}   

