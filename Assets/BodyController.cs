using UnityEngine;

public class BodyController : MonoBehaviour
{

    float radius = 6f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 deltaDisplacement = Vector2.zero;

        if (Input.GetKey(KeyCode.UpArrow))
        {
            deltaDisplacement += new Vector2(0, 1);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            deltaDisplacement += new Vector2(0, -1);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            deltaDisplacement += new Vector2(-1, 0);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            deltaDisplacement += new Vector2(1, 0);
        }


        Vector2 currentPos = new (transform.localPosition.x, transform.localPosition.z) ;
        Vector2 newPos = currentPos + deltaDisplacement;

        if (newPos.magnitude < radius)
        { 
            transform.position += new Vector3 (deltaDisplacement.x * Time.deltaTime, 0, deltaDisplacement.y * Time.deltaTime) ;
        }


    }
}
