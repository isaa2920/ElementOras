namespace ElementOras.element;

public static class ElementWorld
{
    public enum Elements
    {
        Air,
        Test,
        CoolerTest
    }

    public struct ScreenCoordinates
    {
        public int X;
        public int Y;
    }

    public static ScreenCoordinates ElementIndexToPosition(int index)
    {
        ScreenCoordinates coords;
        int indexX = index;
        while (indexX > GridSizeX)
        {
            indexX -= GridSizeX;
        }
        coords.X = indexX;

        int indexY = index;
        indexY -= indexX;
        indexY /= GridSizeX;

        coords.Y = indexY;
        return coords;
    }

    public const int GridSizeX = Program.WindowSizeX / 4; // 200
    public const int GridSizeY = Program.WindowSizeY / 4; // 120

    public const int GridTotal = GridSizeX * GridSizeY;

    public static Element[] elementGrid = new Element[GridTotal];

    public static void InitializeGrid()
    {
        for (int i = 0; i < GridTotal; i++)
        {
            element.Element currentElement = new();
            currentElement.element = Elements.Air;
            currentElement.arrayIndex = i;

            elementGrid[i] = currentElement;
        }
    }
}