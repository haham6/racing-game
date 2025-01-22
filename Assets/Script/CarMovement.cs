using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CarMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // 캐릭터 이동 속도

    public List<Transform> Position;
    int currentPosition = 1;

    void Update()
    {
        MouseButtonDown();
        Move();
    }

    void MouseButtonDown()
    {
        // 마우스 클릭 확인
        if (Input.GetMouseButtonDown(0)) // 0은 왼쪽 클릭
        {
            // 화면 중앙 계산
            float screenCenter = Screen.width / 2;

            // 클릭된 위치 가져오기
            Vector3 mousePosition = Input.mousePosition;

            // 클릭 위치가 중앙보다 왼쪽인지 오른쪽인지 확인
            if (mousePosition.x < screenCenter && 0 < currentPosition)
            {
                currentPosition--;
            }
            else if (mousePosition.x > screenCenter && currentPosition < Position.Count - 1)
            {
                currentPosition++;
            }
        }
    }
    void Move()
    {
        // 캐릭터를 이동
        transform.position = Vector3.Lerp(transform.position, Position[currentPosition].position, moveSpeed * Time.deltaTime);
    }
}