using UnityEngine;
using TMPro;

public abstract class Shape : MonoBehaviour
{    
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

    protected abstract void DisplayText();

    protected void OnMouseDown()
    {
        DisplayText();
    }
}
