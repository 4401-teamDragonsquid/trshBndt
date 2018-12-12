using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl1 : MonoBehaviour {
    public GameObject cameraPosition1;
    public GameObject cameraPosition2;
    public GameObject theCamera;
    // Update is called once per frame
 
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collision");
        if (theCamera.transform.position == cameraPosition2.transform.position)
        
            {
            theCamera.transform.position = cameraPosition1.transform.position;
            Debug.Log("If Statement");
            }
       //if (theCamera.transform.position == cameraPosition2.transform.position)
    }
}
