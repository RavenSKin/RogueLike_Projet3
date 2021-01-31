using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Looting : MonoBehaviour

{
    [Space]
    [Space]
    [Header("Potion , Coin , Nothing")] 
    public int[] Pourcentage =
        {
        10, // Potion
        30, // Coin
     60 // Nothing
    };

    [Space]
    [Space]
    [Header("Liste des Loots")]
    public List<GameObject> _Loot = new List<GameObject>();

    [Space]
    [Space]
    [Header("To disable")] 
    public GameObject[] EnemiStuff;
   
   
   
  
   
     int Result; 
     int DiceRoll;
    // Start is called before the first frame update
    void Start()
    {
        foreach (GameObject _stuff in EnemiStuff)
        {
            _stuff.SetActive(false);
        }
        LootSystem();
        
    }

  
    void LootSystem()
    {
        foreach(int item in Pourcentage)
        {
            Result += item; // fait le calcul pour en tirer un maximum
        }
        DiceRoll = Random.Range(0, Result); // choisi un nombre entre 0 et le maximum
      for (int i = 0; i < Pourcentage.Length; i++)
        {
            if (DiceRoll <= Pourcentage[i])
            {
                _Loot[i].SetActive(true);   // si le nombre choisi aleatoirement est < au nombre dans la liste , choisir ce nombre
                return;
            }
            else
            {
                DiceRoll -= Pourcentage[i];    // sinon revenir en arriere
            }
        }
    }
    
}
