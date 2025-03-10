public class Constants
{
    public const string ServerURL = "http://localhost:3000";
    public const string GameServerURL = "ws://localhost:3000";

    public enum MultiplayManagerState
    {
        CreateRoom,
        JoinRoom,
        StartGame,
        EndGame
    };
    
    public enum PlayerType { None, PlayerA, PlayerB }
    public enum GameType { SinglePlayer, DualPlayer, MultiPlayer }
}