using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSelector : MonoBehaviour
{
    int Rand_Selector;
    public List<GameObject> Weapon = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        Rand_Selector = Random.Range(0, Weapon.Count);
        Weapon[Rand_Selector].SetActive(true);
    }

  
}
