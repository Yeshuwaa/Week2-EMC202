using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Inherited the base class
public class Warrior : Classless
{
    void start()
    {
        // Overriding the stats according to the class and what they do
        var classless = new Classless(className: "Warrior", health: 100.0f, power: 20, strength: 5);
        Debug.Log(classless.GetProperties());
    }
}
