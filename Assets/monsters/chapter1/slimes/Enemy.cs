using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class Enemy : MonoBehaviour
{
        public int maxslimelive = 100;
        public int slimelevel = 1;
        public int currenthealth;

        public int minSlimeXpDrop = 70;

        public int maxSlimeXpDrop = 99;

        public  int min;

        public int max;

        public PlayerStats player;





    
        
        void Start() {
            currenthealth = maxslimelive;
            
        } 

        public void TakeDamage(int damage){
                currenthealth  -= damage;
                if(currenthealth <= 0){
                    Destroy(gameObject);
                    getXp();
                }
        
           
        }

        public void slimexp(double minimalXp, double maximalXp) {
                
                minimalXp = slimelevel * 3/2 + minSlimeXpDrop;


                maximalXp = player.playerlevel  * 2/1 + maxSlimeXpDrop;

                minimalXp = min;
                maximalXp = max;
                Debug.Log(minimalXp + maximalXp);

            } 

            void getXp(){
                int Xp = Random.Range(minSlimeXpDrop, maxSlimeXpDrop);
                Debug.Log(Xp);

                player.playerxp = player.playerxp + Xp;

            }
}
