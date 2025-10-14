namespace ElementOras.element;

public static class ElementWorld
{
    public enum Elements
    {
        Test,
        CoolerTest
    }

    public const int GridTotal = Program.WindowSizeX * Program.WindowSizeY;

    public static Element[] elementGrid = new Element[GridTotal];
}