using UnityEngine;

public class Enemy : MonoBehaviour
{

    void Start()
    {
    }
}

public class FlyCube : MonoBehaviour
{
    public float flyForce = 10f; // 큐브를 띄울 힘의 크기

    private Rigidbody2D rb2d;

    void Start()
    {
        // Rigidbody2D 컴포넌트를 가져옵니다.
        rb2d = GetComponent<Rigidbody2D>();

        // 시작과 동시에 위쪽으로 힘을 가합니다.
        // Vector2.up은 (0, 1)을 의미합니다.
        // ForceMode2D.Impulse는 순간적인 힘을 가할 때 사용합니다.
        rb2d.AddForce(Vector2.up * flyForce, ForceMode2D.Impulse);
    }
}