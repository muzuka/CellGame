using UnityEngine.EventSystems;
using UnityEngine;

public class VacuoleEvents : MonoBehaviour {

	PlayerController player;

	void Start () {
		player = FindObjectOfType<PlayerController>();

		if(player)
			ExecuteEvents.Execute<IPlayerMessageTarget>(player.gameObject, null, (x, y)=>x.vacuoleCreated());
	}

	void OnDestroy () {
		if(player)
			ExecuteEvents.Execute<IPlayerMessageTarget>(player.gameObject, null, (x, y)=>x.vacuoleDestroyed());
	}
}
