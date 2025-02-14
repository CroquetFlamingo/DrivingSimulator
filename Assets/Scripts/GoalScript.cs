using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalScript : MonoBehaviour
{

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            if (EndScreen.instance != null)
            {
                EndScreen.instance.TurnOn();
            }
        }
    }

    private void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.CompareTag("Player"))
        {
            if(EndScreen.instance != null)
            {
                EndScreen.instance.TurnOn();
            }
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
