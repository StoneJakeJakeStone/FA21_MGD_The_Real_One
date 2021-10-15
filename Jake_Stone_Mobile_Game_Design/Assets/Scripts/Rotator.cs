using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float bingusX; //this is the first project of mine you have been graced with witnessing
    public float bangusY; //so I fairly warn you,
    public float bongusZ; //get ready for some wacky naming conventions

    void Start()
    {
        Collider2D c2D = GetComponent<Collider2D>();
    }   
    
    void Update()
    {//credit to OXMOND Tutorials on YouTube https://www.youtube.com/channel/UC_XgDE8QykUBc17hl-X7CFg
        transform.Rotate(new Vector3(bingusX, bangusY, bongusZ) * Time.deltaTime); //this rotates the target
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "DinoSpine")
        {
            other.gameObject.transform.SetParent(transform);  //thank you Christian
            other.gameObject.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Kinematic;
            //other.gameObject.GetComponent<Rigidbody2D>().isKinematic = false;
            //other.gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            //other.gameObject.GetComponent<Rigidbody2D>().angularVelocity = 0;
            print("piece attached");
        }
    }

}
