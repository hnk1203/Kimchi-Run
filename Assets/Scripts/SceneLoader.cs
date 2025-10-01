using UnityEngine;
using UnityEngine.SceneManagement; 

public class SceneLoader : MonoBehaviour
{
    // Unity 버튼에 연결할 공개 함수.
    public void LoadGameScene()
    {
        // 실제 메인 게임 씬 파일 이름과 정확히 같아야 함
        SceneManager.LoadScene("main");
    }
}