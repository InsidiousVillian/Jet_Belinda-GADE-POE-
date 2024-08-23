using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE___1B___Part_1
{
    internal abstract class Tile
    {
        //Instatiate a field
        public int typePosition { get; private set; }

        //Set Properties that will display the coordinates and each tile as a character
        public abstract int X_Coordinate();
        public abstract int Y_Coordinate();
        public abstract char Display { get; }

        //Set a constructor that accepts a parameter and assigns it tot the position class field
        protected Tile(int positionType)
        {
            //Assign the argument to the field
            typePosition = positionType;
        }
    }
    //Create a new class
    internal class EmptyTile : Tile
    {
        public int parameterPosition;
        private readonly int _yCoordinate;
        private readonly int _xCoordinate;

        //Set a constructor that will use the argument PositionParameter
        public EmptyTile(int positionParameter, int xCoordinate, int yCoordinate) : base(positionParameter)
        {
            //Initializes the x Coordinate and the y Coordinate field
            parameterPosition = positionParameter;
            _xCoordinate = xCoordinate;
            _yCoordinate = yCoordinate;
        }
        //Returns the x and y coordinate and a dot
        public override int X_Coordinate() => _xCoordinate;
        public override int Y_Coordinate() => _yCoordinate;
        public override char Display => '.';
    }
    //Create a new class extending Tile class
    internal class WallTile : Tile//Inherit from tile class
    {
        //Initialze the filed that will correlate with the Tile class
        private readonly int _xCoordinate;
        private readonly int _yCoordinate;
        //Initialize a constructor
        public WallTile(int positionParameter, int xCoordinate, int yCoordinate) : base(positionParameter)//Pass the parameter to the base constructor
        {
            _xCoordinate = xCoordinate;
            _yCoordinate = yCoordinate;
        }
        public override int X_Coordinate() => _xCoordinate;
        public override int Y_Coordinate() => _yCoordinate;
        public override char Display => '#';//Override the display property to showcase the wall character
    }
}

