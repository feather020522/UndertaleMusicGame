using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicSpecial : MonoBehaviour {
    public bool WTF = false;
    public GameObject WWTTFF;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        WTF = Music0.MusicStart;
        if (WTF)
        {
            WWTTFF.SetActive(true);
        }
	}
}
