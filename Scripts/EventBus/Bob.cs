using UnityEngine;

public class Bob : MonoBehaviour
{
    public EventBus EventBus;

    private void Start()
    {
        EventBus.Subscribe<TestValueSignal>(GetSignal, 1);
    }

    private void GetSignal(TestValueSignal signal)
    {
       
        Debug.Log( signal.Value + "B");
    }
}
