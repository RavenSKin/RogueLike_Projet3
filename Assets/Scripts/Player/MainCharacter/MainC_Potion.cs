using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainC_Potion : MonoBehaviour
{
    public Text PotionNumber;
    public int Potion;
    int _cost;
    int currentMoney;
    public void Update() {
        //Potion Gestion
        PotionNumber.text = ""+Potion;
        currentMoney = gameObject.GetComponent<MainC_coins>().Coin;
    }

    void OnTriggerEnter2D(Collider2D col) {
        
        if(col.gameObject)
        {

        }

        if(col.gameObject.tag == "Potion")
        {
           _cost =  col.gameObject.GetComponent<PotionCost>().Cost;
            if (_cost <= currentMoney)
            {
                gameObject.GetComponent<MainC_coins>().Coin = currentMoney - _cost;
                //Ajoute +1 à l'UI
                Potion += 1;

                //Detruit l'objet
                Destroy(col.gameObject);
            }

        }
    }
       
      
   
}
