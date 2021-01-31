using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableChild : MonoBehaviour
{
   public void EnableTheChild()
    {
        this.gameObject.transform.GetChild(0).GetComponent<GameObject>().SetActive(true);
    }
}
