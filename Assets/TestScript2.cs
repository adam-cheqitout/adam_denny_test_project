using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript2 : MonoBehaviour {
    private Rigidbody rb;
    public float parameter1;
    private Renderer rend;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
        rend = GetComponent<Renderer>();
	}
	
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Color color = Random.ColorHSV();
            rend.material.SetColor("_Color", color);
            
        }
    }
	void OnCollisionEnter(Collision collision)
    {
        rb.AddForce(Vector3.up * parameter1);
    }
}
