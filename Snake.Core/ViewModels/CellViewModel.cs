using CommunityToolkit.Mvvm.ComponentModel;

namespace Snake.Core.ViewModels
{
    /// <summary>
    /// The View Model for each cell in the game grid
    /// </summary>
    public partial class CellViewModel : ObservableObject
    {
        #region Fields

        public static int[] SNAKE_HEAD_RGB = { 0, 0, 255 };

        public static int[] SNAKE_BODY1_RGB = { 0, 255, 0 };
        public static int[] SNAKE_BODY2_RGB = { 0, 200, 0 };
        public static int[] SNAKE_BODY3_RGB = { 0, 150, 0 };

        public static int CELL_SIZE = 10;

        #endregion

        #region Properties

        /// <summary>
        /// Width of the cell
        /// </summary>
        public int Width => CELL_SIZE;

        /// <summary>
        /// Height of the cell
        /// </summary>
        public int Height => CELL_SIZE;

        /// <summary>
        /// The x position of a cell
        /// </summary>
        [ObservableProperty]
        private int xPos;

        /// <summary>
        /// The y position of a cell
        /// </summary>
        [ObservableProperty]
        private int yPos;

        /// <summary>
        /// The cells color in rgb 
        /// </summary>
        [ObservableProperty]
        private int[] rgb;

        #endregion

        #region Constructor

        /// <summary>
        /// Overloaded constructor
        /// </summary>
        /// <param name="xpos"></param>
        /// <param name="ypos"></param>
        public CellViewModel(int xpos, int ypos)
        {
            XPos = xpos;
            YPos = ypos;
            Rgb = SNAKE_HEAD_RGB;
        } 

        #endregion
    }
}
