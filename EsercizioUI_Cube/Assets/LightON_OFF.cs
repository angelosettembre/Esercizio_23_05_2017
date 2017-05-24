using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LightON_OFF : MonoBehaviour {

    public Image lightOn;
    public Image lightOff;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

    }

    public void onClickLightOFF()
    {
        GetComponent<Light>().enabled = false;
        lightOff.GetComponent<Image>().enabled = false;
        lightOn.GetComponent<Image>().enabled = true;
    }

    public void onClickLightON()
    {
        GetComponent<Light>().enabled = true;
        lightOn.GetComponent<Image>().enabled = false;
        lightOff.GetComponent<Image>().enabled = true;
    }
}
