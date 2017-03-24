using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playaudio : MonoBehaviour {
    private AudioSource bang;
	// Use this for initialization
	void Start () {
        bang = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire1"))
        {
            bang.Play();
        }
	}
}
