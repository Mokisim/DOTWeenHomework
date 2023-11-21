using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class TextChanger : MonoBehaviour
{
    [SerializeField] private Text _text;

    private int _replaceAnimationDuration = 3;
    private int _supplementAnimationDuration = 4;
    private int _hackAnimationDuration = 5;

    void Start()
    {
        Sequence sequence = DOTween.Sequence();

        sequence.Append(_text.DOText("������� �����, ��� ������?", _replaceAnimationDuration));
        sequence.Append(_text.DOText("�������� �����, ���������?", _supplementAnimationDuration).SetRelative());
        sequence.Append(_text.DOText("�� ������� :(", _hackAnimationDuration, true, ScrambleMode.All));
    }
}
