using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class ActElecBox : MonoBehaviour {

    public UnityEvent myUnityEvent;

    void Awake()
    {
        if (myUnityEvent == null)
            myUnityEvent = new UnityEvent();
    }

    public void DoAction()
    {
        SceneManager.LoadScene(1);
    }
}
