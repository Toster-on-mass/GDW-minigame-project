using UnityEngine;
using System.Collections;

public class ObjectSpawner : MonoBehaviour
{
    public Vector3 spawnRangeA;
    public Vector3 spawnRangeB;

    public GameObject[] objects;

    public float startPause = 0.2f;
    public float spawnTime = 0.5f;
    public float minimunSpawnTime = 0.05f;
    public float spawnTimeDecrease = 0.05f;
    public float difStartPause = 1.0f;
    public float difIncreaseTime = 3.0f;

    private Coroutine aaahWhySoHardToJustHaveAPause;

    void Start()
    {
        aaahWhySoHardToJustHaveAPause = StartCoroutine("SpawnObjectLoop");
        //InvokeRepeating("SpawnObject",startPause,spawnTime);
        InvokeRepeating("IncreaseDifficulty", difStartPause, difIncreaseTime);

        
        //StartCoroutine("SpawnObjectLoop");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnObjectLoop()
    {// Why is IEnumerable also a thing? Just to incovenince me?
        while (true)
        {
            SpawnObject();
            yield return new WaitForSeconds(spawnTime);
            // I miss "await get_tree().create_timer(0.1).timeout"
        }
    }

    void SpawnObject()
    {
        Vector3 randomPos = new Vector3(Random.Range(spawnRangeA.x, spawnRangeB.x), Random.Range(spawnRangeA.y, spawnRangeB.y), Random.Range(spawnRangeA.z, spawnRangeB.z));
        int randomIndex = Random.Range(0, objects.Length);
        Instantiate(objects[randomIndex], randomPos, objects[randomIndex].transform.rotation);
    }

    void IncreaseDifficulty()
    {
        spawnTime = Mathf.Max(minimunSpawnTime, spawnTime - spawnTimeDecrease);
    }
}
