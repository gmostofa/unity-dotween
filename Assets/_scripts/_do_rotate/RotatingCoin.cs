using DG.Tweening;
using UnityEngine;

public class RotatingCoin : MonoBehaviour
{
    [SerializeField] [Range(0f,20f)] private float rotationDuration = 2f; 

    private void Start()
    {
        transform.DORotate(new Vector3(0, 360, 0), rotationDuration, RotateMode.FastBeyond360)
            .SetEase(Ease.Linear)
            .SetLoops(-1, LoopType.Restart);
    }
}
