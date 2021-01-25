using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wpn_List : MainC_Weapon
{

    public string SmallSword;
    public int i_Stats_Attaque;
    public int i_Stats_AttaqueSpeed;

    public void Start() {
        SmallSword ="Epee courte";
        

    }

    public void OnTriggerEnter2D(Collider2D col) {
        //le nom de l'arme == Armes dans ma liste && que je n'ai rien dans mes mains ->MainC_Wepaon
        //L'armes au sol devien mon arme
        //MainC_Weapon != null
        
        if(col.gameObject.name == "Epee courte" && MyWeapon == "" && Input.GetKey(KeyCode.K))
        {   
            //MainC_Weapons.MyWeapon == Epee courte

        }

    }

}
