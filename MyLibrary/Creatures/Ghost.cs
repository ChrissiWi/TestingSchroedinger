namespace MyLibrary;

public class Ghost(string name, int energy) : Creature(name, energy)
{
    public virtual string Haunt()
    {
        return $"{this.Name} says: 'Buh'.";
    }
}