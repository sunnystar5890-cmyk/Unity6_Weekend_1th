using UnityEngine;

public class MushRoom : MonoBehaviour
{
    //transform �̵����� �¿�� �����̴� �ڵ带 �������
    //���� �浹�Ҽ� �ִ� ��ü�� ������ � "�̺�Ʈ"�� �߻��ؾ��Ѵ�.

    public float speed = 5f;

    public int direcion = 1; //������, -1 : ����


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      int rand =  UnityEngine.Random.Range(0, 2); //0�Ǵ� 1�� ����� �ȴ�.
        


            if (rand == 0)
            {
            direcion = -1;
            }
            else if (rand == 1)
            {
            direcion = 1;
            }



    }

    // Update is called once per frame
    void Update()
    {

        transform.position = transform.position + new Vector3(direcion, 0, 0) * speed * Time.deltaTime; //ó�� ���������� �������� �����δ�.   



    }
}
