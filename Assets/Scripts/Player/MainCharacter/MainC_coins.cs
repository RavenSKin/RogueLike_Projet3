﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MainC_coins : MonoBehaviour
{
    
    public Text CoinNumber;
    public int Coin;

    public void Update() {
        //Coin Gestion
        CoinNumber.text = ""+Coin;
    }

    void OnTriggerEnter2D(Collider2D col) {
      
       if(col.gameObject)
        {

        }

        if(col.gameObject.tag =="Coin")
        {
            //Ajoute +1 à l'UI
            Coin += 1;
            //Detruit l'objet
            Destroy(col.gameObject);

        }
  }
}
