using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    public BigAkanaCard bigAkanaCard;
    public Deck TarotDeck;
    // Start is called before the first frame update
    void Start()
    {
        // bigAkanaCard= new BigAkanaCard("愚者",new string[]{"开始","自由"},Star.Uranus,Element.Wind);
        TarotDeck = new Deck();
    }

    // Update is called once per frame
    void Update()
    {
        foreach (var card in TarotDeck.BigAkanas)
        {   if (!(card == null))
        {
            Debug.Log(CardInfoTransfer.starTransfer(card.Star) );
        }
        }        
    }
}
