using UnityEngine;
using DG.Tweening;

public class MaterialColorChanger : MonoBehaviour
{
    [SerializeField] private Color targetColor = Color.red; // Target color
    [SerializeField] private float duration = 1f; // Animation duration
    private Material objectMaterial;

    private void Start()
    {
        objectMaterial = GetComponent<Renderer>().material;
        
        ChangeColor();
    }

    public void ChangeColor()
    {
        objectMaterial.DOColor(targetColor, duration);
    }
}

