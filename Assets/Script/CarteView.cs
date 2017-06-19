using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarteView : MonoBehaviour
{
    Carte carte;

    // se gioco 2D
    Dictionary<string, Sprite> mazzo;
    public List<Sprite> frontCarte;
    public Sprite backCarte;
    SpriteRenderer spriteRendererMazzo;
    SpriteRenderer spriteRenderScarti;

    // Use this for initialization
    void Start ()
    {
        carte = GetComponent<Carte>();
        spriteRendererMazzo = GetComponent<SpriteRenderer>();
        spriteRenderScarti = carte.area_scarto.GetComponent<SpriteRenderer>();

        mazzo = new Dictionary<string, Sprite>();
        List<Carte.Carta> listaCarte = carte.carte;
        
        // aggiungere variabile per controllo occorrenze

        for (int i = 0; i < carte.carte.Count; i++)
        {
            mazzo.Add(listaCarte[i].nome, frontCarte[i]);
        }
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public void toggleFace(bool showFace)
    {
        if (showFace)
        {
            Carte.Carta c = carte.mazzo[carte.cardIndex];
            spriteRenderScarti.sprite = mazzo[c.nome];
        } 
        else
            spriteRenderScarti.sprite = backCarte;
    }

    public void visualizzaMazzo(bool show)
    {
        if (show)
            spriteRendererMazzo.enabled = true;
        else
            spriteRendererMazzo.enabled = false;
    }

    public void visualizzaAreaScarto(bool show)
    {
        if (show)
            spriteRenderScarti.enabled = true;
        else
            spriteRenderScarti.enabled = false;
    }

    public void mostraScarto(Carte.Carta c)
    {
        spriteRenderScarti.sprite = mazzo[c.nome];
    }
}
