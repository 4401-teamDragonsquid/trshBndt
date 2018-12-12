using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AreCubesOn : MonoBehaviour 
{
	
	public GameObject cube1;
	public GameObject cube2;
	public GameObject cube3;
	public GameObject cube4;
	// Use this for initialization
	void Start () 
	{
       // if (cube1.activeSelf)
       //     Debug.Log("SDFS");
        //cube1 = GameObject.Find("Cube (1)");
        //cube2 = GameObject.Find("Cube (2)");
        //cube3 = GameObject.Find("Cube (3)");
        //cube4 = GameObject.Find("Cube (4)");

    }
	
	
	
	// Update is called once per frame
	public void Update () 
	{
		//Debug by individual if statements
		if(cube1.activeSelf == true && cube2.activeSelf == true && cube3.activeSelf == true && cube4.activeSelf == true)
		{
			//Debug.Log("it worked bruh");
		 SceneManager.LoadScene(0);
		}
		
	 
		
	}
}
