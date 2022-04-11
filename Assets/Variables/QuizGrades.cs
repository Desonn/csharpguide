using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizGrades : MonoBehaviour
{
    [SerializeField]
    float _quiz1, _quiz2, _quiz3, _quiz4, _quiz5;
    [SerializeField]
    float _average;
    // Start is called before the first frame update
    void Start()
    {
        float quizTotal = _quiz1 + _quiz2 + _quiz3 + _quiz4  + _quiz5;
        _average = quizTotal/5;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
