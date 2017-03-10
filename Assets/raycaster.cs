using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raycaster : MonoBehaviour {

    public Rigidbody rb;
    public float power = 10;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        Vector3 forward = transform.TransformDirection(Vector3.up * -1) * 10;
        Debug.DrawRay(transform.position, forward, Color.green);


        RaycastHit hit;

        Ray ray = new Ray(transform.position, transform.up * -1);

        if (Physics.Raycast(ray, out hit))
        {
            print(hit.distance);
            if (hit.collider != null)
            {
                print(hit.collider.name);
            }
            //Debug.Log(Mathf.Log(6, 2));
            print(power / Mathf.Exp(hit.distance));
            rb.AddRelativeForce(Vector3.up * (power / Mathf.Exp(hit.distance)));
        }

        rb.AddRelativeTorque(Vector3.up * Input.GetAxis("Horizontal"));
        rb.AddRelativeTorque(Vector3.left * Input.GetAxis("Vertical") * power);

    }
}
