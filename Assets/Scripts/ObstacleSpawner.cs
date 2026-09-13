using UnityEngine;


public class ObstacleSpawner : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public float spawnInterval = 2.0f;
    public int maxObstacles = 10;
    public float timer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= spawnInterval)
        {
            timer = 0.0f;
            Spawn();
        }
    }

    void Spawn()
    {
        Vector3 viewportPos = new Vector3(Random.value, Random.value, 0f);
        Vector3 worldPos = Camera.main.ViewportToWorldPoint(viewportPos);
        worldPos.z = 0f;
        Instantiate(obstaclePrefab, worldPos, Quaternion.identity);
    }
}
