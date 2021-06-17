using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiantMove : MonoBehaviour
{
    public float moveSpeed = 1.5f;

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
    }
}
