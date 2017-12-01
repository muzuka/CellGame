using UnityEngine.EventSystems;
using UnityEngine;

public class VacuoleController : MonoBehaviour {

    public GameObject player;

	void Start () {
        //player.GetComponent<PlayerController>().vacuoleCreated();
	}

	void OnDestroy () {
        player.GetComponent<PlayerController>().vacuoleDestroyed();
	}
}
