using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CapsuleSizeChanger : MonoBehaviour
{
    private Transform _transform;

    private void Start()
    {
        _transform = GetComponent<Transform>();
        _transform.DOScale(new Vector3(4, 3, 3), 3).SetLoops(-1, LoopType.Yoyo);
    }
}
