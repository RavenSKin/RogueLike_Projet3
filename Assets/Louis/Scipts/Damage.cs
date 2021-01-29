using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public GameObject player;
    public Vector3 distance;
    float speed = 2; // valeur modifiable egalement 
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        this.gameObject.transform.LookAt(player.transform);
    }

    // Update is called once per frame
    void Update()
    {
        distance  = player.transform.position - transform.position;
        StartCoroutine(DeleteSword());
    }
    IEnumerator DeleteSword()
    {
        transform.Translate(distance * speed);
        yield return new WaitForSeconds(1f);   // le temps avant que l'objet despawn est apres WaitForSeconds
        Destroy(gameObject);
    }
}