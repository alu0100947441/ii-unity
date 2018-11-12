using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public delegate void CambioCilindros();

public class GameController : MonoBehaviour {
    public static GameController instance;
    public event CambioCilindros EventoCambioCilindros;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this);
        }
        else if (instance != this)
            Destroy(gameObject);
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void cambiarCilindros()
    {
        EventoCambioCilindros();
    }
}
