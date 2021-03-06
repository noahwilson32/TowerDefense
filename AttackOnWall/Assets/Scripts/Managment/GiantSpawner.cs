using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiantSpawner : MonoBehaviour
{
    Vector3Int moveMag;

    public GameObject giantPrefab;
    public static int giantsSpawned;
    private float timeBetween;
    private float elapsedTime;
    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        MoveSpawner();

        if(giantsSpawned < 4)
        {
            SpawnGiant();
            timeBetween = Random.Range(4f, 5f);
        }
    }
    public void MoveSpawner()
    {
        if (transform.position.y >= 5)
        {
            moveMag = new Vector3Int(0, -1, 0);
        }
        if(transform.position.y <= -2)
        {
            moveMag = new Vector3Int(0, 1, 0);
        }
        transform.position += moveMag;
    }

    public void SpawnGiant()
    {
        elapsedTime += Time.deltaTime;

        if(elapsedTime >= timeBetween)
        {
            elapsedTime = 0;
            GameObject giantInstance = Instantiate(giantPrefab, transform.position, Quaternion.identity);
            giantsSpawned++;
        }
    }
}
