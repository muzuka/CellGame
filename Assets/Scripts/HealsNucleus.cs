using UnityEngine;

public class HealsNucleus : MonoBehaviour {

	public Health nucleusHealth;

	float timeConsumed;
	const float timeToHeal = 2.0f;

	void Start () {
		timeConsumed = 0.0f;
	}

	void Update () {
		timeConsumed += Time.deltaTime;
		if(timeConsumed >= timeToHeal)
		{
			if(!nucleusHealth.full())
				nucleusHealth.heal(1);

			timeConsumed = 0.0f;
		}
	}
}
