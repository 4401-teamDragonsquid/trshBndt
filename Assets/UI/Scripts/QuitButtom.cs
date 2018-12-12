using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuitButtom : MonoBehaviour {

	// Use this for initialization
	public void quitgame () 
    {
        Application.Quit();
        Debug.Log("it worked");
	}
	

}
