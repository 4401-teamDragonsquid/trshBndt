using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class RaccoonMovement : MonoBehaviour
{

    Vector3 hitPosition;
    public NavMeshAgent agent;
    public LayerMask floorLayer;
    public float playerSpeed;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            //Debug.Log ("Click");
            RaycastHit hit;
            //Raycast2D would be helpful for the game
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, floorLayer))
            //Physics2d Perhaps 2d and 3d physics are different
            {
                hitPosition = hit.point;
                Debug.Log(hitPosition);
            }
        }
        //transform.LookAt(hitPosition);
        //transform.position = Vector3.MoveTowards(transform.position, hitPosition, playerSpeed * Time.deltaTime);
        agent.SetDestination (hitPosition);
        //This waycould cut work and allows the player to move around objects on its own. May not work in 2D
    }
}
