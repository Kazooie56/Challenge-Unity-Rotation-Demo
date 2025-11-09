using UnityEngine;

public class SineWaveMovement : MonoBehaviour
{
    //Vector3 currentEulerAngles;
    //float x;
    //float y;
    //float z;

    [SerializeField]
    public float swaySpeed = 2f;     // swinging speed 

    public float swayDistance = 10f; // swinging distance

    void Update()
    {
        float Yaxis = Mathf.Sin(Time.time * swaySpeed) * swayDistance; // Dont multiply by swayDistance yet AND DO NOT USE DELTATIME
        
        //transform.position = new Vector3 (Mathf.Sin(Time.time * swaySpeed), transform.position.y, transform.position.z); // should this be x?

        transform.eulerAngles = new Vector3(0, Yaxis, 0); //eulers are those fighter pilot terms i think
    }
}
