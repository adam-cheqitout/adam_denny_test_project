using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testScript5 : MonoBehaviour {
    public float totalExposure = 0.1f;
    public float changeAmount = 0.1f;
    public float maxExposure = 10;
    public float minExposure = -10;
    private bool increasing = true;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(totalExposure > maxExposure)
        {
            increasing = false;
        }
        if (increasing)
        {
            totalExposure += changeAmount;
            RenderSettings.skybox.SetFloat("_Exposure", totalExposure);
        } else
        {
            totalExposure -= changeAmount;
            RenderSettings.skybox.SetFloat("_Exposure", totalExposure);
        }
        if(totalExposure < minExposure)
        {
            increasing = true;
        }

    }
}
