using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followBall : MonoBehaviour {

    public Transform target;
    public float xCorrection;
    public float zCorrection;
    public float drag = 1;
    public Transform lookTarget;
    public float test = 20;
	// Update is called once per frame
	void LateUpdate () {
        //transform.position = Vector3.Lerp(transform.position, new Vector3(target.position.x + xCorrection, transform.position.y, target.position.z + zCorrection), drag);
        transform.position = new Vector3(target.position.x + xCorrection, transform.position.y, target.position.z + zCorrection);
        transform.LookAt(target.position);
	}
}
