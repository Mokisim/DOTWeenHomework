using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CubeRotation : MonoBehaviour
{
    private Transform _transform;

    private void Start()
    {
        _transform = GetComponent<Transform>();
        _transform.DORotate(new Vector3(180, 360, 160), 2).SetLoops(-1, LoopType.Yoyo);
    }
}
