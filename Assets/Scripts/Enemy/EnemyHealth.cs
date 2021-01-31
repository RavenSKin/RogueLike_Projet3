using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{
    public GameObject Looting;
    
    public float MaxHealth;
    public BoxCollider2D hitBox;
    public Image _HpBar;
    GameObject Character; 
    public float Health = 8;
    public float DamageTaken;
    // Start is called before the first frame update
    void Start()
    {
        Character = GameObject.FindGameObjectWithTag("Player");
        MaxHealth = Health;
    }

    // Update is called once per frame
    void Update()
    {

        DamageTaken = Character.GetComponentInChildren<Wpn_NewSystem>().i_ActualAtt;
        if(Health <= 0)
        {
           
           
            Looting.SetActive(true);
        } 
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Damage")
        {
           // Debug.Log("TOUCH");
           
            Health = Health - DamageTaken;
            _HpBar.fillAmount -= DamageTaken / MaxHealth;
            StartCoroutine(InvincibleFrame());
            Debug.Log(DamageTaken);
        }
    }
    IEnumerator InvincibleFrame()
    {
        hitBox.enabled = false;
        yield return new WaitForSeconds(0.3f);
        hitBox.enabled = true;
    }



}
