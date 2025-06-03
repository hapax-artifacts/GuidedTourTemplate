using UnityEngine;
using UnityEngine.Playables;

[System.Serializable]
public class SplinePlayableAsset : PlayableAsset
{
    public ExposedReference<SplineFollower> splineFollower;

    [Range(0f, 1f)]
    [SerializeField] public float progress = 0f; // Progreso animable en el spline

    public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
    {
        var playable = ScriptPlayable<SplinePlayable>.Create(graph);
        var splinePlayable = playable.GetBehaviour();

        splinePlayable.splineFollower = splineFollower.Resolve(graph.GetResolver());
        splinePlayable.progress = progress;

        return playable;
    }
}
