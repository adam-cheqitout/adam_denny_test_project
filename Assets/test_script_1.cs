using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test_script_1 : MonoBehaviour {

    private Rigidbody rb;
    public float parameter2 = 10;
	// Use this for initialization
	void Start () {
        print("Never name your script something this stupid, ever!");
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        rb.AddRelativeForce(Vector3.up * parameter2 * Input.GetAxis("Vertical"));
        rb.AddTorque(Vector3.left * parameter2 * Input.GetAxis("Vertical"));
	}
}
