using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullets : MonoBehaviour
{

    public float flytime = 3;
    public int thedamage = 20; 
    public float speed = 20f;
    public Rigidbody2D rb;

    public int manacost = 20;
  
    void Start() {
        rb.velocity = transform.right * speed;
    }

    
    void OnTriggerEnter2D(Collider2D hitInfo) {
        Enemy enemy = hitInfo.GetComponent<Enemy>();
            if (enemy != null) {
                enemy.TakeDamage(thedamage);
            }
        
        //Instantiate(impactEffect, transform.position, transform.rotation);
        
        Destroy(gameObject);
    }

    void Update()
    {
        flytime -= Time.deltaTime;
        if (flytime <= 0 ){
            Destroy(gameObject);
        }
    }

    

  
}
