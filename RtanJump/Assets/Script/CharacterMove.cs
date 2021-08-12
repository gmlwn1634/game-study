using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour
{
    public Transform trans;
    public Rigidbody2D rigid;
    public new SpriteRenderer renderer;
    public float moveSpeed;
 
    void Update()
    {
        Vector2 direction = Vector2.zero;

        if (Input.GetKey(KeyCode.LeftArrow))
            direction = Vector2.left * moveSpeed;
        
        if (Input.GetKey(KeyCode.RightArrow))
            direction = Vector2.right * moveSpeed;

        if (Input.GetKeyDown(KeyCode.LeftArrow))
            renderer.flipX = true;

        if (Input.GetKeyDown(KeyCode.RightArrow))
            renderer.flipX = false;

        direction.y = rigid.velocity.y;
        rigid.velocity = direction;

    }
}
