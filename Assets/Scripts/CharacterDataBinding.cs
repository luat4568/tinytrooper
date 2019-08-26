﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterDataBinding : MonoBehaviour
{
    public float SpeedMove
    {
        set
        {
            animator.SetFloat(key_Speed, value);
        }
    }
    public Vector2 MoveDir
    {
        set
        {
            animator.SetFloat(key_x, value.x);
            animator.SetFloat(key_y, value.y);
        }
    }
   
    private Animator animator;
    private int key_Speed;
    private int key_x;
    private int key_y;
    // Start is called before the first frame update
    void Awake()
    {
        animator = GetComponent<Animator>();
        key_Speed = Animator.StringToHash("Speed");
        key_x = Animator.StringToHash("X");
        key_y = Animator.StringToHash("Y");
    }

    public void ChangeGunAnim(AnimatorOverrideController animatorOverrideController)
    {
        animator.runtimeAnimatorController = animatorOverrideController;
    }
}
