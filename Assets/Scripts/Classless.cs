using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// A base class that applies to all classes
public class Classless : MonoBehaviour
{
    protected string _name;
    protected float _basehealth;
    protected float _power;
    protected int _vitality;
    protected int _agility;
    protected int _strength;
    protected int _endurance;

    // Default stats
    public Classless()
    {
        _name ="";
        _basehealth = 20.0f;
        _power = 5.0f;
        _agility= 1;
        _strength = 1;
        _endurance = 1;
        _vitality = 1;

    }

    // 3 public properties on the base class with set computations
    public float MaxHealth => _basehealth * (_vitality * 3);
    public float RangedAttack => _power * (_agility * 2);
    public float MeleeDamage => _power * (_strength * 2);
    public float BonusHealth => MaxHealth + (_endurance * 10);

    // 3 private properties derive their value by initializing in the constructor
    // Overloading the default stats with a new one
    public Classless(string className = "Classless", float health = 50.0f, float power = 10.0f, int agility = 0, int strength = 0, int endurance = 0 , int vitality = 1)
    {
        _name = className;
        _basehealth = health;
        _power = power;
        _agility = agility;
        _strength = strength;
        _endurance = endurance;
        _vitality = vitality;
    }

    public string GetProperties()
    {
        var properties = 
            $"{nameof(_name)}:{_name}, {nameof(_basehealth)}:{_basehealth}, {nameof(_power)}:{_power}, {nameof(_agility)}:{_agility}, {nameof(_strength)}:{_strength}, {nameof(_endurance)}:{_endurance}, {nameof(_vitality)}:{_vitality}";

        return properties;
    }
}