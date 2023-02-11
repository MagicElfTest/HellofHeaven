using System.Xml;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


[System.Serializable]
public class PlayerStats : MonoBehaviour
{
    public PlayerMovement mov;
    public bool noMana;
    public int maxplayerlive = 300;
    public int playerlevel = 1;
    public int playerxp = 0;
    public int currenthealth;
    public bool damageIsTaken;
    public double regenpoints = 1;

    public int xpforlevelup = 100;

    public double currentMana;

    public double maxMana = 200;

    public double manaregen = 5;

    public int SkillPoint;
    
    //Base Stats
    public double speed = 60;
    
    
    //Mods
    public double modMana = 0;
    public double modhealth = 0;
    public double modreg = 0;
    public double modspeed = 0;
    public double cmodritdam = 0;
    public double modcritrate = 0;
    public double modmanareg = 0;
    public double modDam = 0;
    public double moddef = 0;


    public double regenerationSpeed = 14;

    public HealthBar healthBar;

    public ManaBar manaBar;

    public void Start()
    {

        speed = modspeed + mov.runSpeed; 

        currenthealth = maxplayerlive;
        healthBar.SetMaxHealth(maxplayerlive);
    
        currentMana = maxMana;

        manaBar.SetMaxMana((int)maxMana); 
    
    }

    public void Update()
    {
        

        if (playerxp >= xpforlevelup) {
            
            if (playerxp > xpforlevelup) {
                playerxp = playerxp - xpforlevelup;
            }

            playerlevel = playerlevel + 1;
            xpforlevelup = xpforlevelup * 3/2;
            
            SkillPoint = SkillPoint + 1;

           
        }

        //manaregeration
        currentMana =   Time.deltaTime * regenerationSpeed + currentMana > maxMana ? 
                        maxMana : Time.deltaTime * regenerationSpeed  + currentMana;
        manaBar.SetMana((int)currentMana);
    }

    

    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Enemy") {
            TakeDamage(20);
        }
    }


    public void TakeDamage(int damage)
    {
        currenthealth -= damage;

        healthBar.SetHealth(currenthealth);
    }

    public bool UseMana(int losemana){
        if(currentMana < losemana) return false;
        currentMana -= losemana;
        manaBar.SetMana((int)currentMana);
        return true;
    }

}