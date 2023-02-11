using UnityEngine;

public class Timer : MonoBehaviour
{
    private float timer;
    private float waitTime = 0.5f; // Zeit in Sekunden, die gewartet werden soll
    private bool timerStarted = false;

    void Update()
    {
        if(timerStarted)
        {
            timer += Time.deltaTime;
            if(timer >= waitTime)
            {
                timerStarted = false;
                timer = 0;
                //Führe die gewünschte Aktion aus
            }
        }
    }
    public void StartTimer()
    {
        timerStarted = true;
    }

}