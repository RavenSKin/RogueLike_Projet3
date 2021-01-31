using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    public int PieceDuJoueur; 
    public GameObject Character;

    public List<GameObject> _ItemSlot = new List<GameObject>();
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PieceDuJoueur = Character.GetComponent<MainC_coins>().Coin;
    }
}
