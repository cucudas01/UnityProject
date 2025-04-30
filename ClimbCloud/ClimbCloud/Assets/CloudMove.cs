using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudMove : MonoBehaviour
{
    public float moveDistance = 0.3f;    // 이동 거리 (좌우 범위)
    public float speed = 0.2f;           // 이동 속도
    private Vector3 startPos;

    void Start()
    {
        startPos = transform.position; // 시작 위치 기억
    }

    void Update()
    {
        // Mathf.PingPong: 0 ~ moveDistance 사이를 계속 왕복하는 값 반환
        float x = Mathf.PingPong(Time.time * speed, moveDistance * 2) - moveDistance;
        transform.position = new Vector3(startPos.x + x, startPos.y, startPos.z);
    }
}
