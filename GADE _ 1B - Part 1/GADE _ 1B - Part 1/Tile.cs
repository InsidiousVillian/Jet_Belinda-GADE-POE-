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
        private int typePosition;
        private Position Position;

        //Set Properties that will display the coordinates and each tile as a character
        public int XCoordinate { get; set; }
        public int YCoordinate { get; set; }
        public abstract char Display { get; }

        //Set a constructor that accepts a parameter and assigns it tot the position class field
        public Tile(int positionType, Position position)
        {
            //Assign the argument to the field
            typePosition = positionType;
            this.Position = position;
        }
    }
    //Create a new class
    internal class EmptyTile : Tile
    {
        //Set a constructor that will use the argument PositionParameter
        public EmptyTile(Position position) : base(0 , position)
        {

        }
        //Returns the x and y coordinate and a dot
        public override char Display => '.';
    }
    //Create a new class extending Tile class
    internal class WallTile : Tile//Inherit from tile class
    {
        //Initialize a constructor
        public WallTile(Position position) : base(0, position)//Pass the parameter to the base constructor
        {

        }
        public override char Display => '#';//Override the display property to showcase the wall character
    }
    internal abstract class CharacterTile : Tile
    {
        //Declare the attributes
        private int _hitPoints;
        private int _hitPointsMax;
        private int _attackPower;

        public Tile[,] charVision;

        public CharacterTile(Position position, int hitDamage, int attackLevel) : base(0, position)
        {
            _hitPoints = hitDamage;
            _hitPointsMax = hitDamage;
            _attackPower = attackLevel;

            charVision = new Tile[4, 4];
        }
        public void UpdateVision(Level level)
        {
            
        }
    }
}

