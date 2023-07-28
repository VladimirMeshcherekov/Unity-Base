using UnityEngine;

public class Player : MonoBehaviour
{
    private int i = 0;
    private AsyncTimer timer;

    private void Start()
    {
        timer = new AsyncTimer(FunctionThatCalledByTimer, 1000, true);
        timer.StartTimer();
    }

    private void FunctionThatCalledByTimer()
    {
        i++;
        print(i);
        gameObject.transform.position = new Vector3(0, 0, i); // available
    }

    private void OnDisable()
    {
        timer.StopTimer();
    }
}