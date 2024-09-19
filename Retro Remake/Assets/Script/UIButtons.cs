using UnityEngine;
using UnityEngine.SceneManagement;

public class UIButtons : MonoBehaviour
{
    public string scene = "SampleScene";
    public void play()
    {
        SceneManager.LoadScene(scene);
    }
    public void OnApplicationQuit()
    {
        Application.Quit();
    }
}
