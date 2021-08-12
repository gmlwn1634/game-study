using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySaurus : MonoBehaviour
{

    public Rigidbody2D rigid;
    public new SpriteRenderer renderer;
    public float moveSpeed;
    bool isLeft = true;
    bool isDead = false;


    public void OnDamage()
    {
        isDead = true;
        BoxCollider2D collider2D = gameObject.GetComponent<BoxCollider2D>();
        collider2D.enabled = false;
        renderer.color = new Color(1, 1, 1, 0.5f);
        rigid.AddForce(Vector2.up * 8, ForceMode2D.Impulse);


    }


    // Update is called once per frame
    void Update()
    {
        if (isDead)
            return;

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
            isLeft = !isLeft;
    }


}
