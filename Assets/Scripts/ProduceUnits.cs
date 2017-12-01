using UnityEngine;

public class ProduceUnits : MonoBehaviour {

	public GameObject unitBlueprint;
	public float forceMultiple;

	GameObject newUnit;
	PlayerController player;

	void Start ()
	{
		player = FindObjectOfType<PlayerController>();
	}

	void Update ()
	{
		//Produces units over time.
		if(Input.GetMouseButtonUp(0))
		{
			if(player.canSpawn())
			{
				newUnit = Instantiate(unitBlueprint);
				Vector3 mousePos = Input.mousePosition;
				Vector3 nucleusPos = Camera.main.WorldToScreenPoint(gameObject.transform.position);

				Vector3 finalForce = Vector3.Normalize(new Vector3(mousePos.x - nucleusPos.x, mousePos.y - nucleusPos.y, 0.0f)) * forceMultiple;

				newUnit.GetComponent<Rigidbody2D>().velocity = finalForce;

				player.spawnUnit();
			}
		}
	}
}
