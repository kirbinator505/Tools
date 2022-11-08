using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu]
public class BoolSO : ScriptableObject
{
    public bool value;

    public void SetTrue()
    {
        value = true;
    }

    public void SetFalse()
    {
        value = false;
    }

    public void DisplayValue(Text txt)
    {
        txt.text = value.ToString();
    }
}
