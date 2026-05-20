using System.Collections.Generic;

namespace Core.GameStates
{
    public class GameStateMachine
    {
        private IGameState _currentState;

        private readonly Dictionary<GameStateType, IGameState> _states = new();

        public void RegisterState(IGameState state)
        {
            _states[state.Type] = state;
        }

        public void ChangeState(GameStateType type)
        {
            if (_currentState != null && _currentState.Type == type)
                return;

            _currentState?.Exit();

            _currentState = _states[type];

            _currentState.Enter();
        }
    }
}