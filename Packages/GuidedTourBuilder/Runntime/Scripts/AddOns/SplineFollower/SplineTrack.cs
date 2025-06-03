using UnityEngine;
using UnityEngine.Timeline;

[TrackClipType(typeof(SplinePlayableAsset))]
[TrackBindingType(typeof(SplineFollower))]
public class SplineTrack : TrackAsset
{
    // Permite editar las curvas del clip
}
