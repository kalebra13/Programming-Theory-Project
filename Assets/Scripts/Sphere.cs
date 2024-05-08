// INHERITANCE
public class Sphere : Shape
{
    private void Start()
    {
        Color = "green";
    }

    // POLYMORPHISM
    protected override void DisplayText()
    {
        ShowText("I am cute sphere and " + m_Color + " is my favorite color");
    }
}
