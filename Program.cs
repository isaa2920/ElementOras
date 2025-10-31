using Raylib_cs;

namespace ElementOras;

internal static class Program
{
    public const int WindowSizeX = 800;
    public const int WindowSizeY = 608;
    public const string ApplicationName = "ElementOras";

    [System.STAThread]
    public static void Main()
    {
        ElementWorld.InitializeGrid();
        //ElementTesting.AddRandomElements();

        Raylib.InitWindow(WindowSizeX, WindowSizeY, ApplicationName);

        Thread thread1 = new(TickSystem.TickLoop);
        thread1.Start();

        Raylib.SetTargetFPS(50);
        Raylib.HideCursor();

        while (!Raylib.WindowShouldClose())
        {
            
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.White);

            foreach (Element currentElement in ElementWorld.elementGrid)
            {
                ElementWorld.ScreenCoordinates coords = ElementWorld.ElementIndexToPosition(currentElement.arrayIndex);
                Color currentColor = ElementVisuals.GetElementColour(currentElement.element);
                Raylib.DrawRectangle(coords.X * 4 - 4, coords.Y * 4 + 128, 4, 4, currentColor);
            }
            UI.DrawUI();
            Cursor.DrawCursor();

            Raylib.EndDrawing();
        }

        TickSystem.doTickLoop = false;
        Raylib.CloseWindow();
    }
}