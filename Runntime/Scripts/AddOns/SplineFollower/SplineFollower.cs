using System;
using UnityEngine;
using UnityEngine.Splines;

[ExecuteInEditMode]
public class SplineFollower : MonoBehaviour
{
    public SplineContainer splineContainer; // Asigna el spline aquí
    public int splineIndex;

    public float normalizedTime; // De 0 a 1

    private void Start()
    {
        SplinePlayableSegment.ChangedTimeline.AddListener(OnTimelineChanged);
    }

    private void OnTimelineChanged(SplineContainer arg0, int arg1, bool arg2)
    {
        Debug.LogError("cuando termine spline que se quede nulo. Crear un evento?");
        this.splineContainer = arg0;
        this.splineIndex = arg1;
        this.normalizedTime = 0;
    }

    void Update()
    {
        if (splineContainer != null)
        {
            var position = splineContainer[splineIndex].EvaluatePosition(normalizedTime);
            transform.position = position;
        }
    }

    public void Disconnect()
    {
        splineContainer = null;
    }

}

