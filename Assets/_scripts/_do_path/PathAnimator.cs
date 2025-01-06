using UnityEngine;
using DG.Tweening;

public class PathAnimator : MonoBehaviour
{
    [SerializeField] private Transform[] waypoints;  
    [SerializeField] private float duration = 5f;   

    private void Start()
    {
        Vector3[] pathPoints = new Vector3[waypoints.Length];

        for (int i = 0; i < waypoints.Length; i++)
        {
            pathPoints[i] = waypoints[i].position; 
        }

        transform.DOPath(pathPoints, duration,PathType.CatmullRom)
            .SetEase(Ease.Linear)
            .SetLookAt(0.01f)
            .SetLoops(-1, LoopType.Yoyo);

        //transform.DOPath(pathPoints, duration, PathType.Linear);
        //.SetEase(Ease.Linear)
        //.SetLookAt(0.01f)
        //.SetLoops(-1, LoopType.Yoyo); 
    }
    
    
    private void OnDrawGizmos()
    {
        if (waypoints == null || waypoints.Length < 2) return;

        Gizmos.color = Color.green;
        for (int i = 0; i < waypoints.Length - 1; i++)
        {
            Gizmos.DrawLine(waypoints[i].position, waypoints[i + 1].position);
        }
    }

}