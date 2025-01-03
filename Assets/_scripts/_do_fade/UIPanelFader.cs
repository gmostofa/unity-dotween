using UnityEngine;
using DG.Tweening;

public class UIPanelFader : MonoBehaviour
{
    [SerializeField] private CanvasGroup canvasGroup; 
    [SerializeField] private float fadeDuration = 1f;  
    [SerializeField] private float delayBeforeFadeOut = 2f; 

    private void Start()
    {
        FadeIn();
        TriggerFadeOutAfterDelay();
    }
    
    public void FadeIn()
    {
        canvasGroup.DOFade(1, fadeDuration);  
    }
    
    public void FadeOut()
    {
        canvasGroup.DOFade(0, fadeDuration); 
    }
    
    public void TriggerFadeOutAfterDelay()
    {
        Invoke(nameof(FadeOut), delayBeforeFadeOut); 
    }
}