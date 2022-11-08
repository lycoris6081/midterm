using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class COIN : MonoBehaviour
{
    public string Scenes; // 下一個關卡的名稱（需回到Unity Inspector中輸入）
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        // 當碰撞到 tag 為 Coin 的物件
        if (other.gameObject.tag == "Coin")
        {
            // 刪除物件(設為停用、並移除)
            other.gameObject.SetActive(false);
            Destroy(other.gameObject);


            
        }
    }
}
