using UnityEngine;

public class Health : MonoBehaviour {

	public int maxHealth;

	public int health {
		get { return health; }
		set { health = value; }
	}

	void Start ()
	{
		health = maxHealth;
	}

	void Update () 
	{
		if(health <= 0)
			Destroy(gameObject);
	}

	public void heal (int amount)
	{
		if(health + amount > maxHealth)
			health = maxHealth;
		else
			health += amount;
	}

	public void damage (int amount)
	{
		health -= amount;
	}

	public bool full ()
	{
		return maxHealth == health;
	}
}
