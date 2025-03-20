namespace MyLibrary;

public class Bumbelbee(string name, int energy, DateTime birthday, ILogger? logger = null) : LivingCreature(name, energy, birthday, logger), ICanFly
{
    public void Fly()
    {
        throw new NotImplementedException();
    }
}