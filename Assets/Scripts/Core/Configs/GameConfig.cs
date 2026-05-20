using UnityEngine;

namespace Core.Configs
{
    [CreateAssetMenu(fileName = "GameConfig", menuName = "Configs/GameConfig")]
    public class GameConfig : ScriptableObject
    {
        [Min(9)]
        public int Width = 9;

        [Min(9)]
        public int Height = 9;

        [Min(10)]
        public int MineCount = 10;
    }
}