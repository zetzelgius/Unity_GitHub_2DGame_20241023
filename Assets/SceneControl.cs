using UnityEngine;
using UnityEngine.SceneManagement;

public class SenceControl : MonoBehaviour
{
    public void LoadScene(string sceneName) 
    {
        //�����޲z�� �� ���J����(�����W��)
        SceneManager.LoadScene(sceneName);
    }
    public void QuitGame()
    {
        //���ε{�� �� ���}
        Application.Quit();
    }
}
