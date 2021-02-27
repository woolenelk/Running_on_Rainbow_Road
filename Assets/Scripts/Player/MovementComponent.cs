using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MovementComponent : MonoBehaviour
{
    [SerializeField] private PlayerController playerController;
    [SerializeField] private float speed;
    [SerializeField] private float jumpforce;  

    private float inputValue = 0;
    private Vector3 MoveDirection = Vector3.zero;

    private Rigidbody rigidbody;

    //
    private Animator animator;
    public readonly int JumpingHash = Animator.StringToHash("IsJumping");
    private void Awake()
    {
        playerController = GetComponent<PlayerController>();
        animator = GetComponent<Animator>();
        rigidbody = GetComponent<Rigidbody>();
    }
    public void OnMovement(InputValue value)
    {
        inputValue = (float) value.Get();
        Debug.Log(value.ToString());
        
    }
    public void OnJump(InputValue value)
    {
        if (playerController.isJumping)
            return;
        playerController.isJumping = value.isPressed;
        animator.SetBool(JumpingHash, value.isPressed);
        rigidbody.AddForce((transform.up + MoveDirection) * jumpforce, ForceMode.Impulse);

    }

    private void Update()
    {
        
        if (playerController.isJumping)
            return;
        if (inputValue.Equals(0))
        {
            //realign player
            MoveDirection = Vector3.zero;
            return;
        }

        MoveDirection = transform.right * inputValue;
        Vector3 movementDir = MoveDirection * (speed * Time.deltaTime);
        transform.position += movementDir;

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.gameObject.CompareTag("Ground") && !playerController.isJumping)
            return;

        playerController.isJumping = false;
        animator.SetBool(JumpingHash, false);
    }

}
