using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroButton : MonoBehaviour
{

    //���� ������ public, private + ��ȯ���� Ÿ�� ���� void, int, stirng + �Լ��� �̸� + (    )

    public void ButtonPlay()
    {
        Debug.Log("�÷��� ��ư�� ����Ǿ����ϴ�.");

        SceneManager.LoadScene(1);
    }
    public void ButtonLevelEditory()
    {
        Debug.Log("���� ��ư�� ����Ǿ����ϴ�.");
    }

    public void ButtonSetting()
    {
        Debug.Log("���� ��ư�� ����Ǿ����ϴ�.");
    }

    public void ButtonNews()
    {
        Debug.Log("���� ��ư�� ����Ǿ����ϴ�.");
    }

}


