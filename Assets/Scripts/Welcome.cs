using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Welcome : MonoBehaviour {
    public Animator SceneChange;
    public int markcounter=0;
    public GameObject RRRR;
    public int TTscore;
    public Text TTscoreText;
	
	void Start () {
        TTscore = ResultCCCode.TotalScore;
        if(TTscore != 0)
        {
            TTscoreText.text = "Total: " + TTscore;
        }
	}
    void Update()
    {
        if (markcounter >= 10)
        {
            RRRR.SetActive(true);
            SceneChange.Play("TitleAni2");
            Invoke("GoToSongSelectS", 3);
        }
    }

    public void ClickStart()
    {
        SceneChange.Play("TitleAni1");
        Invoke("GoToSongSelect", 2.5f);
    }
    public void ClickExit()
    {
        SceneChange.Play("");
        Invoke("Qiut", 2.5f);

    }
    public void ClickFuck()
    {
        markcounter++;
    }
    void Qiut()
    {
        Application.Quit();
    }
    void GoToSongSelect()
    {
        SceneManager.LoadScene("SongSelect");
    }
    void GoToSongSelectS()
    {
        SceneManager.LoadScene("SongSelect2");
    }

}
