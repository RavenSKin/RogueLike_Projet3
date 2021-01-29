using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainC_Potion : MonoBehaviour
{
    public Text PotionNumber;
    public int Potion;

    public void Update() {
        //Potion Gestion
        PotionNumber.text = ""+Potion;
    }

    void OnTriggerEnter2D(Collider2D col) {
        
        if(col.gameObject)
        {
            Debug.Log(col.gameObject.name);
        }

        if(col.gameObject.tag == "Potion")
        {
            //Ajoute +1 à l'UI
            Potion += 1;
            //Detruit l'objet
            Destroy(col.gameObject);

        }
    }
       
      
   
}
