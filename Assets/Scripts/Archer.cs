using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Inherited the base class
public class Archer : Classless
{
    void start()
    {
        // Overriding the stats according to the class and what they do
        var classless = new Classless(className: "Archer", health: 80.0f, power: 30, agility: 5);
        Debug.Log(classless.GetProperties());
    }
}
