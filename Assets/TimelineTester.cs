using UnityEngine;
using UnityEngine.Playables;
using UnityEditor;

public class TimelineTester : MonoBehaviour
{
    /*public*/ PlayableDirector director;
    /*public*/ double timeStep = 0.1; // Cuánto avanza la timeline por cada clic

    [ContextMenu("Play Timeline in Edit Mode")]
    public void PlayTimeline()
    {
        if (director == null) director = GetComponent<PlayableDirector>();
        director.time = 0; // Reiniciar la Timeline
        director.Evaluate(); // Evalúa el estado actual sin entrar en Play Mode
        Debug.Log("Timeline evaluada desde el inicio en Edit Mode.");
    }


}