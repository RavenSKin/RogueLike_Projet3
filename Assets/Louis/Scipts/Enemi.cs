using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemi : MonoBehaviour
{
    public Transform player;

    Vector3 ModifScale;
    Vector3 NormalScale;

    public float speed;
    public float stoppingDistance;
    public float retreatDistance;

    public GameObject _Instance;
    public GameObject _PlaceHolder;
    public BoxCollider2D _Damages;
    public Animator _anim;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        ModifScale = new Vector3(1.1f, 1.1f, 1.1f);
        NormalScale = new Vector3(1f, 1f , 1f);

    }

    // Update is called once per frame
    void Update()
    {
        if(Vector2.Distance(transform.position, player.position) > stoppingDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
        } 
        else if(Vector2.Distance(transform.position, player.position) < stoppingDistance && Vector2.Distance(transform.position, player.position) > retreatDistance)
        {
            transform.position = this.transform.position;
            StartCoroutine(Attack());
        }     
    }

    IEnumerator Attack()
    {
        transform.localScale = ModifScale;
        yield return new WaitForSeconds(0.4f);
        transform.localScale = NormalScale;
        yield return new WaitForSeconds(0.1f);

        _anim.SetBool("IsAttacking", true);
        _Damages.enabled = true;
    }

    public void DisableAttack()
    {
        _Damages.enabled = false;
    }
}
