using UnityEngine;
using UnityEngine.SceneManagement;

public class Startup : MonoBehaviour
{
    private void Awake()
    {
        SceneManager.LoadScene("LoginScene");
    }
}
