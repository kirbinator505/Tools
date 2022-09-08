using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[CreateAssetMenu]
public class IntSO : ScriptableObject
{
    public int value;

    public void AddValue(int number)
    {
        value += number;
    }

    public void SubtractValue(int number)
    {
        value -= number;
    }

    public void SetValue(int number)
    {
        value = number;
    }

    public void SetValue(IntSO data)
    {
        value = data.value;
    }

    public void DisplayText(Text txt)
    {
        txt.text = value.ToString();
    }

    public void CompareValue(IntSO data)
    {
        if (data.value > value)
        {
            value = data.value;
        }
    }
}
