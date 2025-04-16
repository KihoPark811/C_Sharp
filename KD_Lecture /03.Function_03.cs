using System.Collection;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {
  int intValue;

  float floatValue = 10.5f;
  float floatValue2 = 20.5f;

  void FloatToInt(float _parameter, float _parameter2, string _stringParameter)
  {
      intValue = (int)floatValue;
      print(intValue);
  }

  // Use this for initialization
  void Start () {
      FloatToInt(floatValue);
      FloatToInt(floatValue2);
  }

  // Update is called once per frame
  void Update () {

  }
