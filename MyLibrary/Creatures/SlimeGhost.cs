using System.Text;

namespace MyLibrary;
public class SlimeGhost(string name, int energy) : Ghost(name, energy)
{
    public override string Haunt()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine(base.Haunt());
        sb.AppendLine(this.Slime());
        return sb.ToString();
    }

    private string Slime()
    {
        return $"{this.Name} leaves a trace of slime. ";
    }
}