using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class PointerController : MonoBehaviour, IPointerDownHandler, IPointerUpHandler {
	private bool pressed;
	public void OnPointerUp (PointerEventData eventData) {
		pressed = false;
	}

	public void OnPointerDown (PointerEventData eventData){
		pressed = true;
	}
	public bool getPressed () {
		return pressed;
	}
}