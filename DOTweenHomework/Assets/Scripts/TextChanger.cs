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

        sequence.Append(_text.DOText("Заменил текст, что дальше?", 3));
        sequence.Append(_text.DOText("Дополнил текст, продолжим?", 4).SetRelative());
        sequence.Append(_text.DOText("Ты взломан :(", 5, true, ScrambleMode.All));
    }
}
