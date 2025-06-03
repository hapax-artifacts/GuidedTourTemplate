using UnityEngine;
using UnityEngine.Splines;


public class GuidedTourEngine : MonoBehaviour
{
    [SerializeField] bool VR; // third person, first person,....



    void Start()
    {
        var plotSequencer = GetComponentInChildren<PlotSequencer>();
        StartCoroutine(plotSequencer.PlayAllPlots());
    }



}
