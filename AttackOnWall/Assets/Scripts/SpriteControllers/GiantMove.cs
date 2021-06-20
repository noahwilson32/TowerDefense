using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class GiantMove : MonoBehaviour
{
    public float moveSpeed = 1.5f;

    public Tilemap map;
    public TileBase wallTile;

    public TileBase currentTile;

    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        StartCoroutine(Animate());
    }
    public void Move()
    {
        Vector2 velocity = new Vector2(transform.position.x - (moveSpeed * Time.deltaTime), transform.position.y);
        transform.position = velocity;

        Vector3Int pos = new Vector3Int((int)transform.position.x - 1, (int)transform.position.y - 1, (int)transform.position.z);
        currentTile = map.GetTile(pos);
        
        if(currentTile == wallTile)
        {
            moveSpeed = 0;
        }
        
    }

    public IEnumerator Animate()
    {
        if(moveSpeed == 0)
        {
            anim.SetBool("isIdle", true);
            yield return new WaitForSeconds(1.5f);
            anim.SetBool("isExploding", true);
            Destroy(gameObject, .25f);
            GiantSpawner.giantsSpawned--;
        }
    }
}
