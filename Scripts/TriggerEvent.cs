using UnityEngine;
using UnityEngine.Events;

public class TriggerEvent : MonoBehaviour
{
    public UnityEvent triggerEnterEvent, triggerExitEvent;

    public void OnTriggerEnter(Collider other)
    {
        triggerEnterEvent.Invoke();
    }

    public void OnTriggerExit(Collider other)
    {
        triggerExitEvent.Invoke();
    }
}
