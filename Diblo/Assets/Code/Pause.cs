using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public int Curent_Scene;
    private bool paused = false;
    public GameObject p_panel;
    public GameObject Flag;
    
    void Start()
    {
        
    }


    void Update()
    {
       
        if (Input.GetKeyDown(KeyCode.Escape) && !paused)
		{
            p_panel.SetActive(true);
            Time.timeScale = 1;
            paused = true;
        }
        else if(Input.GetKeyDown(KeyCode.Escape) && paused)
		{
            p_panel.SetActive(true);
            Time.timeScale = 1;
            paused = true;
        }
        
    }
    public void Rest()
	{

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0);
        p_panel.SetActive(false);
        Time.timeScale = 1;
        paused = false;
    }
    public void pause_on()
	{
        p_panel.SetActive(true);
        Time.timeScale = 0;
        paused = true;
    }
    public void cont()
	{
        p_panel.SetActive(false);
        Time.timeScale = 1;
        paused = false;
    }
    public void toMenu()
	{
        Time.timeScale = 1;
        SceneManager.LoadScene("M_menu");
    }
    public void Next()
	{
        SceneManager.LoadScene(Curent_Scene + 1);
        p_panel.SetActive(false);
        Time.timeScale = 1;
        paused = false;
    }
}
