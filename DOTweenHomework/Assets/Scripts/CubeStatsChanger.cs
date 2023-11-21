using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Transform))]
public class CubeStatsChanger : MonoBehaviour
{
    private Transform _transform;

    private int _directionX = 3;
    private int _directionY = 5;
    private int _directionZ = 9;

    private int _targetRotationX = 180;
    private int _targetRotationY = 360;
    private int _targetRotationZ = 160;

    private int _targetSizeX = 4;
    private int _targetSizeY = 3;
    private int _targetSizeZ = 3;

    private int _scaleAnimationDuration = 3;
    private int _rotateAnimationDuration = 2;
    private int _moveAnimationDuration = 5;

    private int _loops = -1;

    private void Start()
    {
        _transform = GetComponent<Transform>();
        _transform.DOScale(new Vector3(_targetSizeX, _targetSizeY, _targetSizeZ), _scaleAnimationDuration).SetLoops(_loops, LoopType.Yoyo);
        _transform.DORotate(new Vector3(_targetRotationX, _targetRotationY, _targetRotationZ), _rotateAnimationDuration).SetLoops(_loops, LoopType.Yoyo);
        _transform.DOMove(new Vector3(_directionX, _directionY, _directionZ), _moveAnimationDuration).SetLoops(_loops, LoopType.Yoyo);
    }
}
