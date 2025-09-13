using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{

    public float speed = 5f;
    public float JumpForce = 10f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    //AI ��F�� ����ұ�?
    //����, Update�Լ�
    //Player �̵� ���� - A,DŰ�� ������ �¿�� �����̰� �ʹ�.spaceŰ��  ������ ������ �ϰ�ʹ�.
    //Update�Լ��ȿ��� ������ �� �ְ� ����, speed, jumpForce�� ����ؼ� ����� ��������.
    //Transform �̵����, Rigidbody ������� �̵�
    //class �̸��� Player �����޶�
    //Rigidbody 2d�����̴�
    //���� ����� ���� �����Ҽ� �ְ�.

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical"); // w,s,��, �Ʒ�

     

        if(Input.GetKeyDown(KeyCode.Space)) // �÷��̾ ���� ������븸 ������ �ض�.
        {

                transform.position = transform.position + new Vector3(0, JumpForce, 0)  * Time.deltaTime;

        }


        transform.position = transform.position + new Vector3(x, 0, 0)  * speed * Time.deltaTime;

    }
}
