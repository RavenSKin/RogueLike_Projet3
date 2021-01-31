using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiBehavior : MonoBehaviour
{
    public float Attack_Cooldown;
    public Transform player;
    public GameObject Enemy;
    public GameObject Col_Sword;

    public float speed;
    public float stoppingDistance;
    public float retreatDistance;
    Vector3 distance;
    bool attack;
    bool CanAttack = true;
    public Animator _anim;
    
    // Start is called before the first frame update
    void Start()
    {

        player = GameObject.FindGameObjectWithTag("Player").transform;
       

    }

    // Update is called once per frame
    void Update()
    {
       
        distance = player.position - transform.position;
        var relativePos = player.position - transform.position;
        var angle = Mathf.Atan2(-relativePos.y, -relativePos.x) * Mathf.Rad2Deg;
        var rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = rotation;
        Enemy.transform.position = Vector2.MoveTowards(Enemy.transform.position, player.position, speed * Time.deltaTime);

        if (Vector2.Distance(transform.position, player.position) < stoppingDistance)
        {
            speed = 0;
            if (CanAttack)
            {
                _anim.SetBool("IsAttacking", true);
                
            }
        }
       
    }

 public void EnableCollider()
    {
        Col_Sword.GetComponent<BoxCollider2D>().enabled = true;
    }
    public void DisableCollider()
    {
        _anim.SetBool("IsAttacking", false);
        Col_Sword.GetComponent<BoxCollider2D>().enabled = false;
        CanAttack = false;
        StartCoroutine(Cooldown());
    }
    IEnumerator Cooldown()
    {
       
        yield return new WaitForSeconds(Attack_Cooldown);
        speed = 2;
        CanAttack = true;
    }
}
