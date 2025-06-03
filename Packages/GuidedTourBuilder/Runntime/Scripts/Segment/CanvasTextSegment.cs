using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

//[ExecuteAlways]
public class CanvasTextSegment : Segment
{
    TMP_Text textContainer;
    const float letterDelay = 0.2f;
    const float fixationDelay = 1.0f;
    bool playing = false;
    [SerializeField] string content;

    void OnEnable()
    {
        textContainer = GetComponentInChildren<TMP_Text>();
        textContainer.text = string.Empty;
    }
    public override void Activate()
    {
        playing = true;
        StartCoroutine(DisplayText());
    }

    public override bool IsPlaying()
    {
       return playing;
    }



    IEnumerator DisplayText()
    {
        textContainer.text = string.Empty;
        for (int i = 0; i < content.Length; i++) 
        {
            textContainer.text += content[i];
            yield return new WaitForSeconds(letterDelay);
        }

        yield return new WaitForSeconds(fixationDelay);
        textContainer.text = string.Empty;
        playing = false;
    }


    [ContextMenu("Play  in Edit Mode")]
    public void PlayTimeline()
    {
        Activate();
    }

    public override void Hide()
    {
        GetComponentInChildren<Canvas>().enabled = false;
        GetComponentInChildren<MeshRenderer>().enabled = false;

    }

    public override void Show()
    {
        GetComponentInChildren<Canvas>().enabled = true;
        GetComponentInChildren<MeshRenderer>().enabled = true;
    }
}
