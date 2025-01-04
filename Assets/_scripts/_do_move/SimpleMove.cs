using System;
using DG.Tweening;
using UnityEngine;

public class SimpleMove : MonoBehaviour
{
    private void Start()
    {
        Vector3 newPos = Vector3.one;
        transform.DOMove(newPos,1f).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.Linear);
        
        /*transform.DOMoveX(3f, 1f)
            .SetLoops(-1, LoopType.Yoyo)
            .SetEase(Ease.InOutFlash);*/
    }
}
