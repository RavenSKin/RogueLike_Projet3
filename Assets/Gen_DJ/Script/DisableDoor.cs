using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableDoor : MonoBehaviour
{
    
    public GameObject[] DoorArray;
  
    
    
    // Start is called before the first frame update
    void Start()
    {
       DoorArray = GameObject.FindGameObjectsWithTag("Door");

    }

    // Update is called once per frame
    void Update()
    {
        foreach(GameObject _door in DoorArray)
        {
            _door.SetActive(false);
        }
       
    }
}
