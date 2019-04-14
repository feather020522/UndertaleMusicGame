using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Music0 : MonoBehaviour {
    [Header("設定相關")]
    public Collider2D GreenSoul;
    public Rigidbody2D GS;
    public Text HealthpointText;
    public AudioSource song00;
    public Animator GStart;
    public Animator CameraA;
    public int HP;
    static public int misses = 0;
    static public int maxHP;
    public GameObject LoadingBG;
    public GameObject StartCanvas;
    public int songtime;
    [Header("箭頭方向")]
    public Transform note0;
    public Transform note1;
    public Transform note2;
    public Transform note3;
    public Transform noteslow0;
    public Transform noteslow1;
    public Transform noteslow2;
    public Transform noteslow3;
    public Transform noteslowv0;
    public Transform noteslowv1;
    public Transform noteslowv2;
    public Transform noteslowv3;
    [Header("譜面")]
    public float[] BTime;
    public float[] NNotes;
    public float StartTime;
    public float passtime = 0;
    static public bool MusicStart = false;
    public Image nextA;
    // lag 0.1 * speed

    void Start()
    {
        maxHP = HP;
        StartCanvas.SetActive(true);
        LoadingBG.SetActive(true);
        GStart.Play("StartAni0");
        //Invoke("GameStart", 0);
    }
    public void STButton()
    {
        Destroy(LoadingBG);
        GStart.Play("StartAni1");
        Invoke("GameStart", 4.5f);
    } 
    void GameStart () {
        MusicStart = true;
        passtime = StartTime;
        song00.time = StartTime;
        song00.Play();
        HealthpointText.text = "HP: " + HP;
        for (int i=0; i<NNotes.Length; i++)
        {
            if (BTime[i] >= StartTime)
            {
                Invoke("test" + NNotes[i], BTime[i] - StartTime);
            }
        }
        
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Note0"))
        {
            Destroy(other.gameObject);
            HP -= 1;
            misses += 1;
            HealthpointText.text = "HP: " + HP;  
        }
    }
   
    void Update () {
        if (MusicStart)
        {
            passtime += Time.deltaTime;
        }
       
        if(HP == 0)
        {
            song00.Stop();
            SceneManager.LoadScene("Deadddd");
        }
        Cleared();
    }
    void Cleared()
    {
        if(songtime - (int)passtime < 0)
        {
            song00.Pause();
            GStart.Play("ClearAni0");
            Invoke("Result", 4.5f);
        }
    }
    void Result()
    {
        SceneManager.LoadScene("Result");
    }
    void test4()
    {
        Instantiate(note0);
    }
    void test8()
    {
        Instantiate(note1);
    }
    void test6()
    {
        Instantiate(note2);
    }
    void test2()
    {
        Instantiate(note3);
    }
    void test1()
    {
        Instantiate(noteslow0);
    }
    void test7()
    {
        Instantiate(noteslow1);
    }
    void test9()
    {
        Instantiate(noteslow2);
    }
    void test3()
    {
        Instantiate(noteslow3);
    }
    void test44()
    {
        Instantiate(noteslowv0);
    }
    void test88()
    {
        Instantiate(noteslowv1);
    }
    void test66()
    {
        Instantiate(noteslowv2);
    }
    void test22()
    {
        Instantiate(noteslowv3);
    }
    void test5555()
    {
        CameraA.Play("1-2spAni0");
        Invoke("test55550002",1);
    }
    void test55550002()
    {
        CameraA.Play("qasd");
        
    }
    void test6666()
    {
        CameraA.Play("1-2spAni1");
        Invoke("test55550002", 1.5f);
    }

}
