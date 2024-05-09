using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class PlayerController : MonoBehaviour
{
     [SerializeField] AnimatorHandle _animatorHandle;
     [SerializeField] Mover _mover;
    void Start()
    {
        InitializedAction();
    }

    private void InitializedAction()
    {
        _mover.OnActionTriggered += PlayAnimation;
    }

    private void PlayAnimation(string nameAnimation,float value)
    {
        _animatorHandle.Playanimation(nameAnimation,value);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
