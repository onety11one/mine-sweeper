namespace Gameplay.Grid
{
    public static class GridDirections
    {
        public static readonly (int x, int y)[] NearbyCells =
        {
            (-1, -1), (0, -1), (1, -1),
            (-1,  0),          (1,  0),
            (-1,  1), (0,  1), (1,  1)
        };
    }
}