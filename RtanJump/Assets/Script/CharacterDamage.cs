using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterDamage : MonoBehaviour
{
    public BoxCollider2D collider1;
    public BoxCollider2D collider2;
    public new SpriteRenderer renderer;

    void OnDamage()
    {
        //enabled true 활성화
        //enabled false 비활성화
        collider1.enabled = false;
        collider2.enabled = false;
        renderer.color = new Color(1, 1, 1, 0.5f);
        GameManager.I.GameOver();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "enemy")
            OnDamage();
    }
}
