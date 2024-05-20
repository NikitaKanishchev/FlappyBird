using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace LoadGame
{
    public class LoadingGame : MonoBehaviour
    {
        public Button Button;
        public void OpenLobby()
        {
            SceneManager.LoadSceneAsync("Scenes/Lobby");
        }
    }
}
