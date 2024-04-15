using UnityEngine;
using DG.Tweening;

public class SphereMovement : MonoBehaviour
{
    private int _animationDuration = 5;
    private int _loops = -1;
    private int _directionX = 0;
    private int _directionY = 5;
    private int _directionZ = 0;

    private void Start()
    {
        transform.DOMove(new Vector3(_directionX, _directionY, _directionZ), _animationDuration).SetLoops(_loops, LoopType.Yoyo);
    }
}
