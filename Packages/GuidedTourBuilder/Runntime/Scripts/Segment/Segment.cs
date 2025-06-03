using UnityEngine;

public abstract class Segment : MonoBehaviour
{
   // static protected GuidedTourEngine guidedTourEngine;


    private void OnEnable()
    {
        if (HideOnPreActivate) Hide();
    }

    // Tiempos de espera
    [field: SerializeField] public float preDelay { get; private set; } = 0;
    [field: SerializeField] public float postDelay { get; private set; } = 0;

    [field: SerializeField] public bool  HideOnPreActivate { get; private set; } = false;

    [field: SerializeField] public bool HideOnPostActivate { get; private set; } = false;

    public virtual void PreActivate()
    {
        if (HideOnPreActivate) Show();
    }

    public abstract void Activate();

    public abstract bool IsPlaying();

    public virtual void PostActivate()
    {
        if (HideOnPostActivate) Hide();
    }

    public abstract void Hide();
    

public abstract void Show();
    


}
