using Core.Configs;
using Core.GameStates;
using UnityEngine;

namespace Core.Bootstrap
{
    public class GameBootstrap : MonoBehaviour
    {
        [SerializeField] private GameConfig _config;

        private GameStateMachine _stateMachine;

        private void Awake()
        {
            _stateMachine = new GameStateMachine();
        }
    }
}