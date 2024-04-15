using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class TextChanger : MonoBehaviour
{
    [SerializeField] private Text _text;

    private int _replaceAnimationDuration = 3;
    private int _supplementAnimationDuration = 4;
    private int _hackAnimationDuration = 5;

    private Sequence _sequence;

    void Start()
    {
        _sequence = DOTween.Sequence();

        _sequence.Append(_text.DOText("Заменил текст, что дальше?", _replaceAnimationDuration));
        _sequence.Append(_text.DOText("Дополнил текст, продолжим?", _supplementAnimationDuration).SetRelative());
        _sequence.Append(_text.DOText("Ты взломан :(", _hackAnimationDuration, true, ScrambleMode.All));
    }
}
