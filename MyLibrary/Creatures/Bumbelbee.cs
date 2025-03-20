namespace MyLibrary;

public class Bumbelbee(string name, int energy, DateTime birthday) : LivingCreature(name, energy, birthday), ICanFly
{
    public void Fly()
    {
        throw new NotImplementedException();
    }
}