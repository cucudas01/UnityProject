using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudMove : MonoBehaviour
{
    public float moveDistance = 0.3f;     // 이동 거리 (좌우 범위)
    public float minSpeed = 0.1f;         // 최소 속도
    public float maxSpeed = 0.5f;         // 최대 속도
    private float speed;                  // 실제 적용할 속도 (랜덤)

    private Vector3 startPos;

    void Start()
    {
        startPos = transform.position; // 시작 위치 기억
        speed = Random.Range(minSpeed, maxSpeed); // 랜덤 속도 설정
    }

    void Update()
    {
        // PingPong으로 좌우 이동
        float x = Mathf.PingPong(Time.time * speed, moveDistance * 2) - moveDistance;
        transform.position = new Vector3(startPos.x + x, startPos.y, startPos.z);
    }
}
