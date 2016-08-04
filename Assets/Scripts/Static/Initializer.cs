using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Initializer : MonoBehaviour {

	void Start () {
	
	}
}
[System.Serializable]
public static class Globals
{
    public static class Players
    {

    }
}
[System.Serializable]
public class Entity : MonoBehaviour
{
    //public string name;
    public string description;
}

[System.Serializable]
public class School:Entity
{
    
}
[System.Serializable]
public abstract class Sign:Entity
{
    public float energyCost;
    public int level;
}
[System.Serializable]
public abstract class CombatSign:Sign
{
    public float damage;
    public float range;
    public int targets;
}
[System.Serializable]
public abstract class TemporarySign : Sign
{
    public float duration;
    public delegate void effect();
}
[System.Serializable]
public class Quen : TemporarySign
{
    public float power;

  
}

[System.Serializable]
public class Axij : TemporarySign
{
    public int targets;

}
[System.Serializable]
public class Igni : CombatSign
{
    public Effect fire;

}
[System.Serializable]
public class Aard : TemporarySign
{
    public float range;
    public float stanChance;

}
[System.Serializable]
public class Effect:Entity
{

}
[System.Serializable]
public class Buf : Effect
{

}
[System.Serializable]
public class Debuf : Effect
{

}
[System.Serializable]
public class Poison : Effect
{

}
[System.Serializable]
public class Item : Entity
{
    float price;
}
[System.Serializable]
public class Weapon: Item
{
    public float minDamage, maxDamage;
    public float durability;
    public float level;
    public Bonus[] bonuses;
}
[System.Serializable]
public class Bonus:Entity
{

}
[System.Serializable]
public class MeleeWeapon:Weapon
{
    public float blockPower;
    public float weight;
}
[System.Serializable]
public class RangeWeapon : Weapon
{
    public float range;
}
[System.Serializable]
public class Human : LivingEntity
{
    public List<Item> inventory;
    public string sex;
}
[System.Serializable]
public class Witcher : Human
{
    public School school;
    Quen quen = new Quen();
    Axij axij = new Axij();
    Igni igni = new Igni();
    Aard aard = new Aard();
    Irden irden = new Irden();
    
}
[System.Serializable]
public class SilverWeapon: MeleeWeapon
{

}

[System.Serializable]
public class SteelWeapon : MeleeWeapon
{

}
[System.Serializable]
public class Potion : Item
{
    public Effect effect;
    public Debuf toxic;
}