using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum State
{
    //animation states
    Idle,
    Run,
    Jump
    



}


public enum Layer
{
    //layers
    Default = 0,
    TransparentFx,
    IgnoreRaycast,
    Water = 4,
    UI,
    Unmoving= 8,
    Entities,
    Foreground
}