using System.Collections.Generic;
using System.Reflection;
using Xamarin.Forms;

namespace SaturdayMeetup
{
	public class Tile
	{
        public Tile(int row, int col)
        {
            Row = row;
            Col = col;

            TileView = new ContentView
            {
                Padding = new Thickness(1),

                // Get the bitmap for each tile 
                Content = new Image
                {
                    Source = ImageSource.FromResource($"SaturdayMeetup.tiles.akvelon-{row}-{col}.jpeg", typeof(Tile).GetTypeInfo().Assembly)
                }
            };

            // Add TileView to dictionary for obtaining Tile from TileView
            Dictionary.Add(TileView, this);
        }

        public static Dictionary<View, Tile> Dictionary { get; } = new Dictionary<View, Tile>();

        public int Row { set; get; }

        public int Col { set; get; }

        public View TileView { private set; get; }
    }
}