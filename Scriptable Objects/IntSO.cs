using UnityEngine;
using UnityEngine.UI;

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

    public void DisplayText(Text txt)
    {
        txt.text = value.ToString();
    }
}
