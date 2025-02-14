using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VehicleController : MonoBehaviour
{
    Vector3 moveDir;
    [SerializeField] float maxSpeed = 5;
    [SerializeField] float steerSpeed = 2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moveDir.x = Input.GetAxis("Horizontal") * steerSpeed;
        moveDir.z = Input.GetAxis("Vertical") * maxSpeed;

        transform.Translate(moveDir * Time.deltaTime, Space.Self);

        if(Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(0);
        }
    }
}
