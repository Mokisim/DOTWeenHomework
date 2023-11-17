using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class SphereMovement : MonoBehaviour
{
    private Transform _transform;

    private void Start()
    {
        _transform = GetComponent<Transform>();
        _transform.DOMove(new Vector3(0, 5, 0), 5).SetLoops(-1, LoopType.Yoyo);
    }
}
