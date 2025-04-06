using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    void Start ()
    {
        Debug.Log("Hello Unity!");

        // 정수 자료형(4, 8, 2, 1 byte)
        int level = 5;
        long level2 = 10;
        short level3 = 10;
        byte level4 = 255; // 0 ~ 255
        
        // 실수 자료형(4, 8, 16 byte)
        float strength = 15.5f;
        double strength2 = 15.5;
        decimal strength3 = 15.55;
        
        // 문자 & 문자열 자료형
        char grade = 'A';
        string playerName = "나검사";
        
        // 논리형 자료형(true, false)
        bool isFullLevel = false;

        Debug.Log("용사의 이름은?");
        Debug.Log(playerName);
        Debug.Log("용사의 레벨은?");
        Debug.Log(level);
        Debug.Log("용사의 힘은?");
        Debug.Log(strength);
        Debug.Log("용사는 만렙인가?");
        Debug.Log(isFullLevel);
    }
}
