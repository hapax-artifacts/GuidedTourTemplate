using UnityEngine;

public class ContactTriggerSegment : Segment
{

    Collider trigger;

    bool touched = false;

    void Awake()
    {
        trigger = GetComponent<Collider>();
        trigger.enabled = false;
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
        touched = true;
    }

    void OnTriggerExit(Collider other)
    {
        touched = false;
    }

    public override void Hide()
    {
        trigger.enabled = false;
        GetComponent<MeshRenderer>().enabled = false;
    }

    public override void Show()
    {
        trigger.enabled = true;
        GetComponent<MeshRenderer>().enabled = true;
    }
}
