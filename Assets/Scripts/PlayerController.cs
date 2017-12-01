using UnityEngine;

public class PlayerController : MonoBehaviour, IPlayerMessageTarget {

	int energy = 0;
	int maxEnergy = 0;
	
    void Start ()
    {
        VacuoleController[] vacuoles = FindObjectsOfType<VacuoleController>();
        maxEnergy = vacuoles.Length * 20;
    }

	public void addEnergy (int amount)
	{
        if ((energy + amount) <= maxEnergy)
            energy += amount;
        else
            energy = maxEnergy;
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
