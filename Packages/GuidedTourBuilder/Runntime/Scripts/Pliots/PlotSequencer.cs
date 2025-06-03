using System.Collections;
using UnityEngine;
using UnityEngine.Playables;

public class PlotSequencer : MonoBehaviour
{
    public PlotData[] plotData; 


    public IEnumerator PlayAllPlots()
    {

       foreach (var plot in plotData)
        {
            yield return StartCoroutine(PlayPlot(plot));
        }
    }

    private IEnumerator PlayPlot(PlotData plot)
    {
        foreach (var segment in plot.segments)
        {
            yield return StartCoroutine(PlaySegment(segment));
        }
    }

    private IEnumerator PlaySegment(Segment segment)
    {
        segment.PreActivate();

        if (segment.preDelay > 0)
        {
            yield return new WaitForSeconds(segment.preDelay); 
        }



        segment.Activate();
            while (segment.IsPlaying())
            {
                yield return null; 
            }

        if (segment.postDelay > 0)
        {
            yield return new WaitForSeconds(segment.postDelay); 
        }
        segment.PostActivate();
    }


}
