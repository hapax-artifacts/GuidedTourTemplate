using UnityEngine;
using UnityEngine.Playables;

public class SplinePlayable : PlayableBehaviour
{
    public SplineFollower splineFollower;

    [Range(0f, 1f)]
    [SerializeField] public float progress = 0f; // Animable desde el Timeline

    public override void ProcessFrame(Playable playable, FrameData info, object playerData)
    {
        if (splineFollower != null)
        {
            // Usa el valor animado de progreso
            splineFollower.normalizedTime = progress;
        }
    }


    public override void OnGraphStop(Playable playable)
    {
        Debug.Log("SplinePlayable ha terminado.");
        splineFollower.splineContainer = null;
    }
}
