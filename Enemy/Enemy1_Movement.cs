using UnityEngine;

public class Enemy1_Movement : MonoBehaviour
{
    private Rigidbody2D _rb2D;
    private Vector2 _minCoords;

    [SerializeField] float enemySpeed;
    [SerializeField] GameObject enemyExplosion;

    private void Start()
    {
        _rb2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        _rb2D.velocity = new Vector2(-enemySpeed, _rb2D.velocity.y);

        //Get the camera coordinates to destroy the object once it reaches the end of the screen
        _minCoords = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));

        if (transform.position.x < _minCoords.x - 1.5f)
            Destroy(this.gameObject);
    }
    private void OnDestroy()
    {
        Instantiate(enemyExplosion, transform.position, Quaternion.identity);
    }
}
