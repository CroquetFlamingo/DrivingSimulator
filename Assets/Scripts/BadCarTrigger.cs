using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadCarTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.CompareTag("Player"))
        {
            BadCar.StartMoving();
        }
    }


}
