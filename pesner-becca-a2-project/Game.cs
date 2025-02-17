﻿// Include the namespaces (code libraries) you need below.
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
    Color navy = new Color("203671");
    Color babyBlue = new Color("36b5f5");
    Color neonBlue = new Color("3afffb");
    Color teal = new Color("36868f");
    Color green = new Color("5fc75d");
    Color neonGreen = new Color("83c16f");

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
        Window.SetTitle("Fishing");
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
        Window.ClearBackground(deepestBlue);

        //Draw moon
        Draw.FillColor = neonBlue;
        Draw.LineColor = almostBlack;
        Draw.LineSize = 1;
        Draw.Circle(320, 60, 50);

        //Draw stars
        Draw.FillColor = neonBlue;
        Draw.LineColor = green;
        for (int i = 0; i < starCount; i++)
        {
            Draw.Circle(starPositionsX[i], starPositionsY[i], 1);
            Draw.LineSize = 3;
        }

        //// Declare a variable to store the current wave color
        //Color currentWaveColor = deepBlue;

        //// Check if the space bar is pressed
        //bool hasPressedSpacebar = Input.IsKeyboardKeyPressed(KeyboardInput.Space);

        //// Only change the color if the space bar is pressed
        //if (hasPressedSpacebar)
        //{
        //    // Change the color to the next one in the sequence
        //    if (currentWaveColor == deepBlue)
        //    {
        //        currentWaveColor = navy;
        //    }
        //    else if (currentWaveColor == navy)
        //    {
        //        currentWaveColor = teal;
        //    }
        //    else if (currentWaveColor == teal)
        //    {
        //        currentWaveColor = deepBlue;
        //    }
        //}

        //// Draw furthest background waves
        //Draw.FillColor = currentWaveColor; // deepBlue
        //Draw.LineColor = almostBlack;
        //Draw.LineSize = 1;
        //for (int i = 0; i < 35; i++)
        //{
        //    int x = 6 + i * 12;
        //    Draw.Circle(x, Window.Height - 120, 14);
        //}

        //// Draw background waves
        //Draw.FillColor = currentWaveColor; // navy
        //Draw.LineColor = almostBlack;
        //Draw.LineSize = 1;
        //for (int i = 0; i < 16; i++)
        //{
        //    int x = 12 + i * 25;
        //    Draw.Circle(x, Window.Height - 100, 19);
        //}

        //// Draw midground waves
        //Draw.FillColor = currentWaveColor; // teal
        //Draw.LineColor = almostBlack;
        //Draw.LineSize = 1;
        //for (int i = 0; i < 8; i++)
        //{
        //    int x = 25 + i * 50;
        //    Draw.Circle(x, Window.Height - 65, 38);
        //}

        //// Draw foreground waves
        //Draw.FillColor = currentWaveColor; // deepBlue
        //Draw.LineColor = almostBlack;
        //Draw.LineSize = 1;
        //for (int i = 0; i < 4; i++)
        //{
        //    int x = 50 + i * 100;
        //    Draw.Circle(x, Window.Height, 75);
        //}

        //Draw furthest background waves
        Draw.FillColor = deepBlue;
        Draw.LineColor = almostBlack;
        Draw.LineSize = 1;
        for (int i = 0; i < 35; i++)
        {
            int x = 6 + i * 12;
            Draw.Circle(x, Window.Height - 120, 14);
        }

        //Draw background waves
        Draw.FillColor = navy;
        Draw.LineColor = almostBlack;
        Draw.LineSize = 1;
        for (int i = 0; i < 16; i++)
        {
            int x = 12 + i * 25;
            Draw.Circle(x, Window.Height - 100, 19);
        }

        //Draw midground waves
        Draw.FillColor = teal;
        Draw.LineColor = almostBlack;
        Draw.LineSize = 1;
        for (int i = 0; i < 8; i++)
        {
            int x = 25 + i * 50;
            Draw.Circle(x, Window.Height - 65, 38);
        }

        ////Draw dock platform
        //Vector2 startPos = new Vector2(0, 240);
        //Vector2 endPos = new Vector2(200, 240);
        //Draw.LineColor = neonGreen;
        //Draw.LineSize = 10;
        //Draw.Line(startPos.X, startPos.Y, endPos.X, endPos.Y);

        ////Draw dock platform part 2
        //Vector2 startPos2 = new Vector2(0, 260);
        //Vector2 endPos2 = new Vector2(200, 260);
        //Draw.LineColor = neonGreen;
        //Draw.LineSize = 10;
        //Draw.Line(startPos2.X, startPos2.Y, endPos2.X, endPos2.Y);

        ////Draw dock pillars
        //Vector2 startPos3 = new Vector2(80, 260);
        //Vector2 endPos3 = new Vector2(80, 400);
        //Draw.LineColor = neonGreen;
        //Draw.LineSize = 10;
        //Draw.Line(startPos3.X, startPos3.Y, endPos3.X, endPos3.Y);

        ////Draw dock pillars
        //Vector2 startPos4 = new Vector2(100, 260);
        //Vector2 endPos4 = new Vector2(100, 400);
        //Draw.LineColor = neonGreen;
        //Draw.LineSize = 10;
        //Draw.Line(startPos4.X, startPos4.Y, endPos4.X, endPos4.Y);

        ////Draw dock pillars
        //Vector2 startPos5 = new Vector2(180, 260);
        //Vector2 endPos5 = new Vector2(180, 400);
        //Draw.LineColor = neonGreen;
        //Draw.LineSize = 10;
        //Draw.Line(startPos5.X, startPos5.Y, endPos5.X, endPos5.Y);

        ////Draw dock pillars
        //Vector2 startPos6 = new Vector2(200, 240);
        //Vector2 endPos6 = new Vector2(200, 400);
        //Draw.LineColor = neonGreen;
        //Draw.LineSize = 10;
        //Draw.Line(startPos6.X, startPos6.Y, endPos6.X, endPos6.Y);

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

        //Draw foreground waves
        Draw.FillColor = deepBlue;
        Draw.LineColor = almostBlack;
        Draw.LineSize = 1;
        for (int i = 0; i < 4; i++)
        {
            int x = 50 + i * 100;
            Draw.Circle(x, Window.Height, 75);
        }


    }
}
