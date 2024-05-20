using UnityEngine;
using UnityEngine.SceneManagement;

namespace LoadGame
{
    public class StartGame : MonoBehaviour
    {
        public void OpenGame() => 
            SceneManager.LoadSceneAsync("Scenes/Main");
    }
}
