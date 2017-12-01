using UnityEngine.EventSystems;

public interface IPlayerMessageTarget : IEventSystemHandler {

	void vacuoleDestroyed();
	void vacuoleCreated();
}
