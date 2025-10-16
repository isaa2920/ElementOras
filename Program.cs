using ElementOras.element;
using Raylib_cs;

namespace ElementOras;

internal static class Program
{
    public const int WindowSizeX = 800;
    public const int WindowSizeY = 480;
    public const string ApplicationName = "ElementOras";

    [System.STAThread]
    public static void Main()
    {
        ElementWorld.InitializeGrid();
        ElementTesting.AddRandomElements();

        Raylib.InitWindow(WindowSizeX, WindowSizeY, ApplicationName);

        Thread thread1 = new(tick.TickSystem.TickLoop);
        thread1.Start();

        while (!Raylib.WindowShouldClose())
        {
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.White);

            foreach (element.Element currentElement in ElementWorld.elementGrid)
            {
                //Raylib.ClearBackground(Color.White);

                ElementWorld.ScreenCoordinates coords = ElementWorld.ElementIndexToPosition(currentElement.arrayIndex);
                Color currentColor = ElementVisuals.GetElementColour(currentElement.element);
                Raylib.DrawRectangle(coords.X * 4, coords.Y * 4, 4, 4, currentColor);
            }

            Raylib.EndDrawing();
        }

        tick.TickSystem.doTickLoop = false;
        Raylib.CloseWindow();
    }
}