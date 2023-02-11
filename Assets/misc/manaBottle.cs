using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manaBottle : MonoBehaviour
{
    public PlayerStats player;

    void OnTriggerEnter2D(Collider2D other)
    {
        if(Input.GetButtonDown("grappItems")){
            player.currentMana = player.currentMana + 1000000000;
            Destroy(gameObject);
        }
    }
}
