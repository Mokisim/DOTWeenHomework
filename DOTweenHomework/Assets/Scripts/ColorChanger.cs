using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    private SpriteRenderer _spriteRenderer;

    private void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _spriteRenderer.DOColor(Color.red, 3).SetLoops(-1, LoopType.Yoyo);
    }
}
