namespace MyLibrary;

public class Keeper()
{   
    public event EventHandler? Feed;

    public void FeedCreatures()
    {
        if (Feed != null)
        {
            Feed(this, EventArgs.Empty);
        }
    }
}