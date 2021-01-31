using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Position : MonoBehaviour
{
    public GameObject Enemi_pos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Enemi_pos.transform.position;
    }
}
