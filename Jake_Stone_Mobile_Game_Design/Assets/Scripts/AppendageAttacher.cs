using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppendageAttacher : MonoBehaviour
{// code credit to Unity's YouTube page: https://www.youtube.com/watch?v=Q3u0x8VRJS4&t=111s
    public Rigidbody2D appendage; //opens up spot to insert dino pieces
    public Transform pos; //point-of-shoot, not "piece of sh*t"
    public List<Rigidbody2D> bunkus = new List<Rigidbody2D>();
    public List<Rigidbody2D> skrinkle = new List<Rigidbody2D>();
    private int spinos = 0;
    public int spinosb4APP;

    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            Rigidbody2D pieceShoooter;
            if (spinos >= spinosb4APP)
            {   
                //spinos = 0;
                if (skrinkle.Count == 0)
                {

                    return;
                }
                pieceShoooter = Instantiate(skrinkle[0], pos.position, pos.rotation) as Rigidbody2D;
                skrinkle.RemoveAt(0);
            }
            else
            {
                pieceShoooter = Instantiate(appendage, pos.position, pos.rotation) as Rigidbody2D;
                spinos++;
            }
            //pieceShoooter = Instantiate(appendage, pos.position, pos.rotation) as Rigidbody2D; creates individual appendages to shoot at target
            pieceShoooter.AddForce(pos.position * -200f);
            bunkus.Add(pieceShoooter); //makes list of projectiles
        }



    }
}
