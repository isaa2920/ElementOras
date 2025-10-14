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
        Raylib.InitWindow(WindowSizeX, WindowSizeY, ApplicationName);

        Thread thread1 = new Thread(tick.TickSystem.TickLoop);
        thread1.Start();

        while (!Raylib.WindowShouldClose())
        {
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.White);

            Raylib.EndDrawing();
        }

        tick.TickSystem.doTickLoop = false;
        Raylib.CloseWindow();
    }
}