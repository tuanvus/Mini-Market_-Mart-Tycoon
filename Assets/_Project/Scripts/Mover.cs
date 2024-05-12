using System;
using System.Collections;
using System.Collections.Generic;
using NaughtyAttributes;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public Action<string,float> OnActionTriggered;
    [SerializeField,AnimatorParam] string moveParam;
    [SerializeField,AnimatorName] string moveAnimation;
    [SerializeField,AnimatorName] string idleAnimation;
    
    public Joystick joystick; // Reference to the joystick UI element
    public UnityEngine.AI.NavMeshAgent agent; // Reference to the NavMeshAgent component attached to your character
    public float speed = 5.0f;
    public bool isMoving = false;
 
    
    private void Start()
    {
       // agent.speed = speed;
    }

    void Update()
    {
        // Get the input direction from the joystick
        Vector2 inputDirection = new Vector2(joystick.Horizontal, joystick.Vertical);

        if (inputDirection.magnitude > 0.1f)
        {
            if (!isMoving)
            {
                OnActionTriggered?.Invoke(moveParam,inputDirection.magnitude);
            }
            isMoving = true;
            // Convert input direction to world space
            Vector3 moveDirection = new Vector3(inputDirection.x, 0, inputDirection.y).normalized;

            // Set the destination for NavMeshAgent
            Vector3 destination = transform.position + moveDirection;
            transform.LookAt(destination);
            transform.Translate(moveDirection * speed * Time.deltaTime, Space.World);

            // // Check if the destination is on NavMesh
            // UnityEngine.AI.NavMeshHit hit;
            // if (UnityEngine.AI.NavMesh.SamplePosition(destination, out hit, 1.0f, UnityEngine.AI.NavMesh.AllAreas))
            // {
            //     // Set the destination for NavMeshAgent
            //     agent.SetDestination(hit.position);
            // }
        }
        else
        {
            if (isMoving)
            {
                OnActionTriggered?.Invoke(moveParam,inputDirection.magnitude);
            }
            isMoving = false;
        }
        
        
        
    }
}
