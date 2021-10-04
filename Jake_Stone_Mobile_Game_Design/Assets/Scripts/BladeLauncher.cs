using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BladeLauncher : MonoBehaviour
{
    public GameObject bladedObject;

    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            Instantiate(bladedObject);
            
        }
    }
}
