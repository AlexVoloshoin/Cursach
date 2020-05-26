using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_move : MonoBehaviour
{
    public Transform F_point_Bot;
    public GameObject Bullet;
    public GameObject Pers;
    public GameObject Enemy;
    public float S;
    private float wait = 0f;
    public float StartWaitTime = 0.01f;
    public Transform[] spots;
    private int Rspots;
    float position;
    public float dist = 6f;
    RaycastHit2D hit;
    
    void Shoot()
	{
		Instantiate(Bullet, F_point_Bot.position, F_point_Bot.rotation);
	}
	void Turn()
	{
        if((position - transform.position.x) >= 0.001f)
		{
            transform.localRotation = Quaternion.Euler(0, 180, 0);
           
        }
		else if((position - transform.position.x) <= 0.001f)
        {
            transform.localRotation = Quaternion.Euler(0, 0, 0);
            
        }
	}
    void Start()
    {
      
        position = transform.position.x;
        wait = StartWaitTime;
        Rspots = Random.Range(0, spots.Length);
       
    }
    void Update()
    {
        Physics2D.queriesStartInColliders = false;
        hit = Physics2D.Raycast(F_point_Bot.position, F_point_Bot.right);
		if (hit)
		{
            if(wait <= 0)
			{
                Shoot();
                wait = StartWaitTime;
			}
            else
			{
                wait -= Time.deltaTime;
			}
            
		}
            
				
        transform.position = Vector2.MoveTowards(transform.position, spots[Rspots].position, S * Time.deltaTime);
        if(Vector2.Distance(transform.position,spots[Rspots].position)< 0.2f)
		{
			if (wait <= 0)
			{
                Rspots = Random.Range(0, spots.Length);
                wait = StartWaitTime;
                position = transform.position.x;
            }
			else
			{
                
                wait -= Time.deltaTime;
			}
		}
        Turn();
    }
    
}
