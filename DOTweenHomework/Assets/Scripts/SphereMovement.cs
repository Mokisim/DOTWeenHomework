using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

[RequireComponent(typeof(Transform))]
public class SphereMovement : MonoBehaviour
{
    private Transform _transform;

    private int _animationDuration = 5;
    private int _loops = -1;
    private int _directionX = 0;
    private int _directionY = 5;
    private int _directionZ = 0;

    private void Start()
    {
        _transform = GetComponent<Transform>();
        _transform.DOMove(new Vector3(_directionX, _directionY, _directionZ), _animationDuration).SetLoops(_loops, LoopType.Yoyo);
    }
}
