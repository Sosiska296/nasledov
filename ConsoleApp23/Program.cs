blitz three = new blitz();
blitz four = new Loona();
three.dad();
four.dad();
class blitz
{
    public virtual void dad()
    {
        Console.WriteLine("da");
    }
}
class Loona : blitz
{
    public override void dad()
    {
        Console.WriteLine("po document");
    }
}