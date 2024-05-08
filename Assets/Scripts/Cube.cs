public class Cube : Shape
{
    private void Start()
    {
        Color = "red";
    }
    protected override void DisplayText()
    {
        m_textToDisplay.SetText("I'm cube and my color is " + m_Color);
    }
}
