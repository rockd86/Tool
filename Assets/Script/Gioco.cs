using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gioco : MonoBehaviour
{
    string nome;
    int nGiocatori;
    public List<Carte> mazziDelGioco;
    // inserire lista turni
    
    Carte mazzo;
    CarteView mazzoView;
    int cardIndex = 0;

    public GameObject carte;

	// Use this for initialization
	void Start()
    {
        mazzo = carte.GetComponent<Carte>();
        mazzoView = carte.GetComponent<CarteView>();
    }
	
	void OnGUI ()
    {
		if(GUI.Button(new Rect(10,10,100,28), "Mostra"))
        {
            /*if (mazzo.mazzo.Count == 0)
            {

                //mazzo.toggleFace(false);
                //mazzo.mischia();
            }
            else*/
            {
                //mazzoView.toggleFace(true);

                if (mazzo.mazzo.Count > 0)
                {
                    Carte.Carta c = mazzo.estraiCarta(mazzo.mazzo, 0);
                    mazzo.scartaCarta(c); //estrae la prima carta del mazzo
                    mazzoView.mostraScarto(c);
                }

                mazzoView.visualizzaAreaScarto(true);

                if (mazzo.mazzo.Count == 0)
                    mazzoView.visualizzaMazzo(false);

            }

            //cardIndex++;
        }

        if(GUI.Button(new Rect(120, 10, 100, 28), "Rimescola"))
        {
            mazzo.rimescolaScartiInMazzo();
            mazzoView.visualizzaMazzo(true);
            mazzoView.visualizzaAreaScarto(false);
        }
    }

}

