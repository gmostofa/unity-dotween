using UnityEngine;
using DG.Tweening;

public class DoTweenSequenceExample : MonoBehaviour
{
    public Transform target;

    void Start()
    {
        // Create a new Sequence
        Sequence mySequence = DOTween.Sequence();

        // Append a move to position over 1 second
        mySequence.Append(target.DOMove(new Vector3(3, 0, 0), 1f));

        // Append a rotation over 1 second
        mySequence.Append(target.DORotate(new Vector3(0, 180, 0), 1f, RotateMode.FastBeyond360));

        // Append a scale up over 1 second
        mySequence.Append(target.DOScale(new Vector3(3, 3, 3), 1f));
        
        
        // Append a rotation over 1 second
        mySequence.Append(target.DORotate(new Vector3(0, 360, 0), 1f, RotateMode.FastBeyond360));
        

        // Add a callback at the end
        mySequence.OnComplete(() => Debug.Log("Sequence Completed!"));
    }
}
