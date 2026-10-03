using lab_2;

Archer firstArcher = new Archer(1, "Арчер1", 10, 20, 100);

firstArcher.ReceiveDamage(30);

Console.WriteLine(firstArcher.GetHp());