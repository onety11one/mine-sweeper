using Gameplay.Cells;
using Gameplay.Grid;
using System.Collections.Generic;

namespace Gameplay.Generation
{
    public class MinefieldGenerator
    {
        private GridModel _grid;
        private int _mineCount;

        public void Initialize(GridModel grid, int mineCount)
        {
            _grid = grid;
            _mineCount = mineCount;
        }

        public void Generate(GridPosition safeFirstClick)
        {
            PlaceMines(safeFirstClick);
            CalculateNearbyMines();
        }

        private void PlaceMines(GridPosition safe)
        {
            int placed = 0;

            var random = new System.Random();

            while (placed < _mineCount)
            {
                int x = random.Next(_grid.Width);
                int y = random.Next(_grid.Height);

                if (x == safe.X && y == safe.Y)
                    continue;

                var cell = _grid.Cells[x, y];

                if (cell.IsMine)
                    continue;

                cell.IsMine = true;
                placed++;
            }
        }

        private void CalculateNearbyMines()
        {
            for (int x = 0; x < _grid.Width; x++)
            {
                for (int y = 0; y < _grid.Height; y++)
                {
                    var cell = _grid.Cells[x, y];

                    if (cell.IsMine)
                    {
                        cell.NearbyMines = -1;
                        continue;
                    }

                    int count = 0;

                    foreach (var dir in GridDirections.NearbyCells)
                    {
                        int nx = x + dir.x;
                        int ny = y + dir.y;

                        if (!_grid.IsInside(nx, ny))
                            continue;

                        if (_grid.Cells[nx, ny].IsMine)
                            count++;
                    }

                    cell.NearbyMines = count;
                }
            }
        }
    }
}