using UnityEngine;

public class Spuare : MonoBehaviour
{

    Rigidbody2D rigidbody2;
    [SerializeField] Vector2 moveDir;
    [SerializeField] float   moveSpeed;
    [SerializeField] Vector2  JumpUp;
    [SerializeField] float JumpPower = 5;
  

    void Start()
    {
      rigidbody2 = GetComponent<Rigidbody2D>();  

       rigidbody2.linearVelocity = moveDir.normalized* moveSpeed;
    }

    private void OnCollisionEnter2D(Collision2D collision) // �浹������ �� �ڵ带 �����ϼ���
    {
        //�浹�� ����� Player�ΰ���?
        if(collision.collider.CompareTag("Player"))
      {
            Debug.Log("�÷��̾ �浹�Ͽ� ������ �����մϴ�.");

            //Enemy�� �����ϵ��� ����� ������.
            //rigidbody2d��, �������� ������ ���� �����ϵ��� ����� ������.

            rigidbody2.AddForce(JumpUp * JumpPower, ForceMode2D.Impulse);


        }
    }

}
