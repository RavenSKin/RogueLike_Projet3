﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HUD_Weapon : MonoBehaviour
{

    public Image sp_ActualWeapon;
    public Sprite img_Sword;
    public Sprite img_Dague;

    public SwitchWeapon sc_switchweapon;


    // Update is called once per frame
    void Update()
    {
        if(sc_switchweapon.b_IsWeaponActive == true)
        {
            if(sc_switchweapon.i_Item.name == "BreakSword")
            {
                sp_ActualWeapon.sprite = img_Sword;
            }
           

            if(sc_switchweapon.i_Item.name == "Dague")
            {
                sp_ActualWeapon.sprite = img_Dague;
            }

            
        }
        else{

            sp_ActualWeapon.sprite = null;
        }


        
    }
}
