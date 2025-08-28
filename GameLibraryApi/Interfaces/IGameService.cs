using GameLibraryApi.Models;

namespace GameLibraryApi.Interfaces
{
    public interface IGameService
    {
        void CreateGame(GameInformation gameInformation);
        void DeleteGame(int id);
        void EditGame(GameInformation gameInformation);
        List<GameInformation> GetAllGames();
        GameInformation GetGame(int id);
    }
}
