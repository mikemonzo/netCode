int heroeHealth = 10;
int monsterHealth = 10;

Random random = new Random();
do{

    int heroeAttack = random.Next(1, 11);
    monsterHealth -= heroeAttack;
    Console.WriteLine($"Heroe attacks monster with {heroeAttack} damage. Monster health is {monsterHealth}");

    if (monsterHealth > 0){
        int monsterAttack = random.Next(1, 11);
        heroeHealth -= monsterAttack;
        Console.WriteLine($"Monster attacks heroe with {monsterAttack} damage. Heroe health is {heroeHealth}");
    }

}while(heroeHealth > 0 && monsterHealth > 0);

Console.WriteLine(heroeHealth <= 0 ? "Monster wins!" : "Heroe wins!");
