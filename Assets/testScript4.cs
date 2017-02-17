using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testScript4 : MonoBehaviour {

    public float parameter1 = 100;
    public float parameter2 = 10;

	// Use this for initialization
	void Start () {
		
	}
	
	void OnCollisionEnter(Collision collision)
    {
        print(collision.collider.name);
        if(collision.collider.name != "Terrain")
        {
            parameter1 = parameter1 - parameter2;
            print(parameter1);
        }
        if(parameter1 < 0)
        {
            Destroy(gameObject);
        }
    }
}
