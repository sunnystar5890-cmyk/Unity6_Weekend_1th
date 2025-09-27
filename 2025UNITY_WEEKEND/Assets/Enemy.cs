using UnityEngine;

public class Enemy : MonoBehaviour
{

    void Start()
    {
    }
}

public class FlyCube : MonoBehaviour
{
    public float flyForce = 10f; // ť�긦 ��� ���� ũ��

    private Rigidbody2D rb2d;

    void Start()
    {
        // Rigidbody2D ������Ʈ�� �����ɴϴ�.
        rb2d = GetComponent<Rigidbody2D>();

        // ���۰� ���ÿ� �������� ���� ���մϴ�.
        // Vector2.up�� (0, 1)�� �ǹ��մϴ�.
        // ForceMode2D.Impulse�� �������� ���� ���� �� ����մϴ�.
        rb2d.AddForce(Vector2.up * flyForce, ForceMode2D.Impulse);
    }
}