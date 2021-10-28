using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsule : Shapes
{
    protected override void ability()
    {

    }
    Capsule()
    {
        speed = 100;
    }
    void Update()
    {
        movement();
    }
}
