using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorHandle : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    void Start()
    {
        if (_animator == null)
        {
            _animator = GetComponent<Animator>();
        }
        
    }

   public void Playanimation(string animationName)
    {
        Debug.Log("Playing animation: " + animationName);
        _animator.CrossFade(animationName, 0.1f,1,0);
    }
   public void Playanimation(string animationName,float value)
    {
        Debug.Log("Playing animation: " + animationName);
        _animator.SetFloat(animationName,value);
    }
}
