using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float mouseSensitivity = 1.0f;
    public bool bQuarter = false;

    private float vertical = 0f;
    private float horizontal = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (bQuarter){
            // If using Quarternions
            horizontal += Input.GetAxis ("Mouse X") * mouseSensitivity;
            vertical -= Input.GetAxis ("Mouse Y") * mouseSensitivity;

            transform.localRotation = (Quaternion.Euler(vertical, horizontal, 0));
        }else{
            // If not using Quarternions
            horizontal = Input.GetAxis ("Mouse X") * mouseSensitivity;
            vertical = -Input.GetAxis ("Mouse Y") * mouseSensitivity;

            transform.Rotate (vertical,horizontal,0);
        }

    }
}
