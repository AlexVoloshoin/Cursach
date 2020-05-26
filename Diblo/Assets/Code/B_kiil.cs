using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B_kiil : MonoBehaviour
{
    public GameObject Baton;
    public GameObject Enemy;
    public Transform F_point;
    public Transform positon;
    public GameObject Bullet;
    float btn_1;
    int i = 0;
    public int B_helth;
    void Start()
    {
        btn_1 = Baton.transform.position.y;
    }
    void Update()
    {
        if (btn_1 != Baton.transform.position.y && i == 0)
		{
            Instantiate(Enemy, positon.position, positon.rotation);
            i++;
        }
        if(btn_1 != Baton.transform.position.y && i >= 0 && i <= B_helth)
		{
            Instantiate(Bullet, F_point.position, F_point.rotation);
            

        }
    }
}
