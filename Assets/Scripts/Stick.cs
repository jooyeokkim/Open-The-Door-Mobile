using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Stick : MonoBehaviour,IPointerDownHandler,IPointerUpHandler,IDragHandler {
	public RectTransform background;
	public RectTransform joystick;
	private float radius;
	public GameObject player;
	public float moveSpeed;
	private Vector2 value = Vector2.zero;
	void Start () {
		radius = background.rect.width*0.5f;
	}

	public void OnDrag(PointerEventData eventData){
		value = eventData.position - (Vector2)background.position;
		value = Vector2.ClampMagnitude (value, radius);
		joystick.localPosition = value;
		value = value.normalized;
	}
	public void OnPointerDown(PointerEventData eventData){}

	public void OnPointerUp(PointerEventData eventData){
		joystick.localPosition = Vector3.zero;
		value = Vector2.zero;
	}
	public Vector2 GetJoystickPosition(){
		return value;
	}
}
