using UnityEngine;

public class RigController : MonoBehaviour
{
    SplineFollower splineFollower;

    private void Awake()
    {
        splineFollower = GetComponent<SplineFollower>();
    }

    public void Teleport(Transform target)
    {
        splineFollower.splineContainer = null;
        Debug.Log("Telepor");
        transform.position = target.position;
    }
}
