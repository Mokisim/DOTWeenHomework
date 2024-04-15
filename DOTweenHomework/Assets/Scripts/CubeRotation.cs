using UnityEngine;
using DG.Tweening;

public class CubeRotation : MonoBehaviour
{
    private int _targetRotationX = 180;
    private int _targetRotationY = 360;
    private int _targetRotationZ = 160;
    private int _animationDuration = 2;
    private int _loops = -1;

    private void Start()
    {
        transform.DORotate(new Vector3(_targetRotationX, _targetRotationY, _targetRotationZ), _animationDuration).SetLoops(_loops, LoopType.Yoyo);
    }
}
