using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Helth_sis : MonoBehaviour
{
    public int helth;
    public int countoflives;
    public Image[] lives;
    public Sprite is_Live;
    public Sprite no_Live;
    public GameObject Play;
    public GameObject bull;
    public GameObject panel;
    void Start()
    {
         
    }
    void OnCollisionEnter2D(Collision2D tch)
    {
        if (tch.gameObject.tag == "Vrag")
        {
            helth--;
            
        }
       
    }
    private void OnTriggerEnter2D(Collider2D hitInfo)
	{
        helth--;
        Destroy(bull.gameObject);
    }
    void Update()
    {
        if(helth == 0)
		{
            Destroy(gameObject);
            panel.SetActive(true);
            Time.timeScale = 0;
        }
        if(helth > countoflives)
		{
            helth = countoflives;
		}
		for (int i = 0; i < lives.Length; i++)
		{
			if (i < helth)
			{
                lives[i].sprite = is_Live;
			}
			else
			{
                lives[i].sprite = no_Live;
            }
            if(i < countoflives)
			{
                lives[i].enabled = true;
			}
			else
			{
                lives[i].enabled = false;
            }
		}
    }
}
