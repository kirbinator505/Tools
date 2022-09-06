using UnityEngine;
using UnityEngine.UI;

public class FloatSO : ScriptableObject
{
    public float value;

    public void AddValue(float num)
    {
        value += num;
    }

    public void SubtractValue(float num)
    {
        value -= num;
    }

    public void SetValue(float num)
    {
        value = num;
    }

    public void DisplayText(Text txt)
    {
        txt.text = value.ToString();
    }
}
