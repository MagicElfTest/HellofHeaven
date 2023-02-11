using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class AFKChecker : MonoBehaviour
{
    public float idleTime = 10f; // Zeit in Sekunden, nach der der Spieler als AFK gilt
    private float lastInputTime;
    private Animator animator;
    private bool isAFK;
    private Vector3 previousPosition;

    void Start()
    {
        animator = GetComponent<Animator>();
        lastInputTime = Time.time;
        previousPosition = transform.position;
    }

    void FixedUpdate()
    {
        if (Time.time - lastInputTime > idleTime)
        {
            if (!isAFK)
            {
                isAFK = true;
                animator.SetTrigger("Afk1");
            }
        }
        else
        {
            isAFK = false;
            animator.ResetTrigger("Afk1");
            animator.ResetTrigger("Afk2");
        }

        if (Input.anyKey || Input.anyKeyDown || Input.GetButtonDown("Jump") || transform.position != previousPosition)
        {
            lastInputTime = Time.time;
            previousPosition = transform.position;
            if (Input.GetButtonDown("Jump")) {
                Debug.Log("Is Jumping");
            }
        }
    }
        
    
}
