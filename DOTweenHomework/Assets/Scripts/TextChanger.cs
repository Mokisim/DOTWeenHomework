using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class TextChanger : MonoBehaviour
{
    [SerializeField] private Text _text;

    void Start()
    {
        Sequence sequence = DOTween.Sequence();

        sequence.Append(_text.DOText("������� �����, ��� ������?", 3));
        sequence.Append(_text.DOText("�������� �����, ���������?", 4).SetRelative());
        sequence.Append(_text.DOText("�� ������� :(", 5, true, ScrambleMode.All));
    }
}
