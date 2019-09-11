using UnityEngine;
using UnityEngine.SceneManagement;

namespace QuickStarter.Scene
{
    public class SceneLoader : MonoBehaviour
    {
        public string TargetSceneNameToLoad;

        // PUBLIC

        public void LoadScene(int buildIndex)
        {
            SceneManager.LoadScene(buildIndex);
        }

        public void LoadScene(string sceneName)
        {
            SceneManager.LoadScene(sceneName);
        }

        public void LoadTargetScene()
        {
            SceneManager.LoadScene(TargetSceneNameToLoad);
        }

        public void ReloadCurrentScene()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
