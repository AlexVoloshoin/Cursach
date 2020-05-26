using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B_ph : MonoBehaviour
{
    public float speed = 40f;
    public int damag ;
    public Rigidbody2D rb2D;
    void Start()
    {
        damag = PlayerPrefs.GetInt("Damag");
        if(damag == 0)
		{
            damag = 1;
		}
        rb2D.velocity = transform.right * speed;
    }
    private void OnTriggerEnter2D(Collider2D hitInfo)
    {

        Enemy vrag = hitInfo.GetComponent<Enemy>();
		if (vrag != null)
		{
            vrag.Damage(damag);
		}
        Destroy(gameObject);


    }
    void Update()
    {

    }
}
