using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterJump : MonoBehaviour
{
    public Rigidbody2D rigid;
    public float jumpHeight;
    int jumpCount = 0;
    int jumpLimit = 2;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
            if (jumpCount < jumpLimit) {
                jumpCount++;
                rigid.AddForce(Vector2.up * jumpHeight, ForceMode2D.Impulse);
            }
    }

    // unity 기본 제공 함수
    private void OnTriggerEnter2D(Collider2D collider2D)
    {
        if (collider2D.gameObject.tag == "ground")
            jumpCount = 0;
    }
}
