using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public GameObject Character; 
    public int Health = 8;
    int DamageTaken;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         DamageTaken = Character.GetComponent<Wpn_NewSystem>().i_ActualAtt;
        if(Health <= 0)
        {
            gameObject.SetActive(false);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
       
        Health = Health - DamageTaken;
    }



}
