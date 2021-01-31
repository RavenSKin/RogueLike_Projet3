using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Potion_Healing : MonoBehaviour
{
    public int i_RegenLife;
    public MainC_Life sc_brain;
    public MainC_Potion sc_potion;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(sc_potion.Potion >= 1 && Input.GetKey(KeyCode.Mouse1) && sc_brain.Life_Total < 60)
        {
            RegenLife();
        }
        
    }


    void RegenLife()
    {

        if(sc_brain.Heart1.fillAmount <1 && sc_brain.Heart2.fillAmount >=1)
        {
            sc_brain.Heart1.fillAmount += 0.5f;
            sc_brain.Life_Total += 10;
            sc_potion.Potion -=1;
            Debug.Log("Add Life 1");
        }

        if(sc_brain.Heart2.fillAmount <1 && sc_brain.Heart3.fillAmount >=1)
        {
            sc_brain.Heart2.fillAmount += 0.5f;
            sc_brain.Life_Total += 10; 
            sc_potion.Potion -=1;
            Debug.Log("Add Life 2");
        }

        if(sc_brain.Heart3.fillAmount <1 && sc_brain.Heart2.fillAmount <1)
        {
            sc_brain.Heart3.fillAmount += 0.5f;
            sc_brain.Life_Total += 10;
            sc_potion.Potion -=1;
            Debug.Log("Add Life 3");
        }


    }
}
