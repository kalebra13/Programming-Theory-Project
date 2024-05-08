// INHERITANCE
public class Cube : Shape
{
    private void Start()
    {
        Color = "red";
    }

    // POLYMORPHISM
    protected override void DisplayText()
    {
        ShowText("I'm cube and my color is " + m_Color);
    }
}
