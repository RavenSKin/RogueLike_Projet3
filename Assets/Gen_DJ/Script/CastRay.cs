using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CastRay : MonoBehaviour
{

   protected int SelectSouthRoom;
   protected int SelectNorthRoom;
   protected int SelectRightRoom;
   protected int SelectLeftRoom;

    protected  int BinaryInteger;
  protected  float Range = 10;
    protected bool canBuild;
    protected bool IsCasting = true;
    protected bool StartBuilding;


   
    //              DELAY SECTION

    protected void ComputeTime()
    {
        StartCoroutine(WaitBeforeCreateOnce());
    }

    //              CAST_RAY SECTION

   protected void Cast()
    {
        if (gameObject.tag == "Top")
        {
            CastToTop();
            ComputeTime();
        }
        if (gameObject.tag == "Bot")
        {
            CastToBot();
            ComputeTime();
        }
        if (gameObject.tag == "Left")
        {
            CastToLeft();
            ComputeTime();
        }
        if (gameObject.tag == "Right")
        {
            CastToRight();
            ComputeTime();
        }
    }

   protected void CastToBot()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, Range + 4);


        if (hit.collider != null && hit.collider.tag != "Wall" && hit.collider.tag != "Door")
        {
            
        }

        //Debug.DrawLine(transform.position, new Vector2(transform.position.x, transform.position.y - (Range + 4)));
        if (hit.collider != null && hit.collider.tag == "Door")
        {
            BinaryInteger = 3;
        }
        if (hit.collider != null && hit.collider.tag == "Wall")
        {
            BinaryInteger = 2;
            canBuild = false;
            
        }
        // If it hits nothing
        if (hit.collider == null)
        {
           
            BinaryInteger = 1;
            canBuild = true;
        }
       
    }
   protected void CastToTop()
    {

        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.up, Range + 4);

        if (hit.collider != null && hit.collider.tag != "Wall" && hit.collider.tag != "Door")
        {
          
        }

        //Debug.DrawLine(transform.position, new Vector2(transform.position.x, transform.position.y + Range + 4));
        if (hit.collider != null && hit.collider.tag == "Door")
        {
            BinaryInteger = 3;
        }
        if (hit.collider != null && hit.collider.tag == "Wall")
        {
            BinaryInteger = 2;
            canBuild = false;
            
        }
        // If it hits nothing
        if (hit.collider == null)
        {
          
            BinaryInteger = 1;
            canBuild = true;
        }
       
    }
   protected void CastToRight()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.right, Range + 4);

        if (hit.collider != null && hit.collider.tag != "Wall" && hit.collider.tag != "Door")
        {
           
        }
        //Debug.DrawLine(transform.position, new Vector2(transform.position.x + Range + 1, transform.position.y));
        if (hit.collider != null && hit.collider.tag == "Door")
        {
            BinaryInteger = 3;
        }
        if (hit.collider != null && hit.collider.tag == "Wall")
        {
            BinaryInteger = 2;
            canBuild = false;

        }
        // If it hits nothing
        if (hit.collider == null)
        {
           
            BinaryInteger = 1;
            canBuild = true;
        }
       
    }
   protected void CastToLeft()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, -Vector2.right, Range + 4);

        //Debug.DrawLine(transform.position, new Vector2(transform.position.x - (Range + 4), transform.position.y));
        if (hit.collider != null && hit.collider.tag == "Door")
        {
            BinaryInteger = 3;
        }
        if (hit.collider != null && hit.collider.tag == "Wall")
        {
            BinaryInteger = 2;
            canBuild = false;
           
        }
        // If it hits nothing
        if (hit.collider == null)
        {
          
            BinaryInteger = 1;
            canBuild = true;
        }
       
    }
   
 
   
    IEnumerator WaitBeforeCreateOnce()
    {
        yield return new WaitForSeconds(0.01f);
        IsCasting = false;
        StartBuilding = true;
    }
}
