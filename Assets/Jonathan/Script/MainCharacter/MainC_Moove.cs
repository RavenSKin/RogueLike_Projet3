using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MainC_Moove : MonoBehaviour
{
   public GameObject go_sprite;
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
        col_mycollider.size = V2_colonhorizontal;
        go_sprite.transform.rotation = Quaternion.Euler(0,0,-90);
      }

      if(Input.GetKey(KeyCode.D))
      {
        transform.Translate(Vector2.right*f_Speed*Time.deltaTime);
        col_mycollider.size = V2_colonhorizontal;
        go_sprite.transform.rotation = Quaternion.Euler(0,0,90);
      }

      if(Input.GetKey(KeyCode.Z))
      {
        transform.Translate(Vector2.up*f_Speed*Time.deltaTime);
        col_mycollider.size = V2_colvertical;
        go_sprite.transform.rotation = Quaternion.Euler(0,0,180);
      }

      if(Input.GetKey(KeyCode.S))
      {
        transform.Translate(Vector2.down*f_Speed*Time.deltaTime);
        col_mycollider.size = V2_colvertical;
        go_sprite.transform.rotation = Quaternion.Euler(0,0,0);
      }
    }
}