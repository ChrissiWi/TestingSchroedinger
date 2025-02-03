namespace MyLibrary;

public class Behavior
{

    [Flags]
    private enum Emotions {
        Happy =     0b_0000001, //2^0
        Sad =       0b_0000010, //2^1
        Excited =   0b_0000100, //2^2
        Bored =     0b_0001000, //2^3
        InLove =    0b_0010000, //2^4
        Hungry =    0b_0100000, //2^5
        Curious =   0b_1000000, //2^6
        Tired =     0b_10000000 //2^7
    }

    private Emotions emotions;

public Behavior()   
{
    emotions = Emotions.Curious | Emotions.Hungry;
}
    public bool IsHungry =>  emotions.HasFlag(Emotions.Hungry);

    public bool IsPlayfull => emotions.HasFlag(Emotions.Curious) 
                            | emotions.HasFlag(Emotions.Excited) 
                            | emotions.HasFlag(Emotions.Happy);

    public void HasEaten()
    {
        emotions &= ~Emotions.Hungry;
        emotions |= Emotions.Tired;
    }

    public void HasPlayed()
    {
        emotions |= Emotions.Hungry;
        emotions |= Emotions.Tired;
    }

}
