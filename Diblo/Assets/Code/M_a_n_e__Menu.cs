using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class M_a_n_e__Menu : MonoBehaviour
{
	public Text coinT;
	public void P_Game()
	{
		SceneManager.LoadScene(2);
	}
	void Start()
	{
		if (!PlayerPrefs.HasKey("coins"))
		{
			PlayerPrefs.SetInt("coins", 0);

		}
	}
	public void Grade()
	{
		SceneManager.LoadScene(1);
	}
	public void Play_Muz()
	{
		GetComponent<AudioSource>().Play();
	}
}
