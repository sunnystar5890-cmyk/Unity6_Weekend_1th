using UnityEngine;

public class MushRoom : MonoBehaviour
{
    //transform 이동으로 좌우로 움직이는 코드를 만들어줘
    //옆에 충돌할수 있는 물체가 있으면 어떤 "이벤트"가 발생해야한다.

    public float speed = 5f;

    public int direcion = 1; //오른쪽, -1 : 왼쪽


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      int rand =  UnityEngine.Random.Range(0, 2); //0또는 1이 출력이 된다.
        


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

        transform.position = transform.position + new Vector3(direcion, 0, 0) * speed * Time.deltaTime; //처음 움직였을때 방향으로 움직인다.   



    }
}
