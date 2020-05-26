using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cam_Ch : MonoBehaviour
{
    public Transform End_spot;
    public GameObject Flag;
    public GameObject[] enems;
    public GameObject Player;
    int i = 1,j = 0;
    void Update()
    {
        if(enems[j] == null)
		{
            j++;
		}
        if(j == enems.Length - 1 && i == 1)
        {
            Instantiate(Flag, End_spot.position, End_spot.rotation);
            i = 0;
        }
        transform.position = new Vector3(Player.transform.position.x, Player.transform.position.y, -10f);
    }
}
