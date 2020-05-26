using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause_menu : MonoBehaviour
{
    
    public GameObject panel;
    public GameObject Baton;
    float btn_1;
    private bool is_Paused = false;

    void Start()
    {
        btn_1 = Baton.transform.position.y;
    }

 
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape) && btn_1 != Baton.transform.position.y && is_Paused == false)
		{
            panel.SetActive(true);
            Time.timeScale = 0;
            is_Paused = true;
        }
        else if(Input.GetKeyDown(KeyCode.Escape) && btn_1 != Baton.transform.position.y && is_Paused == true)
		{
            panel.SetActive(false);
            Time.timeScale = 0;
            is_Paused = false;
        }
    }
}
