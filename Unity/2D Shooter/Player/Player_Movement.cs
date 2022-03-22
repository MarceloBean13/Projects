using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    private Animator _anim;
    private Rigidbody2D _rb2D;
    private float _xMov;
    private float _yMov;

    [SerializeField] float playerSpeed;

    private void Awake()
    {
        _anim = GetComponent<Animator>();
        _rb2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        //Create coordinates to prevent the player from going off Camera
        Vector2 minCoords = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));
        Vector2 maxCoords = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));

        //Using Mathf.Clamp to give the minimum and max coords
        transform.position = new Vector2(Mathf.Clamp(transform.position.x, minCoords.x + 0.75f, maxCoords.x - 1), 
            Mathf.Clamp(transform.position.y, minCoords.y, maxCoords.y - 1));
       
        //Grabing the Vertical and Horizontal Axis
        _yMov = Input.GetAxis("Vertical");
        _xMov = Input.GetAxis("Horizontal");

        _rb2D.velocity = new Vector2(_xMov * playerSpeed, _yMov * playerSpeed);

        if (_rb2D.velocity.y > 0.1)
            _anim.Play("Player_Up");
        else if (_rb2D.velocity.y < -0.1)
            _anim.Play("Player_Down");
        else
            _anim.Play("Player_Idle");
    }
}
