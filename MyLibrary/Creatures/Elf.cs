namespace MyLibrary;

public class Elf(string name, int energy, DateTime birthday) : LivingCreature(name, energy, birthday)
{
  public new void Eat(object sender, EventArgs e)
    {
        Console.WriteLine("Thanks, but I already ate yesterday");
    }
}