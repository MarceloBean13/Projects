using UnityEngine;

public class Player_Controller2D : MonoBehaviour
{
    Animator animator;
    Rigidbody2D rb2d;
    SpriteRenderer sprite_Renderer;
    private bool _grounded;

    [Header("Movement Settings")]
    public float playerSpeed;
    public float jumpSpeed;

    [Header("Ground Check")]
    public float overlapOffset;
    public Vector2 overlapBoxSize;
    public LayerMask groundLayer;
    void Start()
    {
        animator = GetComponent<Animator>();
        rb2d = GetComponent<Rigidbody2D>();
        sprite_Renderer = GetComponent<SpriteRenderer>();
    }
    private void Update()
    {
        _grounded = CheckGround();
    }
    void FixedUpdate()
    {

        if (Input.GetKey("d") || Input.GetKey("right"))
        {
            rb2d.velocity = new Vector2(playerSpeed, rb2d.velocity.y);
            if (_grounded)
            {
                animator.Play("player_run");
                rb2d.velocity = new Vector2(playerSpeed, rb2d.velocity.y);
            }
            else
            {
                rb2d.velocity = new Vector2(playerSpeed * 0.75f, rb2d.velocity.y);;
            }
            sprite_Renderer.flipX = false;
        }
        else if (Input.GetKey("a") || Input.GetKey("left"))
        {

            if (_grounded)
            {
                rb2d.velocity = new Vector2(-playerSpeed, rb2d.velocity.y);
                animator.Play("player_run");
            }
            else
            {
                rb2d.velocity = new Vector2(-playerSpeed * 0.75f, rb2d.velocity.y);
            }
            sprite_Renderer.flipX = true;
        }
        else
        {
            if (_grounded)
                animator.Play("player_idle");
            rb2d.velocity = new Vector2(0, rb2d.velocity.y);
        }
        if (Input.GetKey("space") && _grounded)
        {
            rb2d.velocity = new Vector2(rb2d.velocity.x, jumpSpeed);
           
        }
        if (rb2d.velocity.y > 0.05f && !_grounded)
            animator.Play("player_jump");
        else if (rb2d.velocity.y < -1f && !_grounded)
            animator.Play("player_fall");
        else if (rb2d.velocity.y < 1 && rb2d.velocity.y > -1f && !_grounded)
            animator.Play("player_hold");
    }
    private bool CheckGround()
    {
        return (Physics2D.OverlapBox(transform.position - Vector3.down * overlapOffset, overlapBoxSize, 0, groundLayer));
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawCube(transform.position - Vector3.down * overlapOffset, overlapBoxSize);
    }
}
