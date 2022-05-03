using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class LoginSceneManager : MonoBehaviour
{
    [SerializeField] private TMP_InputField input;
    [SerializeField] private Button enterBtn;
    private void Awake()
    {
        input.onValueChanged.AddListener(UsernameChange);
        enterBtn.onClick.AddListener(EnterGame);
    }
    private void UsernameChange(string name)
    {
        Global.Username = name;
    }
    public void EnterGame()
    {
        if (Global.Username.Length < 4) return;
        SceneManager.LoadScene("MainScene");
    }
}
