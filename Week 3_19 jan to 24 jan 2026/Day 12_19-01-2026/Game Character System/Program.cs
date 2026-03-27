namespace Game_Character_System
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Choose Character: 1-Warrior  2-Mage  3-Archer");
            int choice = int.Parse(Console.ReadLine());

            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Character player = choice switch
            {
                1 => new Warrior(name),
                2 => new Mage(name),
                _ => new Archer(name)
            };

            Character enemy = new Warrior("Enemy");

            Console.WriteLine("\nBattle Start!");
            player.Attack(enemy);
            enemy.Attack(player);

            Console.WriteLine("\nLevel Up?");
            player.LevelUp();

            Console.WriteLine("\nFinal Status:");
            player.Display();
            enemy.Display();
        }
    }
}
