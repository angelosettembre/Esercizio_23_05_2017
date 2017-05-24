using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LightIntensity : MonoBehaviour {

    public Slider slider;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnSlideIntensity()
    {
        if(slider.value > 0.5)
        {
            GetComponent<Light>().intensity = GetComponent<Light>().intensity + 1;
        }
        if(slider.value < 0.5)
        {
            GetComponent<Light>().intensity = GetComponent<Light>().intensity - 1;
        }
    }
}
