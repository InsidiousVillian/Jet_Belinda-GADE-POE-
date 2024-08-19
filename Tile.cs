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
        public int typePosition;

        //Set Properties that will display the coordinates and each tile as a character
        public abstract void X_Coordinate();
        public abstract void Y_Coordinate();
        public abstract char Display { get; }

        //Set a constructor that accepts a parameter and assigns it tot the position class field
        protected Tile(int positionType)
        {
            //Assign the argument to the field
            typePosition = positionType;
        }
    }
    //Create a new class
    public class EmptyTile : Tile
    {
        public int parameterPosition;

        //Set a constructor that will use the argument PositionParameter
        public EmptyTile(int positionParameter ) : base(positionParameter)
        {
            parameterPosition = positionParameter;
        }
        public override char Display
        {
            get { return '.'; }
           
        }

    }
}
