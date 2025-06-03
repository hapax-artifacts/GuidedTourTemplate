using UnityEngine;

public class TeleportSegment : Segment
{
    Collider trigger;

    bool touched = false;

    Transform teleportTo;

    MeshRenderer[] renderers;

    void Awake()
    {
        trigger = GetComponentInChildren<Collider>();
        trigger.enabled = false;
        teleportTo = transform.parent.Find("To");
        renderers =   GetComponentsInChildren<MeshRenderer>();
    }



    public override void Activate()
    {
        touched = false;
        trigger.enabled = true;
    }

    public override bool IsPlaying()
    {
        if (touched)
        {
            
            trigger.enabled = false;
            return false;
        }
        else
        {
            return true;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Touched");
        //other.GetComponentInParent<RigController>().Teleport(teleportTo);

        touched = true;
    }

    void OnTriggerExit(Collider other)
    {
        touched = false;
    }

    public override void Hide()
    {
        trigger.enabled = false;

        foreach (var renderer in renderers) 
        {
            renderer.enabled = false;
        }
    }

    public override void Show()
    {
        trigger.enabled = true;

        foreach (var renderer in renderers)
        {
            renderer.enabled = true;
        }
    }
}

