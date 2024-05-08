public class Sphere : Shape
{
    private void Start()
    {
        Color = "green";
    }

    protected override void DisplayText()
    {
        m_textToDisplay.SetText("I am cute sphere and " + m_Color + " is my favorite color");
    }
}
