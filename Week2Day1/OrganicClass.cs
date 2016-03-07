using System;

public abstract class Organic
{
	public bool ASleep { get; set;}

    public bool IsASleep()
    {
        return ASleep;
    }

    public void GoToSleep()
    {
        this.ASleep = true;
    }

    public void WakeUp()
    {
        this.ASleep = false;
    }

    public void Eat(string food)
    {
        Console.WriteLine($"Yum, I ate {food}");
    }


}
