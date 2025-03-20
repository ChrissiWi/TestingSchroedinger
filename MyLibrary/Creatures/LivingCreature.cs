namespace MyLibrary;

public abstract class LivingCreature : Creature
{
    private Behavior behavior;
    public DateTime Birthday { get; init; }
    public int Age => (int)((DateTime.Now - Birthday).TotalDays / 365.25);

    public LivingCreature(string name, int energy, DateTime birthday) : base(name, energy)
    {
        if (birthday > DateTime.Now)
            throw new ArgumentException("Birthday cannot be in the future", nameof(birthday));
            
        behavior = new Behavior();
        Birthday = birthday;
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
        return $"{base.ToString()} I was born on {Birthday:d}.";
    }

    public void FeedMe(Keeper keeper) => keeper.Feed += Eat;
    public void DontFeedMe(Keeper keeper) => keeper.Feed -= Eat;
}