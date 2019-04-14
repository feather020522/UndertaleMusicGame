using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour {
    public Animator player;
    public Collider2D Arrow0;
    public Rigidbody2D Soul;
    private int Dir;
    static public int score;
    public Text ScoreText;
    public float passsstime;
    //0=Left(-0.6164, 0.0269) 1=Up(0.003, 0.648) 2=Right(0.683, 0.0269) 3=Down(0.003, -0.619)
	void Start () {
        Dir = 0;
        score = 0;
        ScoreText.text = "Score: ";


    }
	
	
	void Update () {
        passsstime += Time.deltaTime;
        turn();
        
    }
    void turn()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log(passsstime);
            if (Dir == 0)
            {
                Dir = 1;
                player.Play("New Animation0");
            }
            else if (Dir == 2)
            {
                Dir = 1;
                player.Play("New Animation0-10");
            }
            else if (Dir == 3)
            {
                Dir = 1;
                player.Play("New Animation0-9");
            }
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log(passsstime);
            if (Dir == 0)
            {
                Dir = 3;
                player.Play("New Animation0-2");
            }
            else if (Dir == 1)
            {
                Dir = 3;
                player.Play("New Animation0-6");
            }
            else if (Dir == 2)
            {
                Dir = 3;
                player.Play("New Animation0-11");
            }
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Debug.Log(passsstime);
            if (Dir == 3)
            {
                Dir = 0;
                player.Play("New Animation0-7");
            }
            else if (Dir == 2)
            {
                Dir = 0;
                player.Play("New Animation0-12");
            }
            else if (Dir == 1)
            {
                Dir = 0;
                player.Play("New Animation0-4");
            }
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Debug.Log(passsstime);
            if (Dir == 3)
            {
                Dir = 2;
                player.Play("New Animation0-8");
            }
            else if (Dir == 1)
            {
                Dir = 2;
                player.Play("New Animation0-5");
            }
            else if (Dir == 0)
            {
                Dir = 2;
                player.Play("New Animation0-3");
            }
        }
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Note0"))
        {
            Destroy(other.gameObject);
            score += 10;
            ScoreText.text = "Score: " + score;
            //other.gameObject.SetActive(false);   
        }
    }

}
