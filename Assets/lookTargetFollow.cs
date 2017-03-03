using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lookTargetFollow : MonoBehaviour {

    public Transform target;
    public float lag;

	// Update is called once per frame
	void LateUpdate () {
        transform.position = Vector3.Lerp(transform.position, target.position, lag);		
	}
}
