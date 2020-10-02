using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneHandler : MonoBehaviour
{
    public void RunScene(int index)
    {
        SceneManager.LoadScene(index);
    }
}