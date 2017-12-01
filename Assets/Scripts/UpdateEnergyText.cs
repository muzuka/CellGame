using UnityEngine;
using UnityEngine.UI;

public class UpdateEnergyText : MonoBehaviour {

	PlayerController player;

	Text energyText;

	// Use this for initialization
	void Start () {
		player = FindObjectOfType<PlayerController>();
		energyText = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		energyText.text = "Energy = " + player.getEnergy();
	}
}
