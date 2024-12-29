using DG.Tweening;
using UnityEngine;

public class DoScale : MonoBehaviour
{
       [SerializeField] private float scaleFactor = 1.2f; // How much to scale
       [SerializeField] private float duration = 0.5f;    // Duration of the animation
   
       private Vector3 originalScale;
   
       private void Start()
       {
           // Save the original scale of the button
           originalScale = transform.localScale;
       }
       
       
   
       public void OnPointerEnter()
       {
           // Scale up when the pointer enters
           transform.DOScale(originalScale * scaleFactor, duration).SetEase(Ease.OutQuad);
       }
   
       public void OnPointerExit()
       {
           // Scale back to original size when the pointer exits
           transform.DOScale(originalScale, duration).SetEase(Ease.OutQuad);
       }
}
