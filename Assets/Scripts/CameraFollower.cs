using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollower : MonoBehaviour
{
    [SerializeField] Transform follow;
    Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - follow.position; 
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = follow.position + offset;
    }
}
