using UnityEngine;

public class Player_Damage : MonoBehaviour
{
    [SerializeField] int damage;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            Health_System hp = this.gameObject.GetComponent<Health_System>();
            hp.TakeDamage(damage);
        }
    }
}
