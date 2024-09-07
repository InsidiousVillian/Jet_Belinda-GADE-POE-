﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE___1B___Part_1
{
    internal abstract class Tile
    {
        //Instatiate a field
        private Position position;


        //Set Properties that will display the coordinates and each tile as a character
        public int XCoordinate { get { return position.XCoordinate; } }
        public int YCoordinate { get { return position.XCoordinate; } }
        public abstract char Display { get; }

        //Set a constructor that accepts a parameter and assigns it tot the position class field
        protected Tile(Position position)
        {
            //Assign the argument to the field
            this.position = position;

        }
        public Position Position
        {
            get { return position; }
            set { position = value; }
        }
        internal abstract class CharacterTile : Tile
        {
            //Instatiate the fields
            private int _hitPoints;
            private int _hitPointsMax;
            private int _attackPower;

            //Instatiate the Vision Array for the character
            public Tile[] charVision;

            //Declare the constructor for the character
            public CharacterTile(Position position, int hitDamage, int attackLevel) : base(position)
            {
                //Assign the parameter to the fields
                _hitPoints = hitDamage;
                _hitPointsMax = hitDamage;
                _attackPower = attackLevel;

                //Declare the array that will open 4 space to store values
                charVision = new Tile[4];
            }
            public void UpdateVision(Level level)
            {
                //2D Array from the level class to represent the template of the game grid
                var tiles = level._tiles;

                if (XCoordinate > 0) charVision[0] = tiles[XCoordinate, YCoordinate - 1]; // Tile above (index 0) of the character
                if (XCoordinate < level._width - 1) charVision[1] = tiles[XCoordinate + 1, YCoordinate]; // Tile to the right (index 1) of the character
                if (YCoordinate < level._height - 1) charVision[2] = tiles[XCoordinate, YCoordinate + 1]; // Tile below (index 2) of the character
                if (XCoordinate > 0) charVision[3] = tiles[XCoordinate - 1, YCoordinate]; // Tile to the left (index 3) of the character
                charVision[4] = tiles[XCoordinate, YCoordinate];
            }
            //Method that the character will take damage
            public int TakeDamage(int charDamage)
            {
                //Calculate the damage the character will endure
                _hitPoints = charDamage - _hitPoints;

                //Create an if statement to check if the hit points of the character is not below 0
                if (_hitPoints < 0)
                {
                    //Display a messgae that game is over or the character died
                    Console.WriteLine("Game over");
                }
                return _hitPoints;//Retrun the result to notify the Player
            }
            //Create a method that will to pass the attacker's power along the amount of damage
            public void Attack(CharacterTile target)
            {
                target.TakeDamage(_attackPower);
            }
            public bool isDead { get { return false; } }
        }
    }
}

