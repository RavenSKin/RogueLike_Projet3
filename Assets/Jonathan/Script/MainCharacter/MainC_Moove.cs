using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MainC_Moove : MonoBehaviour
{
  
   public float f_Speed;
   public SpriteRenderer Sr_sprite;
   public Sprite S_Left;
   public Sprite S_Right;
   public Sprite S_Up;
   public Sprite S_Down;

   public BoxCollider2D col_mycollider;

   public Vector2 V2_colvertical;
   public Vector2 V2_colonhorizontal;

    void Update() {

      if(Input.GetKey(KeyCode.Q))
      {
        transform.Translate(Vector2.left*f_Speed*Time.deltaTime);
        
        Sr_sprite.sprite = S_Up;
        col_mycollider.size = V2_colonhorizontal;
      }

      if(Input.GetKey(KeyCode.D))
      {
        transform.Translate(Vector2.right*f_Speed*Time.deltaTime);
        
        Sr_sprite.sprite = S_Down;
        col_mycollider.size = V2_colonhorizontal;
      }

      if(Input.GetKey(KeyCode.Z))
      {
        transform.Translate(Vector2.up*f_Speed*Time.deltaTime);
      Sr_sprite.sprite = S_Right;
      
      col_mycollider.size = V2_colvertical;
      }

      if(Input.GetKey(KeyCode.S))
      {
        transform.Translate(Vector2.down*f_Speed*Time.deltaTime);
      Sr_sprite.sprite = S_Left;
      
      col_mycollider.size = V2_colvertical;
      }
    }
}