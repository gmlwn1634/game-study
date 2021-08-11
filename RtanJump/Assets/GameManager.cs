using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //singletone
    public static GameManager I;

    //Awake() : Start()���� ���� ����
    //Awake -> Start -> Update -> Update ...
    private void Awake()
    {
        I = this;
    }

    public void GameOver()
    {
        //Invoke -> unity ���� �Լ�
        Invoke("GameOver_", 2); //2�� �ڿ� GameOver_() ����
    }

    public void GameWin()
    {
        GameOver_();
    }


    void GameOver_()
    {
        // 0��° ���� �ε�
        SceneManager.LoadScene(0);
    }
}
