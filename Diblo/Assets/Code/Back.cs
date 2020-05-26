using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Back : MonoBehaviour
{
    public GameObject panel;
    public GameObject Baton;
    float btn_1;
    
    void Start()
    {
        btn_1 = Baton.transform.position.y;
    }

    void Update()
    {
        if(btn_1 != Baton.transform.position.y)
		{
            panel.SetActive(false);
            Time.timeScale = 1;
            
        }
        
    }
}
