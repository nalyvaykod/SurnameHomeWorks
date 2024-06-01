using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelScript : MonoBehaviour
{
    public void LoadNewSceneOnClickFunction()
    {
        //SceneManager.LoadScene("InputSystem"); //Всередину приймає назву вашого 2-го рівня.
        SceneManager.LoadSceneAsync(1);
    }

    public void LoadOptionsSceneOnClickFunction()
    {
        SceneManager.LoadSceneAsync(2);
    }
}
