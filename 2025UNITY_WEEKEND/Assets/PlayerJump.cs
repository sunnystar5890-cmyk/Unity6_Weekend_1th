using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerJump : MonoBehaviour
{
    Rigidbody2D rigidbody2D; // ������Ʈ ������ ���� ����� rigidbody2D ������ �̿��ؼ� ����ϰڴ�.
   [SerializeField] float jumpPower = 5;
   [SerializeField] Vector2 dir;
   [SerializeField] LayerMask groundLayer;  //���� ������ �������ִ� �� (Ground, default)
   [SerializeField] float groundCheckDistance = 5;       //GrounddistanceCheck ������ �Ÿ�üũ�� ���� �Ÿ�


    //�÷��̾� ���ӿ�����Ʈ �ȿ� �ִ� Rigidbody2D ������Ʈ�� rigidbody2D�ȿ� ���� �ϰ� �ʹ�.

    void Start()
    {
    
        rigidbody2D = GetComponent<Rigidbody2D>();

        //Vector2. up, down, left, right �����غ�����.
        //Vector2.up *5 
        //������ �Ѵ����� ������ ������ ������.

      //  rigidbody2D.AddForce(dir.normalized * jumpPower, ForceMode2D.Impulse);


    }

    //ADDFoce : ���� �߰��ϴ�. ���� -> ���� ���� ���Ѵ�.


    void Update()
    {

        // rigidbody2D.AddForce(Vector2.up * 5, ForceMode2D.Impulse);

        //Spacebar �������� �����ϰ� �ʹ�.

        if (Input.GetKeyDown(KeyCode.Space) && IsGrounded())
        {
            rigidbody2D.AddForce(dir.normalized * jumpPower, ForceMode2D.Impulse);

        }       
    }
    bool IsGrounded() //���� ��� �ֳ���?
    {
        return Physics2D.Raycast(transform.position, Vector2.down, groundCheckDistance, groundLayer);
    }


    private void  OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(transform.position,
            transform.position + (Vector3)(Vector2.down * groundCheckDistance));
    }
    
}
