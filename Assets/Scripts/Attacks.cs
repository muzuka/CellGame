using UnityEngine;

/// <summary>
/// Attacks relevant things that are touching it.
/// </summary>
public class Attacks : MonoBehaviour {

	public float attackTime;
	public int attackDamage;

	Rigidbody2D rigidBody;
	LayerMask cellMask;
	LayerMask virusMask;
	ContactFilter2D filter;

	Timer timer;

	void Start () {
		timer = new Timer(attackTime);
		rigidBody = GetComponent<Rigidbody2D>();

		cellMask = LayerMask.GetMask("Cell", "Nucleus");
		virusMask = LayerMask.GetMask("Virus");

		filter = new ContactFilter2D();

		if(gameObject.tag == "Virus")
			filter.SetLayerMask(cellMask);
		else
			filter.SetLayerMask(virusMask);
	}

	void Update () {
		if(rigidBody.IsTouching(filter))
			timer.update(attack);
	}

	void attack ()
	{
		Collider2D[] colliders = new Collider2D[10];
		int contactSize = rigidBody.GetContacts(colliders);

		for(int i = 0; i < contactSize; i++)
			colliders[0].gameObject.GetComponent<Health>().damage(attackDamage);
	}
}
