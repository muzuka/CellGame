using UnityEngine;

public class CirclesNucleus : MonoBehaviour {

	public GameObject nucleus;
	public float radius;

	float x;
	float y;
	float angle;

	void Start () 
	{
		angle = 0.0f;
		updatePosition();
	}

	void Update () 
	{
		updatePosition();
	}

	void updatePosition ()
	{
		angle += Time.deltaTime;
		x = radius * Mathf.Cos(angle) + nucleus.transform.position.x;
		y = radius * Mathf.Sin(angle) + nucleus.transform.position.y;

		transform.position = new Vector3(x, y, 0.0f);
	}
}
