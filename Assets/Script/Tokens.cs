using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tokens : MonoBehaviour
{
    [System.Serializable]
    public class Token
    {
        public string nome;
        public int[] costo;
        public int valore;
        public int[] simboli; // un token può portarsi dietro una serie di valori non numerali di cui tenere conto (colore, seme, etc...)
        public Effetto[] effetti;
        public int[] costoLatoB;
        public int valoreLatoB;
        public int[] simboliLatoB; // un token può portarsi dietro una serie di valori non numerali di cui tenere conto (colore, seme, etc...)
        public Effetto[] effettiLatoB;
    }

    //public bool showFaceA;
    // tiene traccia dei token disponibili
    public int index;

    public int Index
    {
        get
        {
            return index;
        }

        set
        {
            index = value;
        }
    }

    public void estrai()
    {
        index--;
    }

    public void inserisci()
    {
        index++;
    }

    // Use this for initialization
    void Start ()
    {
        //spriteRender = GetComponent<SpriteRenderer>();
        //nroToken = GameObject.Find("NroToken");
        //nroToken = GUIText.FindGameObjectWithTag("Label");
        //t = nroToken.GetComponent<Text>
        //toggleFace(showFaceA);
        index = 10;
        Debug.Log(index);
	}
	
	// Update is called once per frame
	void Update ()
    {
	}
}
