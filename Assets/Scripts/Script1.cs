using UnityEngine;
using System.Collections;
using static UnityEngine.GraphicsBuffer;

public class Script1 : MonoBehaviour
{
    public Transform ThingToLookAt;
    public Transform upTarget;

    // public Transform from;
    // public Transform to;
    public float speed = 1f;

    // Update is called once per frame
    void Update()
    {
        Vector3 directionToThing = ThingToLookAt.position - transform.position;

        // the second argument, upwards, defaults to Vector3.up
        Quaternion rotation = Quaternion.LookRotation(directionToThing, upTarget.position);

        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * speed);

        //transform.rotation = rotation;

    }

    //void Update()
    //{
    //    transform.rotation = Quaternion.Slerp(transform.rotation, to.rotation, timeCount);
    //
    //    timeCount = timeCount + Time.deltaTime;
    //}

}
