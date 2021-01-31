using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemList : MonoBehaviour
{
    public int PieceDuJoueur; 
    public GameObject Character;

    public int _price;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PieceDuJoueur = Character.GetComponent<MainC_coins>().Coin;
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(PieceDuJoueur > _price)
        {
            PieceDuJoueur = PieceDuJoueur - _price;
            gameObject.SetActive(false);
        }

        if(PieceDuJoueur < _price)
        {
            
        }
    }
}
