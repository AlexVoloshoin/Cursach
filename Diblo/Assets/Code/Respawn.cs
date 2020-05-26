using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
	public GameObject Resp;
	void OnTriggerEnter2D(Collider2D drug)
	{
			Destroy(drug.gameObject);
	}
}
