using System.Collections;
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

    private void OnTriggerEnter2D(Collider2D col) {
       
      if(col.gameObject)
        {
            Debug.Log(col.gameObject.name);
        }

        if(col.gameObject.CompareTag("Coin"))
        {
            //Ajoute +1 à l'UI
            Coin =+ 1;
            //Detruit l'objet
            Destroy(col.gameObject);

            //private void (faut que ça marche){
            //    if marche pas then marche stp
            //}
        }
   }
}
