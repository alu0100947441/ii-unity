using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CambiarTamaño : MonoBehaviour {

	Transform tf;
	public Slider sl;

	// Use this for initialization
	void Start () {
		tf = GetComponent<Transform>();
	}

	public void cambiarTamaño() {
		tf.localScale = new Vector3 (sl.value, sl.value, sl.value);
		tf.localPosition = new Vector3 (tf.localPosition.x, sl.value / 2, tf.localPosition.z);
	}
}
