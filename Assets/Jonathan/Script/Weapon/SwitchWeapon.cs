using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchWeapon : MonoBehaviour
{
    public GameObject i_Item;
    public Transform Trsm_PlaceHolder;
    public bool b_IsWeaponActive;
    bool BeginTimer;
    int colNumber;
    float timer;
    private void Update()
    {
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
    }
    void Dropi_Item()
    {
        Trsm_PlaceHolder.transform.DetachChildren();
     
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (!b_IsWeaponActive)
        {
        i_Item = collision.gameObject;
        collision.gameObject.transform.position = Trsm_PlaceHolder.transform.position;
        collision.gameObject.transform.SetParent(Trsm_PlaceHolder);
        b_IsWeaponActive = true;
        }
        
        }
    void W_Time()
    {
 i_Item.GetComponent<Collider2D>().enabled = false;

        timer += Time.deltaTime;
        if (timer >= 1)
        {
            i_Item.GetComponent<Collider2D>().enabled = true;
            timer = 0;
            BeginTimer = false;
        }

       
    }
 }


