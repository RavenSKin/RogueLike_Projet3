using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainC_Brain : MonoBehaviour
{
    [Space]
    [Header("Take Damage")]
    public bool TakeDamage =true;

    [Space]
    [Header("Invicibility")]
    public float f_TimeInvicibility;
    public float f_TimeInvicibilityMAX;
    public Collider2D Col_mycollider;

    [Space]
    [Header("Life")]
    //Life Gestion
    public Image Heart1;
    public Image Heart2;
    public Image Heart3;
    public int Life_Total= 60;

    [Space]
    [Header("Die")]
    public bool Died =false;


    [Space]
    [Header("Stamina")]
    public float f_StaminaMax;
    public Image Img_Stamina;
    public float f_CostStamina;
    public bool b_protect;




    [Space]
    [Header("Sprite")]
    public SpriteRenderer my_sprite;
    
    public void Damage()
    {
        if(Life_Total <= 60 && Life_Total >= 49)
        {
            Heart1.fillAmount -= 0.5f;
            TakeDamage =false;
            //Debug.Log("Heart1:" + Heart1.fillAmount);
        }
        

        if(Heart1.fillAmount <= 0 && Life_Total <= 40 && Life_Total >= 30)
        {
            Heart2.fillAmount -= 0.5f;
            TakeDamage =false;
          //  Debug.Log("Heart2:" + Heart2.fillAmount);
        }
        

        if(Heart2.fillAmount <= 0 && Life_Total <= 20 && Life_Total >= 10)
        {
            Heart3.fillAmount -= 0.5f;
            TakeDamage =false;
           // Debug.Log("Heart3:" + Heart3.fillAmount);
        }
        
        Life_Total -= 10;
        if(Heart3.fillAmount <=0)
        Died = true;
       // Debug.Log(Life_Total);
    }

    public void Stamina()
    {
        if(Input.GetKey(KeyCode.LeftShift))
        {
            Debug.Log("Protection Actif");
            
            b_protect=true;
            Img_Stamina.fillAmount -= Time.deltaTime;


        }
    }
}
