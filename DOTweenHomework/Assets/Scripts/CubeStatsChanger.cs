using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeStatsChanger : MonoBehaviour
{
    private Transform _transform;

    private void Start()
    {
        _transform = GetComponent<Transform>();
        _transform.DOScale(new Vector3(4, 3, 3), 3).SetLoops(-1, LoopType.Yoyo);
        _transform.DORotate(new Vector3(180, 360, 160), 2).SetLoops(-1, LoopType.Yoyo);
        _transform.DOMove(new Vector3(3, 5, 9), 5).SetLoops(-1, LoopType.Yoyo);
    }
}
