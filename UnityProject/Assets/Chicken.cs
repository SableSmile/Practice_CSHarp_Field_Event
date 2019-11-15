using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chicken : MonoBehaviour
{
    [Header("移動速度"), Range(0f, 100f)]
    public float speed = 10f;
    [Header("跳躍高度"), Range(0, 2000)]
    public int Jump = 200;
    [Header("對話內容")]
    public string talk = "咕咕咕~~~";
    [Header("是否取得雞蛋")]
    public bool Egg;
    // Start is called before the first frame update
    void Start()
    {
        print("遊戲開始!!!");
    }

    // Update is called once per frame
    void Update()
    {
        print(talk);
    }
}
