using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroButton : MonoBehaviour
{

    //접근 지정자 public, private + 반환값의 타입 선언 void, int, stirng + 함수의 이름 + (    )

    public void ButtonPlay()
    {
        Debug.Log("플레이 버튼이 실행되었씁니다.");

        SceneManager.LoadScene(1);
    }
    public void ButtonLevelEditory()
    {
        Debug.Log("레벨 버튼이 실행되었씁니다.");
    }

    public void ButtonSetting()
    {
        Debug.Log("세팅 버튼이 실행되었습니다.");
    }

    public void ButtonNews()
    {
        Debug.Log("뉴스 버튼이 실행되었습니다.");
    }

}


