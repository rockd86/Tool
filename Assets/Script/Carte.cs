using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carte : MonoBehaviour
{
    [System.Serializable]
    public class Carta
    {
        //public Sprite spriterender;
        public string nome;
        public int[] costo;
        public int valore;
        public int[] simboli; // una carta può portarsi dietro una serie di valori non numerali di cui tenere conto (colore, seme, etc...)
        public Effetto[] effetti;
        //numero occorrenze
    }

    //public Sprite back;
    public List<Carta> carte; // le singole carte che compongono il mazzo
    public List<Carta> mazzo;
    public List<Carta> scarti;
    public int cardIndex; 
    public int n;
    public bool ordinate; // se true le carte allo Start non verranno mescolate
    //public SpriteRenderer spriteRender;

    public GameObject area_scarto;
    //public SpriteRenderer spriteRenderScarto;

    public void Start()
    {
        mazzo = creaMazzo();

        if (!ordinate)
            mischia();

        //spriteRender = GetComponent<SpriteRenderer>();
        //spriteRenderScarto = area_scarto.GetComponent<SpriteRenderer>();
    }
    
    /*
    public void toggleFace(bool showFace)
    {
        if (showFace)
            spriteRender.sprite = mazzo[cardIndex].spriterender;
        else
            spriteRender.sprite = back;
    }
    */
    public List<Carta> creaMazzo()
    {
        List<Carta> mazzoDiCarte = new List<Carta>();
        // aggiungere variabile per numero di occorrenze
        for(int i=0; i< carte.Count; i++)
        {
            mazzoDiCarte.Add(carte[i]);
            // aggiungere controllo sul numero di occorrenze
        }
        return mazzoDiCarte;
    }

    public void inserisciCarta(int index,Carta carta)
    {
        mazzo.Insert(index, carta);
    }

    // Mette la carta selezionata in cima agli scarti
    public void scartaCarta(Carta carta)
    {
        scarti.Add(carta);
    }

    // Rimuove e ritorna una carta dal mazzo (o dal mazzo degli scarti) per posizione
    public Carta estraiCarta(List<Carta> mazzo, int index)
    {
        Carta c = mazzo[index];
        mazzo.RemoveAt(index);
        return c;
    }

    // Rimescola gli scarti nel mazzo
    public void rimescolaScartiInMazzo()
    {
        foreach(Carta carta in scarti.ToArray())
        {
            Carta c = estraiCarta(scarti, 0);
            inserisciCarta(0, c);
        }

        mischia();

    }

    public void mischia()
    {
        n = mazzo.Count;

        while (n > 1)
        {
            n--;
            int k = Random.Range(0, mazzo.Count);
            Carta temp = mazzo[k];
            mazzo[k] = mazzo[n];
            mazzo[n] = temp;
        }
    }
}
