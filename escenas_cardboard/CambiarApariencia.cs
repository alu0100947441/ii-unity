using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiarApariencia : MonoBehaviour {
    public Transform tf;
    public Renderer rend;

    private bool vibrando;
    public float speed = 30f; //how fast it shakes
    public float amount = 0.015f; //how much it shakes

    // Use this for initialization
    void Start () {
        rend = GetComponent<Renderer>();
        tf = GetComponent<Transform>();
        GameController.instance.EventoCambioCilindros += CambiarColor;
        GameController.instance.EventoVibrarCilindros += Vibrar;
    }
	
	// Update is called once per frame
	void Update () {
        if(vibrando)
            tf.localPosition = new Vector3(tf.localPosition.x + Mathf.Sin(Time.time * speed) * amount, tf.localPosition.y, tf.localPosition.z);
    }

    void CambiarColor ()
    {
        rend.material.color = Color.red;
    }

    void Vibrar(bool vibrar)
    {
        vibrando = vibrar;
    }
}
