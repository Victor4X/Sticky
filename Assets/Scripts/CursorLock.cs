using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorLock : MonoBehaviour
{
    private int cooldown = 0;
    // Update is called once per frame
    void Update()
    {
        if (cooldown <= 0) {
            if (Input.GetKey(KeyCode.Space)){
                if (Cursor.lockState == CursorLockMode.None){
                    Cursor.lockState = CursorLockMode.Locked;
                }else{
                    Cursor.lockState = CursorLockMode.None;
                }
                cooldown = 10;
            }
        }else{
            cooldown--;
        }
    }
}
