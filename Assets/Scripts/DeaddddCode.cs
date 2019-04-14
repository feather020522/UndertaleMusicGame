using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class DeaddddCode : MonoBehaviour {
    public GameObject SoulAni;
    public GameObject GGWP;
    public Animator GGGG;

	void Start () {
        Invoke("PlayGGAni",3.5f);
	}
	
	
	void Update () {
        

        
	}
    void PlayGGAni()
    {
        Destroy(SoulAni);
        GGWP.SetActive(true);
    }
    public void ClickGB()
    {
        GGGG.Play("DeadAni3");
        Invoke("GoB", 2.5f);
    }
    public void ClickExit()
    {
        GGGG.Play("DeadAni3");
        Invoke("Qiut", 2.5f);

    }
    void GoB()
    {
        SceneManager.LoadScene("Title");
    }
    void Qiut()
    {
        Application.Quit();
    }
}
