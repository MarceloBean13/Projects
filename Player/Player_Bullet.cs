using UnityEngine;

public class Player_Bullet : MonoBehaviour
{
    private Rigidbody2D _rb2d;
    private Vector2 _maxCoord;

    public GameObject bulletExplosion;
    public float bulletSpeed;
    public int damage;

    private void Awake()
    {
        _rb2d = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        _rb2d.velocity = new Vector2(bulletSpeed, _rb2d.velocity.y);

        //Grab the camera max coordinates
        _maxCoord = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));

        if (transform.position.x > _maxCoord.x)
            Destroy(this.gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            Health_System hp = collision.GetComponent<Health_System>();
            hp.TakeDamage(damage);

            Instantiate(bulletExplosion, transform.position, Quaternion.identity);
            Destroy(this.gameObject);

        }
    }
}
