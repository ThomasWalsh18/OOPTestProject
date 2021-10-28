using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : Shapes
{
    Square()
    {
        speed = 150;
    }
    protected override void ability()
    {

    }

    void Update()
    {
        movement();
    }
}
