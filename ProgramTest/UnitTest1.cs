using MyLibrary;
namespace ProgramTest;

[TestClass]
public class UnitTest1
{
    private Elf? _elf;

    [TestInitialize]
    public void Init()
    {
        _elf = new Elf("Legolas", 12);
    }

    [TestMethod]
    public void Test_Play() 
    {
        _elf!.Play();
        Assert.AreEqual("Legolas is playing.", _elf.Play());
    }

    [TestMethod]
    [DynamicData(nameof(SplitByEnergyData), DynamicDataSourceType.Method)]
    public void Test_SplitByEnergy(List<Creature> creatures, int expectedLower)
    {
        int expectedUpper = creatures.Count() - expectedLower;

        (List<Creature> resultLower, List<Creature> resultHigher) = creatures.SplitByEnergy(5);

        Assert.AreEqual(expectedLower, resultLower.Count());
        Assert.AreEqual(expectedUpper, resultHigher.Count());
    }

    public static List<object[]> SplitByEnergyData()
    {
        return new List<object[]>{
            new object[] {new List<Creature>{new Elf("Legolas", 12)}, 0},
            new object[] {new List<Creature>{new Bumbelbee("Maja", 2),
                                             new Ghost("Edgar", 0),
                                             new SlimeGhost("Allen", -1)}, 3}
        };
    }
}