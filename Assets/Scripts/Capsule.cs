public class Capsule : Shape
{
    private void Start()
    {
        Color = "yellow";
    }

    protected override void DisplayText()
    {
        m_textToDisplay.SetText("I am massive " + m_Color + " capsule");
    }
}
