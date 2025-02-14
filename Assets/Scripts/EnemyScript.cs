using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyScript : MonoBehaviour
{


    private void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.CompareTag("Player"))
        {

            SceneManager.LoadScene(0);
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
