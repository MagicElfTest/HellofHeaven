using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuiController : MonoBehaviour
{
    public PlayerStats player;


    public SkillMenu skill;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Skill1() {
        Debug.Log("Da ist was passiert!");
        player.moddef += 5;
        player.modDam += 5; 
    }

    // Update is called once per frame
    void Update()
    {
        
       if(Input.GetButtonDown("OpenSkillMenu"))
        {
            
            if (!skill.gameObject.active)
            {
                
               skill.gameObject.SetActive(true);
            }else{
                skill.gameObject.SetActive(false);
            }
            


        }
    }
}
