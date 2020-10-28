using UnityEngine.SceneManagement;
namespace Assets.Scripts.Services {
    static class sceneService {
        public static void LoadNextScene() {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
