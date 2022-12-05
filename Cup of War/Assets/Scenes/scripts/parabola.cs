using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parabola : MonoBehaviour
{
    private Rigidbody2D _rigidBody;
    public float _speed;
    [SerializeField] private GameObject pontoa, pontob;
    private Vector2 nextPos;
    
    void awake()
    {
        _rigidBody = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        nextPos = pontob.transform.position;
    }
 
     // Update is called once per frame
    void Update()
    {
        movingball();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _rigidBody.AddForce(new Vector2(transform.position.x * 10f, transform.position.y * 10f));
        }
    }

    private void movingball()
    {
        if(transform.position == pontoa.transform.position)
        {   
            nextPos = pontob.transform.position;

        }
        if (transform.position == pontob.transform.position)
        {
            nextPos = pontoa.transform.position;

        }
        transform.position = Vector2.MoveTowards(transform.position, nextPos, _speed * Time.deltaTime);
    }
 }



