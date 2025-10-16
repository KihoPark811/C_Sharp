using System.Collection;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {
  int intValue;

  float floatValue = 10.5f;
  float floatValue2 = 20.5f;

  void FloatToInt(float _parameter, float _parameter2, string _stringParm = "디폴트값") // 디폴트값은 입력 파라미터가 없다면 디폴트값이 사용된다.
  {
      intValue = (int)(_parameter + _parameter2); 
      print(intValue);
      print(_stringParm);
  }

  // Use this for initialization
  void Start () {
      FloatToInt(floatValue, floatValue2, "테스트");
  }

  // Update is called once per frame
  void Update () {

  }
