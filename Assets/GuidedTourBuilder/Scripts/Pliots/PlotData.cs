using UnityEngine;

[CreateAssetMenu(fileName = "Plot", menuName = "Scriptable Objects/Plot")]
public class PlotData : MonoBehaviour
{
    [field: SerializeField] public Segment[] segments { get; private set; } = null;
}
