using UnityEngine;
using UnityEngine.SceneManagement;

public class PopupStage : MonoBehaviour
{

    public void Awake()
    {
        OnPopupClose();
    }

    public void OnOpenPopup()
    {
        this.gameObject.SetActive(true);
    }

    public void OnPopupClose()
    {
        this.gameObject.SetActive(false);
    }

    public void OnStartGame()
    {
        //SceneManager.LoadScene("GameScene");
        LoadingScene.ReserveLoadScene("GameScene");
    }
}