using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemList : MonoBehaviour
{
    public int PieceDuJoueur; 
    public GameObject Character;

    public int _price;

    void Start()
    {
        Character = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        PieceDuJoueur = Character.GetComponent<MainC_coins>().Coin;
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(PieceDuJoueur >= _price)
        {
            PieceDuJoueur = PieceDuJoueur - _price;
            gameObject.SetActive(false);
        }

        if(PieceDuJoueur < _price)
        {
            
        }
    }
}
