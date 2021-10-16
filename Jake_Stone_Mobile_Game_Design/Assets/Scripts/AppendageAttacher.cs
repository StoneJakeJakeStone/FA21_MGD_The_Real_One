using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppendageAttacher : MonoBehaviour
{// code credit to Unity's YouTube page: https://www.youtube.com/watch?v=Q3u0x8VRJS4&t=111s
    public Rigidbody2D appendage; //opens up spot to insert dino spine (rotating green thing)
    public Transform pos; //point-of-shoot, not "piece of sh*t"
    public List<Rigidbody2D> bunkus = new List<Rigidbody2D>(); //list of dino pieces
    public List<Rigidbody2D> skrinkle = new List<Rigidbody2D>(); //list of dino pieces to be added to spine until completion 
    private int spinos = 0; // sets the amount of spinos attached to '0'
    public int spinosb4APP; //the amount of spinos to be added to the green spine before you can start adding other pieces

    void Update() //I'd like to thank Christian Hotte for the programming assistance
    {
        if (Input.GetButtonDown("Jump")) //this wacky 'if' statement takes in player input, fires a dino piece onto the rotating spine, & adds said piece to a list in the inspector
        {
            Rigidbody2D pieceShoooter;
            if (spinos >= spinosb4APP)
            {   
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
            pieceShoooter.AddForce(pos.position * -200f);
            bunkus.Add(pieceShoooter); //makes list of projectiles
        }



    }
}
