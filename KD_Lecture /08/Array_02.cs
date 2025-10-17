using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {
    // 1차원 배열

    int[] exp = {50, 100, 150, 200, 250, 300};

    int[] array = new int[10];

    // 2차원 배열

    int[,] array2 = {{1, 2, 3, 4, 5}, {10, 20, 30, 40, 50}};

    // 3차원 배열

    int[,,] array3 = {{{1, 2, 3, 4, 5}, {10, 20, 30, 40, 50}}, {{1, 2, 3, 4, 5}, {10, 20, 30, 40, 50}}};

    void Start(){
        print(array3[1, 1, 2]); // 3
        print(array3[0, 0, 3]); // 4
    }
}
