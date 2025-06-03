using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Playables;
using UnityEngine.Splines;


[ExecuteAlways] // Permite que el script funcione en Edit Mode
[RequireComponent(typeof(PlayableDirector))]
public class SplinePlayableSegment : Segment
{

    public class ChangedTimelineEvent : UnityEvent<SplineContainer, int, bool> { };

    static public ChangedTimelineEvent ChangedTimeline;

    void OnEnable()
    {
        if (ChangedTimeline is null) ChangedTimeline = new();
    }

    [SerializeField] SplineContainer splineContainer;
    [SerializeField] int splineIndex;

    [SerializeField] bool lerpPositionToTarget;

    public override void Activate()
    {
        GetComponent<PlayableDirector>().Play();
    }

    public override bool IsPlaying()
    { 
        return GetComponent<PlayableDirector>().state == PlayState.Playing;
    }

    public void InitPlayable()
    {
        Debug.Log("Init playable" + splineIndex);

        ChangedTimeline.Invoke(splineContainer, splineIndex, lerpPositionToTarget);
    }

    [ContextMenu("Play Timeline in Edit Mode")]
    public void PlayTimeline()
    {
        var director = GetComponent<PlayableDirector>();
        director.time = 0; // Reiniciar la Timeline
        director.Evaluate(); // Evalúa el estado actual sin entrar en Play Mode
        InitPlayable();
        Debug.Log("Timeline evaluada desde el inicio en Edit Mode.");
    }

    public override void Hide()
    {
        return; 
    }

    public override void Show()
    {
        return;
    }
}
