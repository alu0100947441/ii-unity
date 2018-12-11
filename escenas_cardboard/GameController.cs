using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public delegate void CambioCilindros();
public delegate void VibrarCilindros(bool vibrar);

public class GameController : MonoBehaviour {
    public static GameController instance;
    public event CambioCilindros EventoCambioCilindros;
    public event VibrarCilindros EventoVibrarCilindros;

    bool jugadorCiclope = false;
    public KeyCode teclaCiclope = KeyCode.Y;

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
    void Update() {
        
    }

    public void cambiarCilindros()
    {
        EventoCambioCilindros();
    }

    public void vibrarCilindros(bool vibrar)
    {
        EventoVibrarCilindros(vibrar);
    }

	public void activarCiclope() {
		jugadorCiclope = true;
	}

    public bool ataqueCiclope()
    {
        if (jugadorCiclope) {
            jugadorCiclope = false;
            return true;
        }
        return false;
    }
}
