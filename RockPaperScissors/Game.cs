using System;

namespace RockPaperScissors
{
    public class Game
    {
        private readonly Player _player1;
        private readonly Player _player2;
        private readonly int _maxRounds;
        private int _rounds;
        private readonly GameLogger _gameLogger;

        public bool NoWinners => _player1.Score < _maxRounds -1 && _player2.Score < _maxRounds -1;
        public string Winner => _gameLogger.LogWinner(_player1.Score < _player2.Score ? "player2" : "player1", _rounds);

        public Game()
        {
            _maxRounds = 3;
            _player1 = new Player();
            _player2 = new Player();
            _gameLogger = new GameLogger();
            _gameLogger.LogRules(_maxRounds);
        }

        public void PlayRound()
        {
            _rounds++;
            CheckWhoWonRound(_player1.Move(), _player2.Move());
        }

        private void CheckWhoWonRound(Move player1Move, Move player2Move)
        {
            CheckPlayer1WonRound(player1Move, player2Move);
            CheckPlayer2WonRound(player1Move, player2Move);
            CheckForDraw(player1Move, player2Move);
        }

        private void CheckForDraw(Move player1Move, Move player2Move)
        {
            if (!player1Move.Beats(player2Move) && !player2Move.Beats(player1Move))
            {
                _gameLogger.LogRoundDraw(player1Move, player2Move, _rounds);
            }
        }

        private void CheckPlayer2WonRound(Move player1Move, Move player2Move)
        {
            if (player2Move.Beats(player1Move))
            {
                _player2.Score++;
                _gameLogger.LogWinnerOfRound("\nplayer2 won round " + _rounds + ": ", player2Move, player1Move);
            }
        }

        private void CheckPlayer1WonRound(Move player1Move, Move player2Move)
        {
            if (player1Move.Beats(player2Move))
            {
                _player1.Score++;
                _gameLogger.LogWinnerOfRound("\nplayer1 won round " + _rounds + ": ", player1Move, player2Move);
            }
        }
    }
}
