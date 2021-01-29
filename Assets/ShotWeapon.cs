using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotWeapon : MonoBehaviour
{
    public GameObject Instance;
    public GameObject PLaceHolder;
    public GameObject Player;
    float speed = 2; // valeur modifiable egalement 
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");

    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < 1; i++)
        {
           Instance= Instantiate(Instance, PLaceHolder.transform.position, Quaternion.identity);
            Instance.transform.LookAt(Player.transform);
            
        }

    }
    
}
