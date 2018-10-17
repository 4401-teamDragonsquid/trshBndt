using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreCubesOn : MonoBehaviour 
{
	
	public GameObject cube1;
	public GameObject cube2;
	public GameObject cube3;
	public GameObject cube4;
	// Use this for initialization
	void Start () 
	{
		
	 	//cube1 = GameObject.Find("Cube (1)");
	 	//cube2 = GameObject.Find("Cube (2)");
	 	//cube3 = GameObject.Find("Cube (3)");
		//cube4 = GameObject.Find("Cube (4)");
		
	}
	
	
	
	// Update is called once per frame
	void Update () 
	{
		
		if(cube1.activeInHierarchy == true && cube2.activeInHierarchy == true && cube3.activeInHierarchy == true && cube4.activeInHierarchy == true)
		{
			Debug.Log("it worked bruh");
			//Application.LoadLevel(0);
		}
		
	 
		
	}
}
