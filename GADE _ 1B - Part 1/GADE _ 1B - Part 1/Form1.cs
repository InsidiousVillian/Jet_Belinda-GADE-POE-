namespace GADE___1B___Part_1
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
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Initialize the variables that would be used for the tile of the game
            int xValue = 12;
            int yValue = 8;
            //int positionParameter = 0;
            //int xCoordinate = 12;
            //int yCoordinate = 8;
            int gameLvls = 10;

            //Initialiaze the position object 
            Position position = new(xValue, yValue);
            //position.XCoordinate = tile.;

            //Initialize the emptyTile object
            //EmptyTile emptyTile;

            //Initialize the object
            //WallTile wallTile = new();

            GameEngine gameEngine = new GameEngine(gameLvls);



        }
        public void UpdateDisplay()
        {
            //Set the label to a string message
            lblDisplay.Text = engine.ToString();
        }

        private void lblDisplay_Click(object sender, EventArgs e)
        {
            
        }
    }
}
