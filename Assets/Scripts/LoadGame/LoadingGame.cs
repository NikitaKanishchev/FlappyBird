using UnityEngine;
using UnityEngine.SceneManagement;

namespace LoadGame
{
    public class LoadingGame : MonoBehaviour
    {
        private void Start() => 
            SceneManager.LoadSceneAsync("Scenes/Lobby");
    }
}
