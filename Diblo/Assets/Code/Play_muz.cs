using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Play_muz : MonoBehaviour
{
    public GameObject Baton_1;
    float btn_1;
    void Start()
    {
        btn_1 = Baton_1.transform.position.y;
    }

   
    void Update()
    {
		if (btn_1 != Baton_1.transform.position.y)
		{
            GetComponent<AudioSource>().Play();

		}
        
    }
}
