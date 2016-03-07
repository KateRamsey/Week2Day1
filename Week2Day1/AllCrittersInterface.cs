using System;

public interface IAllCritters
{
    bool IsASleep();
    void DisplayName();
    void DisplayGreeting();

    string Name { get; set; }
}
