using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchWeapon : MonoBehaviour
{
    public Animator _anim;
    public GameObject Sword_Collider;
    public GameObject Daguer_Collider;
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

    private void Start()
    {
        i_Item = null;
    }
    private void Update()
    {
        if (b_IsWeaponActive)
        {
            go_actualWeapon.SetActive(false);
        }


        if (b_IsWeaponActive&&Input.GetKey(KeyCode.W))
        {
            b_IsWeaponActive = false;
            //BeginTimer = true;
            Dropi_Item();
            _anim.SetBool("Sword", false);
            _anim.SetBool("Daguer", false);
        }
     


         if(Input.GetKey(KeyCode.Mouse0))
        {
          
            if(i_Item.name == "BreakSword"&&b_IsWeaponActive)
            {
               
                _anim.SetBool("Sword", true);
                _anim.SetBool("Daguer", false);
            }
            if (i_Item.name == "Dague" && b_IsWeaponActive)
            {
               
                _anim.SetBool("Sword", false);
                _anim.SetBool("Daguer", true);
            }
        
        }


    }



    void Dropi_Item()
    {
        LastChild = go_actualWeapon;
        Trsm_PlaceHolder.transform.DetachChildren();
        LastChild.transform.position = Trsm_PlaceHolder.transform.position;
        LastChild.SetActive(true);
        StartCoroutine(WaitToTake());

    }

    public void OnTriggerEnter2D(Collider2D collision)
    {

        if (!b_IsWeaponActive && collision.gameObject.tag == "Weapon")
        {
            b_IsWeaponActive = true;
            i_Item = collision.gameObject;
            go_actualWeapon = collision.gameObject;
            collision.gameObject.SetActive(false);

            
        }
        
    }
    IEnumerator WaitToTake()
    {
        i_Item.GetComponent<Collider2D>().enabled = false;
        yield return new WaitForSeconds(1f);
        i_Item.GetComponent<Collider2D>().enabled = true;
    }
  


}
   



