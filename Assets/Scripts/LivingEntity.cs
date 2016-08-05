using UnityEngine;
using System.Collections;

[System.Serializable]
public class LivingEntity : Entity
{	

    [SerializeField]
    private float maxHP;
    [SerializeField]
    private float currentHP;
    public float CurrentHP
    { set
        { 
            if ((value)<=0)
                {
                currentHP = 0;
                }
            else
                currentHP = value;
        }

        get
        {
            return currentHP;
        }
    }
    public float MaxHP
    {
        set
        {
            if (value<0)
            {
                maxHP = 0;
            }
            else
                maxHP = value;
        }
        get
            {
                return maxHP;
            }
    }
    [SerializeField]
    private float currentEnergy;
    public float CurrentEnergy
    {
        set
        {
            if (value < 0)
            {
                currentEnergy = 0;
            }
            else
                currentEnergy = value;
        }
        get
        {
            return currentEnergy;
        }
    }
    [SerializeField]
    private float  maxEnergy;
    public float MaxEnergy
    {
        set
        {
            if (value < 0)
            {
                maxEnergy = 0;
            }
            else
                maxEnergy = value;
        }
        get
        {
            return maxEnergy;
        }
    }
    private float speed;
	public float Speed
	{
		set
		{
				speed = value;
		}
		get
		{
			return speed;
		}
	}
    Effect[] effects;
    Vector2 coords;

    
    public void Attack(LivingEntity enemy) //calculated damag from attack
    {
        float damage = 0;
        enemy.Attacked(damage);
   
    }

    public void Attacked(float damage) //really events attack
    {
        currentHP = currentHP - damage;
    }
}