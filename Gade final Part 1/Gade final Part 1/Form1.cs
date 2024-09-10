﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gade_final_Part_1
{
    public partial class Form1 : Form
    {
        private GameEngine engine;

        public Form1()
        {
            InitializeComponent();
            int gameLvls = 10;
            //Initialize the instance varivble
            engine = new GameEngine(gameLvls);

            //Call the method to hold the function to display
            UpdateDisplay();

            // Enable keyboard input
            this.KeyPreview = true;
            // Hook up event handlers for buttons
            btnUp.Click += btnUp_Click;
            btnDown.Click += btnDown_Click;
            btnLeft.Click += btnLeft_Click;
            btnRight.Click += btnRight_Click;
        }
        public void UpdateDisplay()
        {
            if (engine != null)
            {
                //Set the label to a string message
                lblDisplay.Text = engine.ToString();
            }
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            MoveHero(Level.Direction.Up);
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            MoveHero(Level.Direction.Right);
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            MoveHero(Level.Direction.Left);

        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            MoveHero(Level.Direction.Down);

        }
        private void MoveHero(Level.Direction direction)
        {
            // Ensure engine is not null before calling TriggerMovement()
            if (engine != null)
            {
                engine.TriggerMovement(direction);
                UpdateDisplay();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
