using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterJump : MonoBehaviour
{
    public Rigidbody2D rigid;
    public float jumpHeight;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            rigid.AddForce(Vector2.up * jumpHeight, ForceMode2D.Impulse);

        }
    }
}
