using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Playables;
using UnityEngine.Splines;


[ExecuteAlways] // Permite que el script funcione en Edit Mode
[RequireComponent(typeof(PlayableDirector))]
public class PlayableSegment : Segment
{

    public class ChangedTimelineEvent : UnityEvent<SplineContainer, int> { };

    static public ChangedTimelineEvent ChangedTimeline;

    void OnEnable()
    {
        if (ChangedTimeline is null) ChangedTimeline = new();
    }


    public override void Activate()
    {
        GetComponent<PlayableDirector>().Play();
    }

    public override bool IsPlaying()
    { 
        return GetComponent<PlayableDirector>().state == PlayState.Playing;
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
