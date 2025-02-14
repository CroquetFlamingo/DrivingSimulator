using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadCar : EnemyScript
{
    static bool moving = false;
    static float speed = 15f;
    
    // Start is called before the first frame update
    void Start()
    {
        moving = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(moving)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed, Space.Self);
        }
    }

    public static void StartMoving()
    {
        moving = true;
    }
}
