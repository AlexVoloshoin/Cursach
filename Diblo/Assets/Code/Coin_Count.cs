using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coin_Count : MonoBehaviour
{
    public GameObject Baton_1;
    public Text C_txt;
    public Text P_txt;
    int coins, dmg, cost;
    

    void Start()
    {
		if (!PlayerPrefs.HasKey("count"))
		{
            PlayerPrefs.SetInt("count", 2);
            

        }
        coins = PlayerPrefs.GetInt("coins");
        C_txt.text = coins.ToString();
    }

   public void Up()
	{
       
        cost = PlayerPrefs.GetInt("count");
        if(coins >= cost)
		{
            dmg++;
            PlayerPrefs.SetInt("Damag", dmg);
            coins -= cost;
            cost += 2;
            PlayerPrefs.SetInt("coins", coins);
        }
	}
    void Update()
    {
        P_txt.text = cost.ToString();
       C_txt.text = coins.ToString();
        P_txt.text = PlayerPrefs.GetInt("count").ToString();
    }
}
