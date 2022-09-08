using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class DragableBehavior : MonoBehaviour
{
    private Camera cameraObj;
    public bool dragable;
    public Vector3 pos, offset;
    public UnityEvent startDragEvent, endDragEvent;
    void Start()
    {
        cameraObj = Camera.main;
    }

    public IEnumerator OnMouseDown()
    {
        offset = transform.position - cameraObj.ScreenToWorldPoint(Input.mousePosition);
        
        startDragEvent.Invoke();
        
        yield return new WaitForFixedUpdate();
        
        dragable = true;
        
        while (dragable)
        {
            yield return new WaitForFixedUpdate();
            pos = cameraObj.ScreenToWorldPoint(Input.mousePosition) + offset;
            transform.position = pos;
        }
    }

    public void OnMouseUp()
    {
        dragable = false;
        endDragEvent.Invoke();
    }
}
