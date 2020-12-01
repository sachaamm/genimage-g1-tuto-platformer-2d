using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CaptureFrameRate : MonoBehaviour
{
    public Text FrameRateText;
    
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(FrameRateText) FrameRateText.text = "FR: " + Time.deltaTime;
    }
}
