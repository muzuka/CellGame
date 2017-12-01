using UnityEngine;

public class PlayerController : MonoBehaviour, IPlayerMessageTarget {

	int energy;
	int maxEnergy;

	void Start () {
		energy = 0;
		maxEnergy = 0;
	}
	
	public void addEnergy (int amount)
	{
		if(energy <= maxEnergy)
			energy += amount;
	}

	public void spawnUnit ()
	{
		energy--;
	}

	public int getEnergy ()
	{
		return energy;
	}

	public bool canSpawn ()
	{
		return energy > 0;
	}

	public void vacuoleDestroyed ()
	{
		maxEnergy -= 20;
	}

	public void vacuoleCreated ()
	{
		maxEnergy += 20;
	}
}
