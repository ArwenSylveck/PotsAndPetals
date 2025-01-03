using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScaler : MonoBehaviour
{
    void Start()
    {
        ScaleBackground();
    }

    void ScaleBackground()
    {
        SpriteRenderer sr = GetComponent<SpriteRenderer>();
        if (sr == null) return;

        float screenHeight = Camera.main.orthographicSize * 2;
        float screenWidth = screenHeight * Camera.main.aspect;

        Vector2 spriteSize = sr.sprite.bounds.size;
        transform.localScale = new Vector3(
            screenWidth / spriteSize.x,
            screenHeight / spriteSize.y,
            1
        );
    }
}

