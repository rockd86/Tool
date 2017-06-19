using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TokensView : MonoBehaviour
{
    Tokens tokens;
    public Sprite latoA;
    public Sprite latoB;
    public bool showFaceA;

    // se 2D
    SpriteRenderer spriteRenderer;
    public Canvas canvas;
    UnityEngine.UI.Button buttonPrendi;
    UnityEngine.UI.Button buttonFlip;
    UnityEngine.UI.Text text;


    // Use this for initialization
	void Start ()
    {
        tokens = GetComponent<Tokens>();
        spriteRenderer = GetComponent<SpriteRenderer>();

        buttonPrendi = GameObject.Find("PrendiToken").GetComponent<UnityEngine.UI.Button>();
        buttonPrendi.onClick.AddListener(PrendiToken);
        text = GameObject.Find("NroToken").GetComponent<UnityEngine.UI.Text>();

        buttonFlip = GameObject.Find("FlipToken").GetComponent<UnityEngine.UI.Button>();
        buttonFlip.onClick.AddListener(FlipToken);
        Debug.Log(tokens.Index);

        //text.text = Convert.ToString(tokens.Index);
        //text.text = Convert.ToString(tokens.index);
    }

    private void FlipToken()
    {
        toggleFace(showFaceA);
    }

    private void PrendiToken()
    {
        if(tokens.index > 0)
            tokens.estrai();

        if (tokens.index == 0)
            spriteRenderer.enabled = false;

    }

    // Update is called once per frame
    void Update ()
    {
        text.text = Convert.ToString(tokens.index);
    }

    public void toggleFace(bool toogle)
    {
        if (showFaceA)
        {
            spriteRenderer.sprite = latoA;
            showFaceA = false;
        }  
        else
        {
            spriteRenderer.sprite = latoB;
            showFaceA = true;
        }
    }

    public void visualizzaToken(bool show)
    {
        if (show)
            spriteRenderer.enabled = true;
        else
            spriteRenderer.enabled = false;
    }
}
