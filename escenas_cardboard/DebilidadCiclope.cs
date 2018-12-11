using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DebilidadCiclope : EventTrigger {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public override void OnPointerEnter(PointerEventData eventData)
    {
        if (GameController.instance.ataqueCiclope())
            Destroy(gameObject);
    }
}
