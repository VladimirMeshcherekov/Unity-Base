using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alice : MonoBehaviour
{
    public EventBus EventBus;
    void Start()
    {
        EventBus.Invoke(new TestValueSignal(1));
    }
    
}
