using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller_Touch : MonoBehaviour {
    public OVRInput.Controller controller;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = OVRInput.GetLocalControllerPosition(controller);
        
        transform.rotation = OVRInput.GetLocalControllerRotation(controller);
    }
}
