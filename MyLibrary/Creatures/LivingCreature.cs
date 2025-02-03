namespace MyLibrary;

public abstract class LivingCreature : Creature
{
    private Behavior behavior;

    public LivingCreature(string name, int energy) : base(name, energy)
    {
        behavior = new Behavior();
    }

    public virtual void Eat(object? sender, EventArgs? e)
    {
        if (behavior.IsHungry)
        {
            Console.WriteLine($"{Name} is eating.");
            behavior.HasEaten();
            Energy += 1;
        }
        else
        {
            Console.WriteLine($"{Name} is not hungry.");
        }
    }

    public virtual string Play()
    {
        string result =  "no, thanks, not in a playing mood";
        
        if (behavior.IsPlayfull)
        {
            result = $"{Name} is playing.";
            behavior.HasPlayed();
            Energy += 1;
        }

        return result;
    }

    public override string ToString()
    {
        return base.ToString();
    }

    public void FeedMe(Keeper keeper) => keeper.Feed += Eat;
    public void DontFeedMe(Keeper keeper) => keeper.Feed -= Eat;
}