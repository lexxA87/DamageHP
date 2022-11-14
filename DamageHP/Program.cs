﻿using DamageHP;

SwordDamage swordDamage = new();

Random random = new();

while (true)
{
    Console.Write("0 for no magic/flaming, 1 for magic, 2 for flaming, 3 for both, anything else to quit: ");
    string? key = Console.ReadLine();

    int roll1 = random.Next(1, 7);
    int roll2 = random.Next(1, 7);
    int roll3 = random.Next(1, 7);
    int rollSum = roll1 + roll2 + roll3;
    swordDamage.Roll = rollSum;

    if (key == "0")
    {
        swordDamage.CalculateDamage();
    }
    else if (key == "1")
    {
        swordDamage.SetMagic(true);
    }
    else if (key == "2")
    {
        swordDamage.SetFlaming(true);
    }
    else if (key == "3")
    {
        swordDamage.SetMagic(true);
        swordDamage.SetFlaming(true);
    }
    else return;

    Console.WriteLine("Rolled " + swordDamage.Roll + " for " + swordDamage.Damage + " HP");
    Console.Write('\n');
}