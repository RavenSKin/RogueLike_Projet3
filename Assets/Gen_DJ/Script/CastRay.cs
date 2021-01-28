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
  protected  float Offset = 20;
    protected float Range; 
    protected bool canBuild;
    protected bool IsCasting = true;
    protected bool StartBuilding;
    Vector3 DebugVector;

   
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
            DebugVector = new Vector3(transform.position.x, transform.position.y + Range+8 , transform.position.z);
            CastToTop();
            Debug.DrawLine(transform.position, DebugVector, Color.red);
            ComputeTime();
        }
        if (gameObject.tag == "Bot")
        {
            DebugVector = new Vector3(transform.position.x, transform.position.y -( Range+8), transform.position.z);
            CastToBot();
            Debug.DrawLine(transform.position, DebugVector, Color.red);
            ComputeTime();
        }
        if (gameObject.tag == "Left")
        {
            DebugVector = new Vector3(transform.position.x -( Range +8), transform.position.y, transform.position.z);
            CastToLeft();
            Debug.DrawLine(transform.position,DebugVector , Color.red);
           
            ComputeTime();
        }
        if (gameObject.tag == "Right")
        {
            DebugVector = new Vector3(transform.position.x + Range+8 , transform.position.y , transform.position.z);
            CastToRight();
            
            Debug.DrawLine(transform.position, DebugVector, Color.red);
            ComputeTime();
        }
    }

   protected void CastToBot()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, Range +8);
        

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

        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.up, Range +8);
       
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
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.right, Range+8 );
       
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
        RaycastHit2D hit = Physics2D.Raycast(transform.position, -Vector2.right, Range +8);
        
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
