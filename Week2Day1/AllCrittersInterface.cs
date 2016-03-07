using System;

public interface ICritters
{
    bool IsASleep();
    void DisplayName();
    void DisplayGreeting();

    string Name { get; set; }
}
