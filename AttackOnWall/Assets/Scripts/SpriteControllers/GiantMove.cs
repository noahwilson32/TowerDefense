using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class GiantMove : MonoBehaviour
{
    public float moveSpeed = 1.5f;

    public Tilemap map;
    public TileBase[] wallTiles;

    public TileBase currentTile;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    public void Move()
    {
        Vector2 velocity = new Vector2(transform.position.x - (moveSpeed * Time.deltaTime), transform.position.y);
        transform.position = velocity;

        Vector3Int pos = new Vector3Int((int)transform.position.x - 1, (int)transform.position.y, (int)transform.position.z);
        currentTile = map.GetTile(pos);

        foreach(TileBase wall in wallTiles)
        {
            if(currentTile == wall)
            {
                moveSpeed = 0;
            }
        }
    }
}
