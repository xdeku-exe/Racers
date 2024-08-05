using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    [Header("SceneDatas")]
    [SerializeField] private int CarShopScene;

    public void Play()
    {
        SceneManager.LoadScene(CarShopScene);  
    }
}
