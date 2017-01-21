using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Misil {

    private GameObject target;
    private GameObject selfMisil;
    private float speed {get; set;}
    private float rotation {get; set;}

    public Misil(GameObject target, GameObject selfMisil)
    {
        this.target = target;
        this.selfMisil = selfMisil;
    }

    private void onCollision()
    {

    }

    public void followTarget()
    {

    }

    public void destroyMissile()
    {

    }
    
        
}
