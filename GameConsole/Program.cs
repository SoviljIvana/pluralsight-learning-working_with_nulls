// See https://aka.ms/new-console-template for more information
using GameConsole;

PlayerCharacter sarah = new PlayerCharacter(new DiamondSkinDefence())
{
    Name = "Sarah"
};

PlayerCharacter armit = new PlayerCharacter(new IronBonesDefence())
{
    Name = "Armit"
};

PlayerCharacter gentry = new PlayerCharacter(new NullDefence())
{
    Name = "Gentry"
};

sarah.Hit(10);
armit.Hit(10);
gentry.Hit(10);

Console.ReadLine();
//Console.WriteLine("Hello, World!");
//var player = new PlayerCharacter();
//player.Name = "  ";
//player.DaysSinceLastLogin = 42;

//PlayerDisplayer.Write(player);

