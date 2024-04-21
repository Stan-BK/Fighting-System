using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    PlayerControl inputActions;
    Vector2 moveVector;
    public Animator animator;
    NavMeshAgent navMeshAgent; 
    public Transform goal;
    public int speed = 10;

    private void Awake()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
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
        Vector3 vector3 = new Vector3(moveVector.x * speed, 0, moveVector.y * speed);
        navMeshAgent.velocity = vector3;
        //characterController.Move(vector3);
        if (moveVector.x != 0 || moveVector.y != 0)
        {
            transform.forward = new Vector3(transform.forward.x + moveVector.x * Time.deltaTime * 10, 0, transform.forward.z + moveVector.y * Time.deltaTime * 10);
        }
    }

    void Attack (InputAction.CallbackContext e)
    {

    }
}