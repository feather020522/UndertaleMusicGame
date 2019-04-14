using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ResultCCCode : MonoBehaviour {
    public int resultScore;
    public int mHP, mis=0;
    public float Rk;
    public Text RkText,rscoreText;
    public Image BKKK;
    public Animator RSCon;
    private Color32 purple = new Color32(255,0,255,1);
    static public int TotalScore=0;
	
	void Start () {
        resultScore = Player.score;
        mis = Music0.misses;
        mHP = Music0.maxHP;
        Rk = (float)mis / mHP;
        rscoreText.text = "Score: " + resultScore;
        TotalScore += resultScore; 

    }
	void Update () {
        Rank();
    }
    public void NextB()
    {
        RSCon.Play("ResultAni1");
        Invoke("GoHome",2.25f);
    }
    void GoHome()
    {
        SceneManager.LoadScene("Title");
    }
    void Rank()
    {
        if (Rk == 0)
        {
            RkText.text = "P";
            RkText.color = Color.yellow;
        }
        else if (Rk <= 0.1)
        {
            RkText.text = "S";
            RkText.color = Color.white;
        }
        else if (Rk <= 0.3)
        {
            RkText.text = "A";
            RkText.color = Color.red;
        }
        else if (Rk <= 0.5)
        {
            RkText.text = "B";
            RkText.color = Color.blue;
        }
        else if (Rk <= 0.8)
        {
            RkText.text = "C";
            RkText.color = Color.green;
        }else
        {
            RkText.text = "D";
            RkText.color = purple;
            
        }

    }
}
