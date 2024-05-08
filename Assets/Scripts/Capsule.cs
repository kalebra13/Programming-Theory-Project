// INHERITANCE
public class Capsule : Shape
{
    private void Start()
    {
        Color = "yellow";
    }

    // POLYMORPHISM
    protected override void DisplayText()
    {
        ShowText("I am massive " + m_Color + " capsule");
    }
}
