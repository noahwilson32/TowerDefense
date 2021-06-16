using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiantSpawner : MonoBehaviour
{
    Vector3Int moveMag;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveSpawner();
    }
    public void MoveSpawner()
    {
        if (transform.position.y >= 6)
        {
            moveMag = new Vector3Int(0, -1, 0);
        }
        if(transform.position.y <= -3)
        {
            moveMag = new Vector3Int(0, 1, 0);
        }
        transform.position += moveMag;
        

    }
}
