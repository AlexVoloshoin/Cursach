using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
	public Transform F_point;
	
	public GameObject Baton_F;
	public GameObject Bullet;

	int i = 0;
	float btn_F;
	void Start()
	{
		btn_F = Baton_F.transform.position.y;
	}
	void Shoot()
	{
		Instantiate(Bullet, F_point.position, F_point.rotation);
	}
	void Update()
	{
		if (btn_F == Baton_F.transform.position.y)
			i = 0;
		if (btn_F != Baton_F.transform.position.y && i == 0)
		{
			Shoot();
			i = 1;
		}
		
	}
}
