using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchLight : MonoBehaviour {
    Light myLight;

	// Use this for initialization
	void Start () {
		myLight = this.GetComponent<Light>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.I))
        {
            // light on
            myLight.enabled = true;
        }
        if (Input.GetKey(KeyCode.O))
        {
            // light off
            myLight.enabled = false;
        }
    }
}
