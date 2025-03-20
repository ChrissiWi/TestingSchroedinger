namespace MyLibrary;

public abstract class LivingCreature : Creature
{
    private Behavior behavior;
    private readonly ILogger? logger;
    public DateTime Birthday { get; init; }
    public int Age => (int)((DateTime.Now - Birthday).TotalDays / 365.25);

    public LivingCreature(string name, int energy, DateTime birthday, ILogger? logger = null) : base(name, energy)
    {
        if (birthday > DateTime.Now)
            throw new ArgumentException("Birthday cannot be in the future", nameof(birthday));
            
        this.logger = logger;
        behavior = new Behavior();
        Birthday = birthday;
        LogInfo($"Created {GetType().Name} named {Name}, Energy: {Energy}, Birthday: {Birthday:d}");
    }

    public virtual void Eat(object? sender, EventArgs? e)
    {
        if (behavior.IsHungry)
        {
            LogInfo($"{Name} is eating. Energy before: {Energy}");
            behavior.HasEaten();
            Energy += 1;
            LogInfo($"{Name} finished eating. Energy after: {Energy}");
        }
        else
        {
            LogInfo($"{Name} is not hungry. Current energy: {Energy}");
        }
    }

    public virtual string Play()
    {
        string result = "no, thanks, not in a playing mood";
        LogInfo($"{Name} was asked to play. IsPlayful: {behavior.IsPlayfull}, Energy: {Energy}");
        
        if (behavior.IsPlayfull)
        {
            result = $"{Name} is playing.";
            behavior.HasPlayed();
            Energy += 1;
            LogInfo($"{Name} played. New energy: {Energy}");
        }

        return result;
    }

    private void LogInfo(string message)
    {
        logger?.Log(LogLevel.Info, $"[{GetType().Name}] {message}");
    }

    public override string ToString()
    {
        return $"{base.ToString()} I was born on {Birthday:d}.";
    }

    public void FeedMe(Keeper keeper) => keeper.Feed += Eat;
    public void DontFeedMe(Keeper keeper) => keeper.Feed -= Eat;
}