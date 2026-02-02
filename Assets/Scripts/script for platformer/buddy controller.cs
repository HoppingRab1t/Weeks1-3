using UnityEngine;

public class buddycontroller : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rigidbody;
    public Animator animator;
    public SpriteRenderer spriteRenderer;

    private float Inputx;
    private bool jumpPressed;
    private bool isGrounded;
    private float facing = 1;
    public float movingSpeed = 5;
    public float jumpForce = 5;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Transform groundCheckPos;
    private float groundcCheckLength = 0.25f;
    public LayerMask groundCheckLayerMask;
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Inputx = Input.GetAxisRaw("Horizontal");
        if (Inputx > 0)
        {
            facing = 1;
        }
        else if (Inputx < 0)
        {
            facing = -1;
        }
        if (facing < 0.01)
        {
            spriteRenderer.flipX = true;
        } else if (facing > 0.01){
            spriteRenderer.flipX = false ;

        }
        if (animator)
        {
            animator.SetFloat("moveX",Mathf.Abs(rigidbody.linearVelocityX));
            animator.SetBool("isJumping",!isGrounded );
        }
        RaycastHit2D hit = Physics2D.Raycast(groundCheckPos.position, Vector2.down, groundcCheckLength, groundCheckLayerMask);
        if (hit.collider != null)
        {
            isGrounded = true;
        }
        else
        {
            isGrounded= false;  
        }
        if (Input.GetButtonDown("jump")&& isGrounded )
        {
            rigidbody.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }
}
