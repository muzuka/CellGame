using UnityEngine;
using System.Collections.Generic;

public enum StickyType {VIRUS, CELL}

public class Sticky : MonoBehaviour {

	public StickyType type;
	public float stickForce;
	public float maxDistance;

	List<GameObject> touched;
	bool touching;

	void Start ()
	{
		touched = new List<GameObject>();
	}

	void Update ()
	{
		if(touching)
		{
			foreach(GameObject touchedObject in touched) {
				Vector2 force = new Vector2(touchedObject.transform.position.x - transform.position.x, touchedObject.transform.position.y - transform.position.y);
				force.Normalize();
				force = force * stickForce;

				GetComponent<Rigidbody2D>().AddForce(force);
			}
		}
	}

	void OnCollisionEnter2D (Collision2D collision)
	{
		touched.Add(collision.collider.gameObject);
		touching = true;
	}

	void OnCollisionExit2D (Collision2D collision)
	{
		touched.Remove(collision.gameObject);
		touching = false;
	}

	public bool isTouching ()
	{
		return touching;
	}
}
