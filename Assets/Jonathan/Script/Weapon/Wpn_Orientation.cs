using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wpn_Orientation : MonoBehaviour
{
    public GameObject go_MainC;
    public Vector3 v3_charcterRotation;
    public bool b_MakeRotation;

    public SwitchWeapon sc_switchWeapon;




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        v3_charcterRotation = go_MainC.transform.rotation.eulerAngles ;

        if(b_MakeRotation)
        {
            RotationEnable();
        }
    }

    void OnCollisionEnter2D(Collision2D col) {

        

    }

    void RotationEnable(){

        gameObject.transform.rotation = Quaternion.Euler(v3_charcterRotation);

    }
}
