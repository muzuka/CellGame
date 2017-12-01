using System.Collections.Generic;
using UnityEngine;

public class FindsCells : MonoBehaviour {

	public float speed;

	GameObject target;
	Rigidbody2D rigidBody;
	LayerMask cellMask;
	ContactFilter2D filter;

	List<GameObject> targets;

	void Start ()
	{
		cellMask = LayerMask.NameToLayer("Cell");
		filter = new ContactFilter2D();
		filter.SetLayerMask(cellMask);

		targets = new List<GameObject>(FindObjectsOfType<GameObject>());
		rigidBody = GetComponent<Rigidbody2D>();
		filterTargets();

		findTarget();
	}

	void Update ()
	{
		if(!rigidBody.IsTouching(filter) || target == null)
		{
			Vector3 toTarget = target.transform.position - transform.position;
			toTarget.Normalize();
			toTarget = toTarget * speed;

			rigidBody.velocity = toTarget;
		}
	}

	void filterTargets ()
	{
		for(int i = 0; i < targets.Count; i++)
		{
			if(targets[i].tag == "Virus")
			{
				targets.RemoveAt(i);
				i--;
			}
		}
	}

	void findTarget ()
	{
		foreach(GameObject t in targets)
		{
			if(t.tag == "Nucleus")
				target = t;
		}
	}
}
