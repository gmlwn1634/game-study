using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterDamage : MonoBehaviour
{
    public BoxCollider2D collider1;
    public BoxCollider2D collider2;
    public new SpriteRenderer renderer;

    void onDamage()
    {
        //enabled true Ȱ��ȭ
        //enabled false ��Ȱ��ȭ
        collider1.enabled = false;
        collider2.enabled = false;
        renderer.color = new Color(1, 1, 1, 0.5f);
    }




    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "enemy")
        {
            onDamage();
        }
    }
}