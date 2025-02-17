// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D;

/// <summary>
///     Your game code goes inside this class!
/// </summary>
public class Game
{
    // Place your variables here:

    //Colour variables
    Color almostBlack = new Color("030206");
    Color deepestBlue = new Color("070918");
    Color deepBlue = new Color("0f052d");
    //Color navy = new Color("203671");
    //Color babyBlue = new Color("36b5f5");
    Color neonBlue = new Color("3afffb");
    Color teal = new Color("36868f");
    Color green = new Color("5fc75d");
    Color neonGreen = new Color("83c16f");

    // Declare a variable to store the current wave color
    Color currentWaveColor = new Color("0f052d"); // deepBlue
    Color currentWaveColor2 = new Color("36868f"); // teal
    Color currentWaveColor3 = new Color("3afffb"); // neonBlue
    Color currentWaveColor4 = new Color("83c16f"); // neonGreen

    int waveColorIndexes = 0;
    Color[] waveColors = { Color.Blue, Color.Green, Color.Red, Color.Yellow };
    

    //Star variables
    int starCount = 40;
    int[] starPositionsX;
    int[] starPositionsY;

    //Dock variables???

    /// <summary>
    ///     Setup runs once before the game loop begins.
    /// </summary>
    public void Setup()
    {
        Window.SetTitle("Ocean Scene");
        Window.SetSize(400, 400);
        Draw.LineSize = 0;

        // Generate random star positions
        // First, initialize the array to contain a certain number of elements
        starPositionsX = new int[starCount];
        starPositionsY = new int[starCount];
        // Next, go through array and assign each index a value
        for (int i = 0; i < starCount; i++)
        {
            starPositionsX[i] = Random.Integer(0, 400); // x = 0-400
            starPositionsY[i] = Random.Integer(0, 300); // y = 0-300
        }
    }

    /// <summary>
    ///     Update runs every frame.
    /// </summary>
    public void Update()
    {
        //Draw sky
        Window.ClearBackground(almostBlack);

        //Draw moon
        Draw.FillColor = neonBlue;
        Draw.LineColor = deepBlue;
        Draw.LineSize = 3;
        Draw.Circle(320, 80, 50);

        //Draw stars
        Draw.FillColor = neonBlue;
        Draw.LineColor = green;
        for (int i = 0; i < starCount; i++)
        {
            Draw.Circle(starPositionsX[i], starPositionsY[i], 1);
            Draw.LineSize = 3;
        }

        // Making the waves cycle through colours when the user presses spacebar

        // Check if the space bar is pressed (getting player input)
        bool hasPressedSpacebar = Input.IsKeyboardKeyPressed(KeyboardInput.Space);

        // Only change the color if the space bar is pressed
        //changing colours of waves - troubleshooting

        // Change Color of Circle when Enter is pressed
        if (Input.IsKeyboardKeyPressed(KeyboardInput.Enter))
        {
            wavecolorIndexes = (wavecolorIndexes + 1) % waveColors.Length; // Cycle through the colors
        }

        //if (hasPressedSpacebar)

        //{
        //    if (currentWaveColor == deepBlue)
        //    {
        //        currentWaveColor = teal; return;
        //    }
        //    if (currentWaveColor2 == teal)
        //    {
        //        currentWaveColor2 = neonBlue; return;
        //    }
        //    if (currentWaveColor3 == neonBlue)
        //    {
        //        currentWaveColor3 = neonGreen; return;
        //    }
        //    if (currentWaveColor4 == neonGreen)
        //    {
        //        currentWaveColor3 = deepBlue; return;
        //    }
        //}

        //// weeeeee Colors to cycle through
        //Color[] waveColors = { deepBlue, teal, neonBlue, neonGreen };

        //// Indexes for each wave color
        //int[] waveColorIndexes = { 0, 1, 2, 3 };

        //// Check if the space bar is pressed (getting player input)
        //bool hasPressedSpacebar = Input.IsKeyboardKeyPressed(KeyboardInput.Space);

        //if (hasPressedSpacebar)
        //{
        //    // Cycle through the colors for each wave
        //    for (int i = 0; i < waveColorIndexes.Length; i++)
        //    {
        //        // Update each wave color based on its index
        //        waveColorIndexes[i] = (waveColorIndexes[i] + 1) % waveColors.Length;

        //        // Assign the new color to the wave
        //        if (i == 0)
        //            currentWaveColor = waveColors[waveColorIndexes[i]];
        //        else if (i == 1)
        //            currentWaveColor2 = waveColors[waveColorIndexes[i]];
        //        else if (i == 2)
        //            currentWaveColor3 = waveColors[waveColorIndexes[i]];
        //        else if (i == 3)
        //            currentWaveColor4 = waveColors[waveColorIndexes[i]];
        //    }
        //}


        // Draw furthest background waves
        Draw.FillColor = currentWaveColor4; // deepestBlue
        Draw.LineColor = almostBlack;
        Draw.LineSize = 1;
        for (int i = 0; i < 35; i++)
        {
            int x = 6 + i * 12;
            Draw.Circle(x, Window.Height - 120, 14);
        }

        // Draw background waves
        Draw.FillColor = currentWaveColor3; // neonBlue
        Draw.LineColor = almostBlack;
        Draw.LineSize = 1;
        for (int i = 0; i < 16; i++)
        {
            int x = 12 + i * 25;
            Draw.Circle(x, Window.Height - 100, 19);
        }

        // Draw midground waves
        Draw.FillColor = currentWaveColor2; // teal
        Draw.LineColor = almostBlack;
        Draw.LineSize = 1;
        for (int i = 0; i < 8; i++)
        {
            int x = 25 + i * 50;
            Draw.Circle(x, Window.Height - 65, 38);
        }

        // Draw foreground waves
        Draw.FillColor = currentWaveColor; // deepBlue 
        Draw.LineColor = almostBlack;
        Draw.LineSize = 1;
        for (int i = 0; i < 4; i++)
        {
            int x = 50 + i * 100;
            Draw.Circle(x, Window.Height, 75);
        }

        //Draw rectangle for dock instead cause lines kinda look goofy
        //Draw dock platform
        Draw.FillColor = neonGreen;
        Draw.LineColor = almostBlack;
        Draw.LineSize = 1;
        Draw.Rectangle(0, 245, 200, 15);

        //Draw right dock pillar
        Draw.FillColor = neonGreen;
        Draw.LineColor = almostBlack;
        Draw.LineSize = 1;
        Draw.Rectangle(180, 240, 15, 240);

        //Draw middle dock pillar
        Draw.FillColor = neonGreen;
        Draw.LineColor = almostBlack;
        Draw.LineSize = 1;
        Draw.Rectangle(90, 240, 15, 240);

        //Draw left dock pillar
        Draw.FillColor = neonGreen;
        Draw.LineColor = almostBlack;
        Draw.LineSize = 1;
        Draw.Rectangle(0, 240, 15, 240);

    }
}

// adding a fish to that follows the mouse
//Vector2 position = Input.GetMousePosition();