using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu]
public class Vector3SO : ScriptableObject
{
    public Vector3 value;

    public void SetForeward()
    {
        value = Vector3.forward;
    }
    
    public void SetBack()
    {
        value = Vector3.back;
    }
    
    public void SetLeft()
    {
        value = Vector3.left;
    }
    
    public void SetRight()
    {
        value = Vector3.right;
    }

    public void SetVector3(Vector3 newVector)
    {
        value = newVector;
    }

    public void DisplayValue(Text txt)
    {
        txt.text = value.ToString();
    }
}
