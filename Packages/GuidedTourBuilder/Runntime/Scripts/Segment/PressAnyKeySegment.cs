using UnityEngine;

public class PressAnyKeySegment :  Segment
{
    public override void Activate()
    {

    }

    public override void Hide()
    {
        return;
    }

    public override bool IsPlaying()
    {
        return (! Input.GetKeyDown(KeyCode.Space));
    }

    public override void Show()
    {
        return;
    }
}
