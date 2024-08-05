using UnityEngine.SceneManagement;
using UnityEngine;

public class CarMenu : MonoBehaviour
{
    public void Play(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }
}
