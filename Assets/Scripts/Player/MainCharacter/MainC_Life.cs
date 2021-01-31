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
       
     if(col.gameObject.tag =="Bullet")
     {
       Damage();
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
