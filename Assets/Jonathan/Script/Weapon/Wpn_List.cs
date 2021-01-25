using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wpn_List : MainC_Weapon
{


    //Donner les statistiques pour l'arme "SmallSword"
    public int i_SmallSword_Att;
    public int i_SamllSword_AttSpeed;
    public GameObject gm_BrokenSword;

     //Donner les statistiques pour l'arme "Sword"
    public int i_Sword_Att;
    public int i_Sword_AttSpeed;
    public GameObject gm_Sword;

     //Donner les statistiques pour l'arme "HeavySword"
    public int i_HeavySword_Att;
    public int i_HeavySword_AttSpeed;
    public GameObject gm_HeavySword;

     //Donner les statistiques pour l'arme "Dague"
    public int i_Dague_Att;
    public int i_Dague_AttSpeed;
    public GameObject gm_Dague;

    public int i_doubleDague_Att;
    public int i_doubleDague_AttSpeed;
    public GameObject gm_DoubleDague;

    public void Update() {
        
        if(str_ActuallWeapon == "")
        {
            i_ActualAtt = 1;
            i_ActualAttSpeed = 1;
            gm_DoubleDague.SetActive(false);
            gm_Dague.SetActive(false);
            gm_HeavySword.SetActive(false);
            gm_Sword.SetActive(false);
            gm_BrokenSword.SetActive(false);

            
        }
    }

    public void OnTriggerEnter2D(Collider2D col) {
        //le nom de l'arme == Armes dans ma liste && que je n'ai rien dans mes mains ->MainC_Wepaon
        //L'armes au sol devien mon arme
        //MainC_Weapon != null
        
        

        if(col.gameObject.name == "Sword" && str_ActuallWeapon == "")
        {   
            Debug.Log(col.gameObject.name);
            i_ActualAtt = i_Sword_Att;
            i_ActualAttSpeed = i_Sword_AttSpeed;
            gm_Sword.SetActive(true);
            gm_DoubleDague.SetActive(false);
            gm_Dague.SetActive(false);
            gm_HeavySword.SetActive(false);
            gm_BrokenSword.SetActive(false);
            str_ActuallWeapon = "Sword";
        }

        if(col.gameObject.name == "Dague" && str_ActuallWeapon == "")
        {
            Debug.Log(col.gameObject.name);
            i_ActualAtt = i_Dague_Att;
            i_ActualAttSpeed = i_Dague_AttSpeed;
            gm_Dague.SetActive(true);
            gm_DoubleDague.SetActive(false);
            gm_HeavySword.SetActive(false);
            gm_Sword.SetActive(false);
            gm_BrokenSword.SetActive(false);
            str_ActuallWeapon = "Dague";
        }

        if(col.gameObject.name == "HeavySword" && str_ActuallWeapon == "")
        {
            Debug.Log(col.gameObject.name);
            i_ActualAtt =  i_HeavySword_Att;
            i_ActualAttSpeed = i_HeavySword_AttSpeed;
             gm_DoubleDague.SetActive(false);
            gm_Dague.SetActive(false);
            gm_HeavySword.SetActive(true);
            gm_Sword.SetActive(false);
            gm_BrokenSword.SetActive(false);
            str_ActuallWeapon = "HeavySword";
        }

        if(col.gameObject.name == "BrokenSword" && str_ActuallWeapon == "")
        {
            Debug.Log(col.gameObject.name);
            i_ActualAtt = i_SmallSword_Att;
            i_ActualAttSpeed =i_SamllSword_AttSpeed;
             gm_DoubleDague.SetActive(false);
            gm_Dague.SetActive(false);
            gm_HeavySword.SetActive(false);
            gm_Sword.SetActive(false);
            gm_BrokenSword.SetActive(true);
            str_ActuallWeapon = "BrokenSword";
        }

    }

}
