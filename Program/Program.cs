using MyLibrary;


ILogger logger = new FileLogger(Config.LogFile);
Keeper keeper = new Keeper();

List<Creature> creatures = [
    new Elf("Legolas", 12),
    new Dwarf("Gimli", 8),
    new Bumbelbee("Maja", 2),
    new Ghost("Edgar", 4),
    new SlimeGhost("Allen", 5)
    ];

((LivingCreature)creatures[0]).FeedMe(keeper);
keeper.FeedCreatures();
keeper.FeedCreatures();

Bumbelbee bee = new Bumbelbee("Maja", 2);
try
{
    bee.Fly();
}
catch (NotImplementedException ex)
{
    logger.Log(LogLevel.Error, ex.Message + ex.StackTrace);
}

string namesOfLivingCreaturesWithEnergyAtLeast5 =  creatures.GetNamesOfLivingWithEnergyAtLeast(5);
Console.WriteLine(namesOfLivingCreaturesWithEnergyAtLeast5);

(List<Creature> resultLower, List<Creature> resultHigher) = creatures.SplitByEnergy(5);
Console.WriteLine($"{resultLower.Count} creatures have energy below 5");
Console.WriteLine($"{resultHigher.Count} creatures have energy 5 or higher");