// See https://aka.ms/new-console-template for more information
Random random = new Random();

int roll1 = random.Next(1, 7);
int roll2 = random.Next(1, 7);
int roll3 = random.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Random roll: {roll1} + {roll2} + {roll3} = {total}");

if (roll1==roll2 || roll2==roll3 || roll1==roll3)
{
    if (roll1==roll2 && roll2==roll3)
    {
        Console.WriteLine("You rolled triples! +6 bonus to total!");
        total += 6;
    }else{
        Console.WriteLine("You rolled doubles! +2 bonus to total!");
        total += 2;
    }
    Console.WriteLine($"Your total including the bonus is {total}");
}

if (total >= 16)
{
    Console.WriteLine("You win a new car!");
}else if (total >= 10)
{
    Console.WriteLine("You win a new laptop!");
}else if (total == 7)
{
    Console.WriteLine("You win a trip for two!");
}
else{
    Console.WriteLine("You win a kitten!");
}