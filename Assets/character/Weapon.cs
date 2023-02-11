using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class Weapon : MonoBehaviour
{
    
    public Transform firepoint;
    public GameObject spellPrefab;

   

    public PlayerStats player;

    public float time;
    public int mana;

    public int weapon = 1;

    // Update is called once per frame
    void Update() {

       

        mana = (int)player.currentMana;
        
        if (Input.GetButtonDown("Fire1") && weapon == 1) {
            if(player.UseMana(20)) {
                Shoot();
            }
        }

        if (Input.GetButton("Fire2")){
            weapon ++;
        }
            
       
        
        if (player.currentMana < player.maxMana) {
          
        }
    }

    void Shoot () {
        Instantiate(spellPrefab, firepoint.position, firepoint.rotation);
        //player.UseMana(manaloos);
    }
}
