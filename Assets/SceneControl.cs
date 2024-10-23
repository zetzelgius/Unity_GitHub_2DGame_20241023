using UnityEngine;
using UnityEngine.SceneManagement;

public class SenceControl : MonoBehaviour
{
    public void LoadScene(string sceneName) 
    {
        //場景管理器 的 載入場景(場景名稱)
        SceneManager.LoadScene(sceneName);
    }
    public void QuitGame()
    {
        //應用程式 的 離開
        Application.Quit();
    }
}
