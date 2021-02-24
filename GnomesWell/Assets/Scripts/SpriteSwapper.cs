﻿using UnityEngine;

public class SpriteSwapper : MonoBehaviour
{
    public Sprite spriteToUse;
    public SpriteRenderer spriteRenderer;
    private Sprite originalSprite;

    public void SwapSprite()
    {
        if (spriteToUse != spriteRenderer)
        {
            originalSprite = spriteRenderer.sprite;
            spriteRenderer.sprite = spriteToUse;
        }
    }

    public void ResetSprite()
    {
        if (originalSprite != null)
        {
            spriteRenderer.sprite = originalSprite;
        }
    }
}
