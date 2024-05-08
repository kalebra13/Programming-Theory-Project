using UnityEngine;
using TMPro;

public abstract class Shape : MonoBehaviour
{
    // ENCAPSULATION
    protected static TextMeshProUGUI m_textToDisplay { get; private set; }
    protected string m_Color;
    public string Color { 
        get { return m_Color; }
        set {
            if (value.GetType() != typeof(string))
            {
                Debug.LogError("You can set color only by string type");
            }
            else
            {
                m_Color = value;
            }
        }
    }

    private void Awake()
    {
        m_textToDisplay = GameObject.FindGameObjectWithTag("Text").GetComponent<TextMeshProUGUI>();        
    }

    // POLYMORPHISM
    protected abstract void DisplayText();

    protected void OnMouseDown()
    {
        DisplayText();
    }

    // ABSTRACTION
    protected void ShowText(string text)
    {
        m_textToDisplay.SetText(text);
    }
}
