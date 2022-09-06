using UnityEngine;
using UnityEngine.Events;

public class BaseEvents : MonoBehaviour
{
    public UnityEvent startEvent, awakeEvent, disableEvent, enableEvent, destroyEvent;

    public void Awake()
    {
        awakeEvent.Invoke();
    }

    public void Start()
    {
        startEvent.Invoke();
    }

    public void OnDisable()
    {
        disableEvent.Invoke();
    }

    public void OnEnable()
    {
        enableEvent.Invoke();
    }

    public void OnDestroy()
    {
        destroyEvent.Invoke();
    }
}
