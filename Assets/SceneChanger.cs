using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    // 씬 이름을 지정합니다.
    public string GameScene;
    public string StartScene;

    // 버튼 클릭 시 호출할 메서드
    public void GameSceneStart()
    {
        // 씬 전환
        SceneManager.LoadScene(GameScene);
    }
    public void ResetScene()
    {
        // 씬 전환
        SceneManager.LoadScene(StartScene);
    }
    
    public void ExitGame()
    {
#if UNITY_EDITOR
        // 에디터 모드에서 게임 종료
        UnityEditor.EditorApplication.isPlaying = false;
#else
        // 빌드된 게임에서 종료
        Application.Quit();
#endif
    }
}