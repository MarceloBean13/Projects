using UnityEngine;


public class Enemy_Spawner : MonoBehaviour
{
    public GameObject enemyObj;
    [SerializeField] float setTimerRespawn;

    private Vector2 _minCoords;
    private Vector2 _maxCoords;

    private void Start()
    {
        Invoke("SpawnEnemys", 5);
    }
    private void SpawnEnemys()
    {
        _minCoords = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));
        _maxCoords = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));

        GameObject enemy = Instantiate(enemyObj);
        enemy.transform.position = new Vector2(_maxCoords.x, Random.Range(_minCoords.y + 1f, _maxCoords.y - 1f));
        SpawnTimer();
    }

    private void SpawnTimer()
    {
        float spawnInSeconds;

        if (setTimerRespawn > 1)
            spawnInSeconds = Random.Range(1, setTimerRespawn);
        else
            spawnInSeconds = 1;

        Invoke("SpawnEnemys", spawnInSeconds);
    }
}
