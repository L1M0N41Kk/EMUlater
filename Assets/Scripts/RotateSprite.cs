using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateSprite : MonoBehaviour
{
    public Sprite[] index;
    private SpriteRenderer _spriteRenderer;

    private void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        Vector2 crate_up = (Vector2)transform.up; //up
        float signed_angle = Vector2.SignedAngle(crate_up, Vector2.left);
        float angle = signed_angle;
        if (angle < 0)
        {
            angle += 360f;
        }

        if (angle > 0 && angle < 45)
        {
            _spriteRenderer.sprite = index[0];
        }
        else if (angle >= 45 && angle < 90)
        {
            _spriteRenderer.sprite = index[1];
        }
        else if (angle >= 90 && angle < 135)
        {
            _spriteRenderer.sprite = index[2];
        }
        // more if else here...

        Debug.Log(angle);
    }
}
