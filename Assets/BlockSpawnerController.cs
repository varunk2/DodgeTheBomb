using UnityEngine;

public class BlockSpawnerController : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject blockPrefab;
    public ScoreController scoreController;
    public BlockController blockController;
    public float timeBetweenWaves = 1f;

    private float timeToSpawn = 2f;
 
    // Start is called before the first frame update
    void Update()
    {
        //Debug.Log("Time: " + Time.time + ", timeBetweenWaves: " + timeBetweenWaves);
        if (Time.time >= timeToSpawn)
        {
            SpawnBlocks();
            timeToSpawn = Time.time + timeBetweenWaves;
            //Debug.Log("Time To Spawn: " + timeToSpawn);
        }
    }

    void SpawnBlocks()
    {
        int randomIndex = Random.Range(0, spawnPoints.Length);

        for (int i = 0; i < spawnPoints.Length; i++)
        {
            if (randomIndex != i)
            {
                Instantiate(blockPrefab, spawnPoints[i].position, Quaternion.identity);
            }
        }
    }
}
