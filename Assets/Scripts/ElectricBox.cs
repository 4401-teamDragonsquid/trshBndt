using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ElectricBox : MonoBehaviour {

    // Use this for initialization
    public void OnTriggerStay(Collider other)
    {
        Debug.Log("entered");
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene(1);
            Debug.Log("Zap!");
        }
    }

}
