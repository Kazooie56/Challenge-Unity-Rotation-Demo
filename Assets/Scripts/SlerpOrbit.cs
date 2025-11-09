using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class SlerpOrbit : MonoBehaviour
{
    public Transform CubeToOrbit;
    //public Transform upTarget;

    public float speed = 1f;

    // Update is called once per frame
    void Update()
    {
        Vector3 directionToThing = CubeToOrbit.position - transform.position; 

        //Vector3 upDirection = upTarget.position - transform.position;

        Quaternion WhereIShouldRotate = Quaternion.LookRotation(directionToThing); //might not need upDirection //nvm don't need up at all

        transform.rotation = Quaternion.Slerp(transform.rotation, WhereIShouldRotate, speed * Time.deltaTime); // our rotation is equal to our rotation, then where it should be, then at the speed of speed x Time.deltaTime

        transform.Translate(Vector3.forward * speed * Time.deltaTime); //forward is z, up is y, and x is right which doesnt make much sense but what can you do. The object moves towards the object and then does what the instructions say so i hope that's okay.
    }
}
