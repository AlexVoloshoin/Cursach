using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Swich_LvLs : MonoBehaviour
{
	public int num;
	public void Game()
	{
		
		SceneManager.LoadScene(num);
	}
}
