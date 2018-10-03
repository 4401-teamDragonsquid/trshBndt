using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneButt : MonoBehaviour 
{

	public void ButtonAction()
	{
		if (gameObject.activeInHierarchy == false) {
			gameObject.SetActive (true);
		} else
			gameObject.SetActive (false);
	
	}
}
