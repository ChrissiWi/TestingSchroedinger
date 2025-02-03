using System.Text;

namespace MyLibrary
{
    public static class CreaturesExtensions
    {
        public static string GetNamesOfLivingWithEnergyAtLeast(this List<Creature> creatures, int energy)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Living creatures with energy >= {energy}:");
            List<LivingCreature> livingCreaturesWithHighEnergy =
                [.. creatures.Where(x => x is LivingCreature livingCreature && livingCreature.Energy >= energy).Select(y => (LivingCreature)y)];

            foreach (LivingCreature creature in livingCreaturesWithHighEnergy)
            {
                stringBuilder.AppendLine($"{creature.Name}  {creature.Energy}");
            }
            return stringBuilder.ToString();
        }

        public static (List<Creature>, List<Creature>) SplitByEnergy(this List<Creature> creatures, int energy)
        {
            return ([.. creatures.Where(x => x.Energy < energy)], [.. creatures.Where(x => x.Energy >= energy)]);
        }
    }
}