using UnityEngine;
using System.Collections;

public class EnemyMove : MonoBehaviour
{

    public float Speed = 2f;
    private float moveX = 0f;
    private float moveY = 0f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        moveX = -1;
        GetComponent<Rigidbody2D>().velocity = new Vector2(moveX * Speed, moveY * Speed);
    }

    void OnCollisionEnter2D(Collision2D col)
    {
      
    }
}
