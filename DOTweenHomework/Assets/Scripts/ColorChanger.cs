using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(SpriteRenderer))]
public class ColorChanger : MonoBehaviour
{
    private SpriteRenderer _spriteRenderer;

    private int _animationDuration = 3;
    private int _loops = -1;

    private Color _targetColor = Color.red;

    private void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _spriteRenderer.DOColor(_targetColor, _animationDuration).SetLoops(_loops, LoopType.Yoyo);
    }
}
