using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
TODO: DETECTOR WITH https://docs.unity3d.com/ScriptReference/Physics.OverlapSphere.html + STEPBACK

FUCK THE BALL

 */


public class Movement : MonoBehaviour
{
    public float movementSpeed = 50.0f;
    public GameObject Detector;

    private Vector3 moveDir = new Vector3();
    private bool moving = false;
    // Update is called once per frame
    void Update()
    {
        if (!moving){
            // if not moving
            if (Input.GetKeyDown("w")){
                moveDir = transform.forward;
                moving = true;
                
                
            }
        }
        if (moving){
            // if moving
            transform.position += moveDir * Time.deltaTime * movementSpeed;
            Detector.transform.position = transform.position + (moveDir * Time.deltaTime * movementSpeed)*2;

        }
    }

    //Detect collisions between the GameObjects with Colliders attached
    void OnCollisionEnter(Collision collision)
    {
        //Check for a match with the specific tag on any GameObject that collides with your GameObject
        if (collision.gameObject.tag != "noclip")
        {
            moving = false;
            Detector.transform.position = transform.position;
        }
    }
}
