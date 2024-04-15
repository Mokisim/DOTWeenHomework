using UnityEngine;
using DG.Tweening;

public class CapsuleSizeChanger : MonoBehaviour
{
    private int _targetSizeX = 4;
    private int _targetSizeY = 3;
    private int _targetSizeZ = 3;
    private int _animationDuration = 3;
    private int _loops = -1;

    private void Start()
    {
        transform.DOScale(new Vector3(_targetSizeX, _targetSizeY, _targetSizeZ), _animationDuration).SetLoops(_loops, LoopType.Yoyo);
    }
}
