﻿using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE___1B___Part_1
{
    public class Position 
    {
        private int _xCoordinate;//Carrying the x-coodinates
        private int _yCoordinate;//Carrying the y-coordinates;

        //Create properties that will set and return the fields back to the user
        public int XCoordinate { get { return _xCoordinate; } }
        public int YCoordinate { get { return _yCoordinate; } }

        public Position(int xValue, int yValue) 
        {
            //Set the arguments to the corresponding fields
            _xCoordinate = xValue;
            _yCoordinate = yValue;
        }
    }
}
