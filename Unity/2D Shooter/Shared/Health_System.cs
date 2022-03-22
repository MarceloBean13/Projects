using UnityEngine;

public class Health_System : MonoBehaviour
{
    [SerializeField] int maxHealth;
    [SerializeField] GameObject explosion;
    public UI_Controller uIController; 

    public int _currHealth;

    private void Start()
    {
        _currHealth = maxHealth;
    }

    public void TakeDamage(int dmg)
    {
        _currHealth -= dmg;
        if (_currHealth <= 0)
        {
            Die();
            if (uIController != null) uIController.FadeGameOver();
        }
        if (uIController != null) uIController.ChangeSprite();
    }

    //Player or Enemy death function
    private void Die()
    {
        Destroy(this.gameObject);
        Instantiate(explosion, transform.position, Quaternion.identity);
    }
}