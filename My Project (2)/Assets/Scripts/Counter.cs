using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Counter : MonoBehaviour
{
    
    public int counterValue = 0;
    public static Counter Instance;
    public TMP_Text tmpText;
    // Start is called before the first frame update
    public void Awake()
    {
        Instance = this;
    }

    // Update is called once per frame
    public void IncreaseCounter()
    {
        counterValue++;
        tmpText.text = counterValue.ToString();
        
    }

    
}