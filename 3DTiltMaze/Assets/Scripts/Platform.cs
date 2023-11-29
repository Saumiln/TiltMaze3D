using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public Vector3 currentRot;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentRot = GetComponent<Transform>().eulerAngles;

        if((Input.GetAxis("Horizontal") < -0.2) && (currentRot.z <= 28 || currentRot.z >= 330)) {
            transform.Rotate(0,0,(float).05);
        }

        if((Input.GetAxis("Horizontal") > 0.2) && (currentRot.z >= 331 || currentRot.z <= 29)) {
            transform.Rotate(0,0,(float)-.05);
        }

        if((Input.GetAxis("Vertical") < -0.2) && (currentRot.x <= 29 || currentRot.x >= 331)) {
            transform.Rotate((float)-.05,0,0);
        }

        if((Input.GetAxis("Vertical") > 0.2) && (currentRot.x >= 330 || currentRot.x <= 28)) {
            transform.Rotate((float).05,0,0);
        }
        
    }
}
