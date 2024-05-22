using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text _score1Text; // Direct reference to the Score1 Text component
    public Text _score2Text; // Direct reference to the Score2 Text component

    public BoxCollider2D _collision1;
    public BoxCollider2D _collision2;

    public BoxCollider2D _collisionBall;
    public Ball _ball;

    public int _score1 = 0;
    public int _score2 = 0;

    private bool _scoreFlag1= false;
    private bool _scoreFlag2 = false;
    void Start()
    {
       
    }
    // Update is called once per frame
    void Update()
    {


        if (_collision1.IsTouching(_collisionBall) && !_scoreFlag1)
        {
            _score2++;
            _score2Text.text = _score2.ToString();

            _ball.restart();
            _scoreFlag1 = true;
        }
        else if (!_collision1.IsTouching(_collisionBall))
        {
            
            _scoreFlag1 = false;
        }

        if (_collision2.IsTouching(_collisionBall) && !_scoreFlag2)
        {
            _score1++;
            _score1Text.text = _score1.ToString();

            _ball.restart();
            _scoreFlag2 = true;
        }
        else if (!_collision2.IsTouching(_collisionBall))
        {
            
            _scoreFlag2 = false;
        }


    }
}
