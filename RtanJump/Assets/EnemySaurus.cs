using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySaurus : MonoBehaviour
{

    public Rigidbody2D rigid;
    public new SpriteRenderer renderer;
    public float moveSpeed;
    bool isLeft = true;
    

    // Update is called once per frame
    void Update()
    {
        if (isLeft)
        {
            rigid.velocity = Vector2.left * moveSpeed;
            renderer.flipX = false;
        }
        else
        {
            rigid.velocity = Vector2.right * moveSpeed;
            renderer.flipX = true;
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "wall")
        {
            isLeft = !isLeft;
        }
    }

}
