using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    // �̵� �ӵ� ������ ���� ����
    [SerializeField] private float moveSpeed = 5f;

    // Rigidbody2D ������Ʈ ����
    private Rigidbody2D rb;

    // Ű���� �Է� ���� ������ Vector2 ����
    private Vector2 movementInput;

    void Awake()
    {
        // Rigidbody2D ������Ʈ ��������
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Ű���� �Է��� ���� (WASD �Ǵ� ȭ��ǥ Ű)
        // Horizontal: A/D �Ǵ� Left/Right Arrow
        // Vertical: W/S �Ǵ� Up/Down Arrow
        movementInput.x = Input.GetAxisRaw("Horizontal");
        movementInput.y = Input.GetAxisRaw("Vertical");

        // �밢�� �̵� �� �ӵ� ������ ���� ���͸� ����ȭ
        movementInput.Normalize();
    }

    void FixedUpdate()
    {
        // ���� ������ FixedUpdate���� ó���ϴ� ���� ���ƿ�.
        // Rigidbody2D�� �ӵ��� ���� �����Ͽ� �̵�
        rb.linearVelocity = movementInput * moveSpeed;
    }
}