using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelScript : MonoBehaviour
{
    public void LoadNewSceneOnClickFunction()
    {
        //SceneManager.LoadScene("InputSystem"); //��������� ������ ����� ������ 2-�� ����.
        SceneManager.LoadSceneAsync(1);
    }

    public void LoadOptionsSceneOnClickFunction()
    {
        SceneManager.LoadSceneAsync(2);
    }
}
