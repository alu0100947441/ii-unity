using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiarLuminosidad : MonoBehaviour {
	public Light myLight;
	public const float intensityChange = 0.5F; 

	// Use this for initialization
	void Start () {
		myLight = this.GetComponent<Light>();
	}

	public void Aumentar() {
		myLight.intensity += intensityChange;
	}

	public void Disminuir() {
		myLight.intensity -= intensityChange;
	}
}
