using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class movement : MonoBehaviour
{

    [SerializeField] private Transform Circle;
    [SerializeField] private float _speed = 10f;
    [SerializeField] public float _force = 5f;
    [SerializeField] private Transform Player1;
    [SerializeField] private Transform Player2;


    
    // Start is called before the first frame update
    void Start()
    {   
        transform.DOJump(new Vector2(4f, 0), _force, -1, _speed);
    }

    void Update()
    {

        if(transform.position.y < 0.49f && transform.position.x < 0)
        {
            transform.DOJump(new Vector2(Player2.position.x, 0), _force, -1, _speed);
        }

        if(transform.position.y < 0.49f && transform.position.x > 0)
        {
            transform.DOJump(new Vector2(Player1.position.x, 0), _force, -1, _speed);
        }

    }

    public void moveBolinha(float _force, bool Jogador1){
        if(Jogador1){
            transform.DOJump(new Vector2(Player2.position.x, 0), _force, -1, _speed);
        }
        else
        {
            transform.DOJump(new Vector2(Player1.position.x, 0), _force, -1, _speed);
        }
    }  
}
