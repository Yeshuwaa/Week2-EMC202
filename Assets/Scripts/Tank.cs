using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Inherited the base class
public class Tank : Classless
{
    void start()
    {
        // Overriding the stats according to the class and what they do
        var classless = new Classless(className: "Tank", health: 150.0f, power: 15, endurance: 5);
        Debug.Log(classless.GetProperties());
    }
}
