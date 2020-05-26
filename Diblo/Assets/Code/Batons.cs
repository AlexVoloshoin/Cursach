using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Batons : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
	public float move = 1f;
	public void OnPointerDown(PointerEventData eventData)
	{
		transform.position = new Vector2(transform.position.x, transform.position.y - move);
	}
	public void OnPointerUp(PointerEventData eventData)
	{
		transform.position = new Vector2(transform.position.x, transform.position.y + move);
	}
}
