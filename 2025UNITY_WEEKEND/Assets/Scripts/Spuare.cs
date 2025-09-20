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

    private void OnCollisionEnter2D(Collision2D collision) // 충돌했을때 이 코드를 실행하세요
    {
        //충돌한 대상이 Player인가요?
        if(collision.collider.CompareTag("Player"))
      {
            Debug.Log("플레이어가 충돌하여 게임이 종료합니다.");

            //Enemy가 점프하도록 만들어 보세요.
            //rigidbody2d와, 점프관련 변수를 만들어서 점프하도록 만들어 보세요.

            rigidbody2.AddForce(JumpUp * JumpPower, ForceMode2D.Impulse);


        }
    }

}
