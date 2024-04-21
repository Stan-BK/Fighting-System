using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    PlayerControl inputActions;
    Vector2 moveVector;
    CharacterController characterController;
    public Animator animator;
    NavMeshAgent navMeshAgent; 
    public Transform goal;

    private void Awake()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        characterController = GetComponent<CharacterController>();
        inputActions = new ();
        inputActions.Enable();

        inputActions.Player.Movement.performed += (e) =>
        {
            moveVector = e.ReadValue<Vector2>();
            animator.SetBool("MoveFwd", true);
        };
        inputActions.Player.Movement.canceled += (e) =>
        {
            moveVector = Vector2.zero;
            animator.SetBool("MoveFwd", false);
        };
        inputActions.Player.Attack.started += Attack;
    }

    private void FixedUpdate()
    {
        Vector3 vector3 = new Vector3(moveVector.x * Time.deltaTime * 5, 0, moveVector.y * Time.deltaTime * 5);
        characterController.Move(vector3);
        if (moveVector.x != 0 || moveVector.y != 0)
        {
            transform.forward = new Vector3(transform.forward.x + moveVector.x * Time.deltaTime * 10, 0, transform.forward.z + moveVector.y * Time.deltaTime * 10);
        }
    }

    void Attack (InputAction.CallbackContext e)
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        navMeshAgent.destination = goal.position;
    }
}