using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 2;
	public Transform C_inst;
	public GameObject Coin;
	void Die()
	{
		Destroy(gameObject);
		Instantiate(Coin, C_inst.position, C_inst.rotation);
		GetComponent<AudioSource>().Play();
	}
    public void Damage(int damage)
	{
		health -= damage;
		if(health <= 0)
		{
			Die();
			GetComponent<AudioSource>().Play();
		}
	}
}
