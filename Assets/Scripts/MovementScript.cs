using UnityEngine;

public class MovementScript : MonoBehaviour
{
    public Transform startMarker;
    public Transform endMarker;
    public float speed = 1.0F;

    private float startTime;
    private float journeyLength;
    private bool isMovingForwards = true; // might not be what I need to use

    void Start()
    {
        startTime = Time.time;

        journeyLength = Vector3.Distance(startMarker.position, endMarker.position); // this takes the numeric value for how different the two points are.
    }

    void Update()
    {
        float distCovered = (Time.time - startTime) * speed; // time subtract start time would be like 2 - 0. where it starts at 0, and you've took 2 seconds, so 2 x speed. That's why it gets faster with speed.

        float fractionOfJourney = distCovered / journeyLength; // that's why we can divide distCovered by journeyLength.

        transform.position = Vector3.Lerp(startMarker.position, endMarker.position, fractionOfJourney);

        //transform.position = startMarker.position + (endMarker.position - startMarker.position) * journeyLength * speed;

        if (isMovingForwards)
        {
            transform.position = Vector3.Lerp(startMarker.position, endMarker.position, fractionOfJourney);

            if (fractionOfJourney >= 1f)
            {
                isMovingForwards = false;

                startTime = Time.time;
            }
        }
        else
        {
            transform.position = Vector3.Lerp(endMarker.position, startMarker.position, fractionOfJourney);

            if (fractionOfJourney >= 1f)
            {
                isMovingForwards = true;

                startTime = Time.time; // reset timer for the next forward trip
            }
        }
    }
}

