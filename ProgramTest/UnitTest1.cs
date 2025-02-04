using MyLibrary;
namespace ProgramTest;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    [DynamicData(nameof(UnitTestData), DynamicDataSourceType.Method)]
    public void Test_SplitByEnergy(List<Creature> creatures, int expectedLower)
    {
        int expectedUpper = creatures.Count() - expectedLower;

        (List<Creature> resultLower, List<Creature> resultHigher) = creatures.SplitByEnergy(5);

        Assert.AreEqual(expectedLower, resultLower.Count());
        Assert.AreEqual(expectedUpper, resultHigher.Count());
    }

    public static List<object[]> UnitTestData()
    {
        return new List<object[]>{
            new object[] {new List<Creature>{new Elf("Legolas", 12)}, 0},
            new object[] {new List<Creature>{new Bumbelbee("Maja", 2),
                                             new Ghost("Edgar", 0),
                                             new SlimeGhost("Allen", -1)}, 3}
        };
    }
}