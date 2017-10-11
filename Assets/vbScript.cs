using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class vbScript : MonoBehaviour, IVirtualButtonEventHandler
{
    private GameObject vbButtonObject;
    private GameObject zombie;
    // Use this for initialization
    void Start()
    {
        vbButtonObject = GameObject.Find("actionButton");
        vbButtonObject.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        zombie = GameObject.Find("zombie");
    }

    public void OnButtonPressed(VirtualButtonAbstractBehaviour vb)
    {
        Debug.Log("button down!!!");
        zombie.transform.Rotate(new Vector3(0, Time.deltaTime * 1000, 0));


    }

    public void OnButtonReleased(VirtualButtonAbstractBehaviour vb)
    {

    }
}
