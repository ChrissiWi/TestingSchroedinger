namespace MyLibrary;

public class Elf(string name, int energy) : LivingCreature (name, energy)
{
  public new void Eat(object sender, EventArgs e)
    {
        Console.WriteLine("Thanks, but I already ate yesterday");
    }
}