using System.Security.AccessControl;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData {
    
    public int level;
    public int live;
    public int xp;

    public float[] position;

    public PlayerData(PlayerStats player, CharacterController character) {
        level = player.playerlevel;
        live = player.maxplayerlive;
        xp = player.playerxp;

        position = new float[1];
        position[0] = player.transform.position.x;
    }
    

}
