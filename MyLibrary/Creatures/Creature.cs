namespace MyLibrary;

public abstract class Creature (string name, int energy) {
    public string Name { get; init; } = name;
    public int Energy { get; set; } = energy;

    public override string ToString() =>  $"I am {Name}.";
}