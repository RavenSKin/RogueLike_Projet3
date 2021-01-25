using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MainC_Life : MainC_Brain
{
  public void Update() {

    if(!TakeDamage)
    {
      invicibility();
      
    }
    else
    {
      Col_mycollider.isTrigger=true;
      f_TimeInvicibility = 0;
    }

  }

  public void Die()
  {
    Destroy(gameObject);
  }

  public void OnTriggerEnter2D(Collider2D col) {
       
      if(col.gameObject)
        {
           // Debug.Log(col.gameObject.tag);
        }

        if(col.gameObject.CompareTag("Bullet") && TakeDamage && !b_protect)
        {
            //Changement de l'HUD
            Damage();

            //Detruit l'objets SI c'est une flèche
            //  Destroy(col.gameObject);
        }
        if(col.gameObject.CompareTag("Enemy") && b_protect)
        {
          //FeedBack et knockBack L'assaillant.
          //Donner un vector2 face au joueur
        }
   }
   
   void invicibility(){
     f_TimeInvicibility += Time.deltaTime ;

     Col_mycollider.isTrigger =false;

      if(f_TimeInvicibility >= f_TimeInvicibilityMAX){
        TakeDamage=true;
      }
   }
}
