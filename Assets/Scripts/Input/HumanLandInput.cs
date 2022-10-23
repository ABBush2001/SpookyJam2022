using System;
using System.Collections;
using System.Collections.Generic;
//using UnityEditor.Tilemaps;
using UnityEngine;
using UnityEngine.InputSystem;

public class HumanLandInput : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] Transform groundCheck;
    [SerializeField] LayerMask groundLayer;

    bool isFacingRight = true;
    PlayerInput playerinput;
    public Animator animator;

    void Start()
    {
        playerinput = GameObject.Find("InputManager").GetComponent<PlayerInput>();    
    }

    void Update()
    {
        if(DialogueManager.GetInstance().dialogueIsPlaying)
        {
            return;
        }

        Movement();    
    }

    void Movement()
    {
        transform.Translate(Mathf.Abs(playerinput.actions["Move"].ReadValue<float>()) * speed * Time.deltaTime, 0, 0);

        animator.SetFloat("Speed", Mathf.Abs(playerinput.actions["Move"].ReadValue<float>()) * speed * Time.deltaTime, 0, 0);

        if(playerinput.actions["Move"].ReadValue<float>() > 0 && !isFacingRight)
        {
            Flip();
        }
        else if(playerinput.actions["Move"].ReadValue<float>() < 0 && isFacingRight)
        {
            Flip();
        }
    }

    void Flip()
    {
        isFacingRight = !isFacingRight;
        transform.Rotate(0f, 180f, 0f);
    }
}
