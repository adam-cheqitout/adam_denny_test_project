using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testScript3 : MonoBehaviour
{

    public GameObject parameter1;
    public float parameter2 = 20;
    private GameObject clone;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            clone = Instantiate(parameter1, transform.position, transform.rotation) as GameObject;
            clone.GetComponent<Rigidbody>().AddForce(clone.transform.forward * parameter2);
        }
    }
}
