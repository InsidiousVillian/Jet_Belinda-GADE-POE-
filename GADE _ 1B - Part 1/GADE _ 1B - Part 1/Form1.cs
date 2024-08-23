namespace GADE___1B___Part_1
{
    public partial class Form1 : Form
    {
        private readonly GameEngine engine;
        public Form1()
        {
            InitializeComponent();
            int gameLvls = 10;
            //Initialize the instance varivble 
            engine = new GameEngine(gameLvls);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Initialize the variables that would be used for the tile of the game
            int userXValue = 0;
            int userYValue = 0;
            int positionParameter = 0;
            int xCoordinate = 0;
            int yCoordinate = 0;

            //Initialiaze the position object 
            Position position = new(userXValue, userYValue);

            //Call the properties used within the object
            position.X_Coordinate();
            position.Y_Coordinate();

            //Initialize the emptyTile object
            EmptyTile emptyTile = new(positionParameter, xCoordinate, yCoordinate);

            //Call the properties used within the object
            emptyTile.X_Coordinate();
            emptyTile.Y_Coordinate();

            //Call the gameengine method to generate values between the minimum value and the maximum value set as constants 
            engine.GenerateValues();

            //Initialize the object
            WallTile wallTile = new(positionParameter, xCoordinate, yCoordinate);

            //Call the properties used within the objec
            wallTile.X_Coordinate();
            wallTile.Y_Coordinate();

        }
        public void UpdateDisplay()
        {
            //Set the label to a string message
            lblDisplay.Text = engine.ToString();

        }

        private void lblDisplay_Click(object sender, EventArgs e)
        {
            //Call the method to hold the function to display
            UpdateDisplay();
        }
    }
}
