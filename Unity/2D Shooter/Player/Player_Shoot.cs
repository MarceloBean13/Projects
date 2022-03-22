using UnityEngine;
using System.Collections;

public class Player_Shoot : MonoBehaviour
{
    [SerializeField] GameObject playerShot;

    private bool _isReady = true;

    void Update()
    {
      if ((Input.GetKeyDown(KeyCode.Space) || Input.GetKey(KeyCode.Space)) && _isReady)
      {
            Instantiate(playerShot, transform.position, Quaternion.identity);
            _isReady = false;
            StartCoroutine(Fire_Cooldown());
      }
    }

    //Create a timer for firing next bullet
    IEnumerator Fire_Cooldown()
    {
        yield return new WaitForSeconds(0.7f);
        _isReady = true;
    }
}
