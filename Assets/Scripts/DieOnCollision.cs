using UnityEngine;

public class DieOnCollision : MonoBehaviour {

	void OnCollisionEnter2D (Collision2D other)
	{
		Debug.Log("Collision!");

		if(gameObject.tag == "Unit")
		{
			if(other.collider.tag == "Virus")
				Destroy(gameObject);
		}
		else if(gameObject.tag == "Virus")
		{
			if(other.collider.tag == "Unit")
				Destroy(gameObject);
		}
	}
}
