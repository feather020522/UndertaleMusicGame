using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SongSelect : MonoBehaviour {

    public List<SongData> SongData = new List<SongData>();
    static public List<SongData> SongDataBK = new List<SongData>();
    public Image Background;
    public Text Author, SongName;
    public AudioClip BGM;
    public AudioSource Sound;
    public Animator Loading;
    public string beatmap;
    static public int ID;
    static public Image ResultBB;
    // Use this for initialization
    void Start()
    {
        ID = 1;
        Background.sprite = SongData[ID - 1].image;
        BGM = SongData[ID - 1].music;
        beatmap = SongData[ID - 1].beatmapName;
        Sound.clip = BGM;
        SongName.text = SongData[ID - 1].SongName;
        Sound.Play();
        SongDataBK = SongData;
    }

    // Update is called once per frame
    void Update()
    {
        IDchange();

    }
    void IDchange()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (ID + 1 > SongData.Count)
            {
                ID = 1;
                Songchange();
            }
            else
            {
                ID++;
                Songchange();
            }

        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (ID - 1 <= 0)
            {
                ID = SongData.Count;
                Songchange();
            }
            else
            {
                ID--;
                Songchange();
            }
        }
    }

    void Songchange()
    {
        Background.sprite = SongData[ID - 1].image;
        BGM = SongData[ID - 1].music;
        beatmap = SongData[ID - 1].beatmapName;
        Sound.clip = BGM;
        SongName.text = SongData[ID - 1].SongName;
        Sound.Play();
    }
    public void StartGame()
    {
        Loading.Play("LoadingAni1");
        Invoke("StartGame2", 2.5f);
    }
    public void StartGame2()
    {
        SceneManager.LoadScene(beatmap);
    }
}
