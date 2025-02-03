namespace MyLibrary;

public class Bumbelbee(string name, int energy) : LivingCreature(name, energy), ICanFly
{
    public void Fly()
    {
        throw new NotImplementedException();
    }
}