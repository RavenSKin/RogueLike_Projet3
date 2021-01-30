using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{
    public float MaxHealth;
    public BoxCollider2D hitBox;
    public Image _HpBar;
    public GameObject Character; 
    public float Health = 8;
    public float DamageTaken;
    // Start is called before the first frame update
    void Start()
    {
        MaxHealth = Health;
    }

    // Update is called once per frame
    void Update()
    {
        
         DamageTaken = Character.GetComponent<Wpn_NewSystem>().i_ActualAtt;
        if(Health <= 0)
        {
            gameObject.SetActive(false);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Damage")
        {
            Health = Health - DamageTaken;
            _HpBar.fillAmount -= DamageTaken / MaxHealth;
            StartCoroutine(InvincibleFrame());
        }
    }
    IEnumerator InvincibleFrame()
    {
        hitBox.enabled = false;
        yield return new WaitForSeconds(0.3f);
        hitBox.enabled = true;
    }



}
