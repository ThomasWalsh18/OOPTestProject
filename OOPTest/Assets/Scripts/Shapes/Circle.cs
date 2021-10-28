using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : Shapes
{
    Circle()
    {
        speed = 200;
    }
    protected override void ability()
    {

    }
    void Update()
    {
        movement(); //Inheritance
    }
}
