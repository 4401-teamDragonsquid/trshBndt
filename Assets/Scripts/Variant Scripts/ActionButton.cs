using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ActionButton : MonoBehaviour {
    public ActElecBox actElecBox;

    void Update()
    {
        if (Input.GetKeyDown("E"))
        {
            if (actElecBox != null)
            {
                actElecBox.DoAction();
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        //Try getting and setting ActionObject Component
        actElecBox = other.gameObject.GetComponent<ActElecBox>();
    }

    void OnTriggerExit(Collider other) {
            actElecBox = null;
        }
    }

