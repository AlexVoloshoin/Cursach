using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class P_move : MonoBehaviour
{
    public int helth;
    Animator animator;
    Rigidbody2D rb2D;
    public GameObject Baton_1;
    public GameObject Baton_2;
    public GameObject Jump;
    public float jumpboost = 10f;
    float btn_1, btn_2, jump, run;
    bool f = true;
    private bool onGround;
    public Transform grountCheck;
    public float checkRadius;
    public LayerMask whatIsIt;
    public int Jumps = 1;
    public GameObject Coin;
    public GameObject Pers;
    public GameObject End_panel;
    public Text coinText;
    int coinInt;
	void Die()
	{
		Destroy(gameObject);


	}
	public void Damage(int damage)
	{
		helth -= damage;
		if (helth <= 0)
		{
			Die();
		}
	}


	void Start()
    {
        coinInt = PlayerPrefs.GetInt("coins");
        animator = GetComponent<Animator>();
        btn_1 = Baton_1.transform.position.y;
        btn_2 = Baton_2.transform.position.y;
        jump = Jump.transform.position.y;
        rb2D = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }
    void Turn()
    {
        if (f == true)
        {
            transform.localRotation = Quaternion.Euler(0, 0, 0);
        }
        if (f == false)
        {
            transform.localRotation = Quaternion.Euler(0, 180, 0);
        }
    }
    void ReloadLvl()
	{
        Application.LoadLevel(Application.loadedLevel);
	}
    private void FixedUpdate()
    {
        onGround = Physics2D.OverlapCircle(grountCheck.position, checkRadius, whatIsIt);
    }
    
    void Update()
    {
        coinText.text = coinInt.ToString();
        
        if (onGround == true)
            Jumps = 1;
        if (jump != Jump.transform.position.y && Jumps > 0)
        {
            rb2D.velocity = Vector2.up * jumpboost;
            Jumps--;
        }
        else if (jump != Jump.transform.position.y && Jumps == 0 && onGround == true)
        {
            rb2D.velocity = Vector2.up * jumpboost;
        }
        if (btn_1 != Baton_1.transform.position.y)
        {
            f = true;
            run = 10f;
            Turn();
            animator.SetBool("Run", true);
        }
        else if (btn_2 != Baton_2.transform.position.y)
        {
            animator.SetBool("Run", true);
            f = false;
            run = -10f;
            Turn();
        }
        else
        {
            animator.SetBool("Run", false);
            run = 0;
        }
        rb2D.velocity = new Vector2(run, rb2D.velocity.y);
    }
    void OnCollisionEnter2D(Collision2D coins)
	{
        if(coins.gameObject.tag == "Coin")
		{
            coinInt++;
            Destroy(coins.gameObject);
            PlayerPrefs.SetInt("coins", coinInt);

		}
        else if(coins.gameObject.tag == "End")
		{
            End_panel.SetActive(true);
            Time.timeScale = 1;
            PlayerPrefs.SetInt("coins", coinInt);
        }
    }
}
