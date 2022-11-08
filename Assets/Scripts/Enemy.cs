using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Enemy : MonoBehaviour
{
    
    public float hp;
    private float speed;
    private Vector3 targetPosition;

    void Start()
    {
        speed = 0.1f;
        targetPosition = Camera.main.ScreenToWorldPoint(new Vector3(Random.Range(0f, Screen.width), Random.Range(0f, Screen.height)));
        
    }

    void Update()
    {
        RandomMoveFlower();
    }

    private void RandomMoveFlower()
     {
         transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed* Time.deltaTime);
     }
private void OnTriggerEnter(Collider other)
    {

        // 如果碰撞到的是子彈
        if (other.tag == "Bullet")
        {
            // 先取得子彈的攻擊力
            Bullet bullet = other.GetComponent<Bullet>();

            // 先扣血
            hp -= bullet.atk;

            // 如果沒血了，就刪除自己
            if (hp <= 0)
            {
                gameObject.SetActive(false);
                Destroy(gameObject);
            }
        }
    }
}
