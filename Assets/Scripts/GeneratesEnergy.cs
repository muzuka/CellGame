using UnityEngine;

public class GeneratesEnergy : MonoBehaviour {

	public int energyProduction;
	public float timeToEnergy;

	PlayerController player;

	Timer energyTimer;

	void Start ()
	{
		energyTimer = new Timer(timeToEnergy);
		player = FindObjectOfType<PlayerController>();
	}

	void Update () {
		energyTimer.update(addEnergy);
	}

	void addEnergy ()
	{
		player.addEnergy(energyProduction);
	}
}
