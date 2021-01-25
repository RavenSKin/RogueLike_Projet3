using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainC_Weapon : MonoBehaviour
{


    public string ActuallWeapon = "";
    public Transform WeaponPlace;
    public bool b_CanAttaque;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.K)&& ActuallWeapon != "")
        {
            ActuallWeapon = "";
        }
        /*if(input.getkeydown(keycode.k) && actuallweapon !=")
        (
            
            actuallweapon = "";
        )*/
    }
}
