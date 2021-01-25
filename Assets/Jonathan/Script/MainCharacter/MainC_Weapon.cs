using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainC_Weapon : MonoBehaviour
{
    public string str_ActuallWeapon = "";
    public Transform WeaponPlace;
    public int i_ActualAtt;
    public int i_ActualAttSpeed;



    public bool b_CanAttaque;
     //Définir quel est le genre d'attaque
     public bool b_CaC;
    public bool b_Dist;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKeyDown(KeyCode.K) && str_ActuallWeapon != null)
        {
            str_ActuallWeapon = "";
        }

        


    }
}
