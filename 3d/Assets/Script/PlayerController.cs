using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    public float speedRotate;
    public float forceJump;
    public Rigidbody rigidBody;
    public bool isJump;
    public bool isGrounded;
    private Animator animator;
    private float x, y;
    
    // Start is called before the first frame update
    void Start()
    {
        isJump = false;
        animator = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        transform.Rotate(0, x * Time.deltaTime * speedRotate, 0);
        transform.Translate(0, 0, y * Time.deltaTime * moveSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");

        animator.SetFloat("Xspeed", x);
        animator.SetFloat("Yspeed", y);

        if(isJump)
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                animator.SetBool("IsJumping", true);
                rigidBody.AddForce(new Vector3(0,forceJump,0),ForceMode.Impulse);
            }

            animator.SetBool("IsGrounded", true);
        }
        else
        {
            Falling();
        }
    }

    public void Falling()
    {
        animator.SetBool("IsGrounded", false);
        animator.SetBool("IsJumping", false);
    }
}
