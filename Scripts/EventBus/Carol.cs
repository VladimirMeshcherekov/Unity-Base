using UnityEngine;

public class Carol : MonoBehaviour
{
    public EventBus EventBus;

    private void Start()
    {
        EventBus.Subscribe<TestValueSignal>(GetSignal, 0);
    }

    static void GetSignal(TestValueSignal signal)
    {
       
        Debug.Log( signal.Value + "C");
    }
}
