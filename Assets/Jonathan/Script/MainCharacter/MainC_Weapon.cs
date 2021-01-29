using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainC_Weapon : MonoBehaviour
{
    public string str_ActuallWeapon = "";
    public int i_ActualAtt;
    public int i_ActualAttSpeed;
    public bool b_CanAttaque;




     public int i_BreakSword_Att;
    public int i_BreakSword_AttSpeed;

     //Donner les statistiques pour l'arme "Sword"
    protected int i_Sword_Att;
    protected int i_Sword_AttSpeed;

     //Donner les statistiques pour l'arme "HeavySword"
    protected int i_HeavySword_Att;
    protected int i_HeavySword_AttSpeed;

     //Donner les statistiques pour l'arme "Dague"
    public int i_Dague_Att;
    public int i_Dague_AttSpeed;

    protected int i_doubleDague_Att;
    protected int i_doubleDague_AttSpeed;

     public SwitchWeapon scp_switchweapon;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    protected void ChangeATT()
    {
        if(scp_switchweapon.i_Item.name == "BreakSword")
        {
            i_ActualAtt = i_BreakSword_Att;
            i_ActualAttSpeed = i_BreakSword_AttSpeed ;
        }

        if(scp_switchweapon.i_Item.name == "Sword")
        {
            i_Sword_Att = i_ActualAtt;
            i_Sword_AttSpeed = i_ActualAttSpeed;  
        }

        if(scp_switchweapon.i_Item.name == "HeavySword")
        {
            i_HeavySword_Att = i_ActualAtt;
            i_HeavySword_AttSpeed = i_ActualAttSpeed;
        }

        if(scp_switchweapon.i_Item.name == "Dague")
        {
            i_ActualAtt = i_Dague_Att ;
            i_ActualAttSpeed =  i_Dague_AttSpeed ; 
        }

        if(scp_switchweapon.i_Item.name == "DoubleDague")
        {
            i_doubleDague_Att = i_ActualAtt;
            i_doubleDague_AttSpeed = i_ActualAttSpeed;
        }

    }
}
