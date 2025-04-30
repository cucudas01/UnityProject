using UnityEngine;
using UnityEngine.SceneManagement;
public class RestareButton : MonoBehaviour
{
    public void ChangeToScene()
    {
        SceneManager.LoadScene("GameScene");
    }
}