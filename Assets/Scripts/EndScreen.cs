using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndScreen : MonoBehaviour
{
    public static EndScreen instance {  get; private set; }

    CanvasGroup canvasGroup;

    // Start is called before the first frame update
    void Start()
    {
        canvasGroup = GetComponent<CanvasGroup>();
        instance = this;
    }

    public void TurnOn()
    {
        canvasGroup.alpha = 1;
    }
    
}
