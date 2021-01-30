using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchWeapon : MonoBehaviour
{
    public GameObject LastChild;
    GameObject go_thischild;
   Transform _Parent;
    public GameObject go_PlaceOrder;
    public Transform Trsm_PlaceHolder;
    [Space]
    [Space]
    [Header("Ne pas remplir")]
    [Space]
  
    public GameObject i_Item;
    public  bool b_IsWeaponActive;
    bool BeginTimer;
    int colNumber;
    float timer;

  
    

    GameObject go_actualWeapon;

    private void Update()
    {
        _Parent = go_actualWeapon.transform.parent;
        if(_Parent == null)
        {
            go_actualWeapon.SetActive(true);
        }
        if (BeginTimer)
        {
           W_Time();
        }
        if (b_IsWeaponActive&&Input.GetKey(KeyCode.W))
        {
            b_IsWeaponActive = false;
            BeginTimer = true;
            Dropi_Item();
        }
        if (b_IsWeaponActive)
        {
            i_Item.GetComponent<Collider2D>().enabled = false;
        }


         if(Input.GetKey(KeyCode.Mouse0))
        {
            go_thischild = go_PlaceOrder.transform.GetChild(0).gameObject;
            go_thischild.SetActive(true);
            StartCoroutine(DelayAttack());
        }


    }



    void Dropi_Item()
    {
        LastChild = go_actualWeapon;
        Trsm_PlaceHolder.transform.DetachChildren();
        go_actualWeapon.GetComponent<Wpn_Orientation>().b_MakeRotation=false;
        go_actualWeapon.SetActive(true);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {

        if (!b_IsWeaponActive && collision.gameObject.tag == "Weapon")
        {
            i_Item = collision.gameObject;
            collision.gameObject.transform.position = Trsm_PlaceHolder.transform.position;
            collision.gameObject.transform.SetParent(Trsm_PlaceHolder);
            b_IsWeaponActive = true;

            go_actualWeapon = collision.gameObject;
            go_actualWeapon.GetComponent<Wpn_Orientation>().b_MakeRotation=true;

            collision.gameObject.SetActive(false);
        }
        
    }

     IEnumerator DelayAttack(){
        yield return new WaitForSeconds(1f);
        go_thischild.SetActive(false);
    }
    

    void W_Time()
    {
     i_Item.GetComponent<Collider2D>().enabled = false;

        timer += Time.deltaTime;
        if (timer >= 0.5f)
        {
            i_Item.GetComponent<Collider2D>().enabled = true;
            timer = 0;
            BeginTimer = false;
        }

       
    }
   
}


