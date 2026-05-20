using Gameplay.Cells;

namespace Gameplay.Grid
{
    public class GridModel
    {
        public int Width { get; }
        public int Height { get; }

        public CellModel[,] Cells { get; }

        public GridModel(int width, int height)
        {
            Width = width;
            Height = height;

            Cells = new CellModel[width, height];

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    Cells[x, y] = new CellModel();
                }
            }
        }

        public bool IsInside(int x, int y)
        {
            return x >= 0 && y >= 0 && x < Width && y < Height;
        }

        public CellModel GetCell(int x, int y)
        {
            return Cells[x, y];
        }
    }
}