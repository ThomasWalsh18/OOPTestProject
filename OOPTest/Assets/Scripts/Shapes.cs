using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Shapes : MonoBehaviour
{
    protected float speed { get; set; } //Encapsulation
    protected float jumpHeight = 1f;

    protected Rigidbody2D rigi2D;

    void Start()
    {
        rigi2D = this.GetComponent<Rigidbody2D>();
    }
    public Shapes()
    {
        
    }
    protected abstract void ability(); //POLYMORPHISUM

    public void movement()
    {
        //Movement of the player Spawner
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            rigi2D.AddForce(Vector2.left * speed);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            rigi2D.AddForce(Vector2.right * speed);
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            rigi2D.AddForce(Vector2.up * speed);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            rigi2D.AddForce(Vector2.down * speed);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            ability();
        }
    }

}
