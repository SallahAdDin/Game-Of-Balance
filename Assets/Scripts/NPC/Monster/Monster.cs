using UnityEngine;
using System.Collections;

public abstract class Monster : LivingEntity
{	private float strength;
	public float Strength
	{set 
		{	if(value>0)
			{
				strength = value
			}
		
			else 
			{
			strength = 0;
			}
		}
	}
	public float[] specify_dmg= new float [] {1,1,1,1}; //silver, metall, fire, aard
    public abstract void Irden();

    

    
}

public class Animal : Monster
{
    public override void Irden()
    { }
}

public class Vampir : Monster
{
    public override void Irden()
    { }
}

public class Bestia: Monster
{
    public override void Irden()
    { }
}

public class Hybrid : Monster
{
    public override void Irden()
    { }
}

public class Dragon : Monster
{
    public override void Irden()
    { }
}

public class Speareats : Monster
{
    public override void Irden()
    { }
}

public class Elementals : Monster
{
    public override void Irden()
    { }
}

public class Ogr : Monster
{
    public override void Irden()
    { }
}

public class Relict : Monster
{
    public override void Irden()
    { }
}

public class Fleshheater : Monster
{
    public override void Irden()
    { }
}