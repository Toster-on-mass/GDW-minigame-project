using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public Vector3 spawnRangeA;
    public Vector3 spawnRangeB;

    public GameObject[] objects;

    public float startPause = 0.2f;
    public float spawnTime = 0.5f;


    void Start()
    {
        InvokeRepeating("SpawnObject",startPause,spawnTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObject()
    {
        Vector3 randomPos = new Vector3(Random.Range(spawnRangeA.x, spawnRangeB.x), Random.Range(spawnRangeA.y, spawnRangeB.y), Random.Range(spawnRangeA.z, spawnRangeB.z));
        int randomIndex = Random.Range(0, objects.Length);
        Instantiate(objects[randomIndex], randomPos, objects[randomIndex].transform.rotation);
    }
}
