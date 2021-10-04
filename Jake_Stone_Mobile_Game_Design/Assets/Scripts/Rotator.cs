using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float bingus; //this is the first project of mine you have been graced with witnessing
    public float bangus; //so I fairly warn you,
    public float bongus; //get ready for some wacky naming conventions
    
    void Update()
    {//credit to OXMOND Tutorials on YouTube https://www.youtube.com/channel/UC_XgDE8QykUBc17hl-X7CFg
        transform.Rotate(new Vector3(bingus, bangus, bongus) * Time.deltaTime); //this rotates the target
    }
}
