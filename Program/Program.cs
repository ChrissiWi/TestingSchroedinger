using MyLibrary;

ILogger logger = new FileLogger(Config.LogFile);
Keeper keeper = new Keeper();

// Create creatures with logger for debugging
List<Creature> creatures = [
    new Elf("Legolas", 12, new DateTime(90, 1, 1), logger),      // Born in Third Age 90
    new Dwarf("Gimli", 8, new DateTime(1884, 7, 15), logger),    // Born in Third Age 2879
    new Bumbelbee("Maja", 2, DateTime.Now.AddYears(-1), logger), // Born 1 year ago
    new Ghost("Edgar", 4),
    new SlimeGhost("Allen", 5)
    ];

try
{
    // Test feeding
    logger.Log(LogLevel.Info, "=== Starting feeding test ===");
    ((LivingCreature)creatures[0]).FeedMe(keeper);
    keeper.FeedCreatures();
    keeper.FeedCreatures();

    // Test flying
    logger.Log(LogLevel.Info, "=== Starting flying test ===");
    Bumbelbee bee = new Bumbelbee("Maja", 2, DateTime.Now.AddYears(-1), logger);
    bee.Fly();

    // Test energy filtering
    logger.Log(LogLevel.Info, "=== Starting energy filtering test ===");
    string namesOfLivingCreaturesWithEnergyAtLeast5 = creatures.GetNamesOfLivingWithEnergyAtLeast(5);
    Console.WriteLine(namesOfLivingCreaturesWithEnergyAtLeast5);

    (List<Creature> resultLower, List<Creature> resultHigher) = creatures.SplitByEnergy(5);
    Console.WriteLine($"{resultLower.Count} creatures have energy below 5");
    Console.WriteLine($"{resultHigher.Count} creatures have energy 5 or higher");
}
catch (Exception ex)
{
    logger.Log(LogLevel.Error, $"An error occurred: {ex.Message}\nStack trace: {ex.StackTrace}");
    throw; // Re-throw to preserve the stack trace
}