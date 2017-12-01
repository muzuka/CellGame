using UnityEngine;

public class AttacksVirus : MonoBehaviour {

	public int attackDamage;

	void OnCollisionEnter2D (Collision2D collision)
	{
		if(collision.otherCollider.tag == "Virus")
		{

		}
	}

	void OnCollisionStay2D (Collision2D collision)
	{
		if(collision.otherCollider.tag == "Virus")
		{
			collision.otherCollider.gameObject.GetComponent<Health>().damage(attackDamage);
		}
	}

	void OnCollisionExit2D (Collision2D Collision)
	{

	}
}
