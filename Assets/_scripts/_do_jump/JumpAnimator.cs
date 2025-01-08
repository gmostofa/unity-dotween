using UnityEngine;
using DG.Tweening;

public class JumpAnimator : MonoBehaviour
{
    [SerializeField] private Vector3 targetPosition = new Vector3(5, 0, 0); 
    [SerializeField] private float jumpPower = 2f;   
    [SerializeField] private int jumpCount = 3;      
    [SerializeField] private float duration = 2f;   

    private void Start()
    {
        transform.DOJump(targetPosition, jumpPower, jumpCount, duration)
            .OnStart((() => {Debug.Log($"Jump Started");}))
            .OnComplete((() => {Debug.Log($"Jump Ended");}));
        
        //transform.DOJump(targetPosition, jumpPower, jumpCount, duration);
        /*.SetEase(Ease.OutQuad)
        .OnStart(() => Debug.Log("Jump started!"))
        .OnComplete(() => Debug.Log("Jump completed!"));*/
    }
}