using UnityEngine;

public class Player : MonoBehaviour
{
    private int i = 0;
    private ThreadingTimer timer;

    private void Start()
    {
        timer = new ThreadingTimer(FunctionThatCalledByTimer, 1000, true);
        timer.StartTimer();
    }

    private void FunctionThatCalledByTimer()
    {
        i++;
        print(i);
        gameObject.transform.position = new Vector3(0, 0, i); // not available
    }

    private void OnDisable()
    {
        timer.StopTimer();
    }
}