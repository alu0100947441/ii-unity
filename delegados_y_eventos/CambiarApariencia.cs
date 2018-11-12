using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiarApariencia : MonoBehaviour {
    public Renderer rend;

    // Use this for initialization
    void Start () {
        rend = GetComponent<Renderer>();
        GameController.instance.EventoCambioCilindros += CambiarColor;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void CambiarColor ()
    {
        rend.material.color = Color.red;
    }
}
