using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wpn_Touch : MonoBehaviour
{

    public GameObject go_thischild;
    public GameObject go_PlaceOrder;


 

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKey(KeyCode.Mouse0))
        {
            go_thischild = go_PlaceOrder.transform.GetChild(0).gameObject;
            go_thischild.SetActive(true);
            StartCoroutine(DelayAttack());
        }



    }

    IEnumerator DelayAttack(){
        yield return new WaitForSeconds(1f);
        go_thischild.SetActive(false);
    }

    void OnCollisionEnter2D(Collision2D other) {
        

    }
}
