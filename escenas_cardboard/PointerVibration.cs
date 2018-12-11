using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PointerVibration : EventTrigger {
	Transform tf;
	// Use this for initialization

	void Start () {
		tf = GetComponent<Transform>();
	}
	
	public void aumentarTamano() {
		tf.localScale = new Vector3(tf.localScale.x * 1.2F, tf.localScale.y * 1.2F, tf.localScale.z * 1.2F);
	}

	public void recuperarTamano() {
		tf.localScale = new Vector3(tf.localScale.x / 1.2F, tf.localScale.y / 1.2F, tf.localScale.z / 1.2F);
	}

    public override void OnPointerEnter(PointerEventData eventData)
    {
        aumentarTamano();
        GameController.instance.vibrarCilindros(true);
    }

    public override void OnPointerExit(PointerEventData eventData)
    {
        recuperarTamano();
        GameController.instance.vibrarCilindros(false);
    }
}
