using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Force : MonoBehaviour
{
    [SerializeField] private GameObject Circle, barra;
    [SerializeField] private bool Jogador1;
    [SerializeField] private Transform spawnbarra;
    private float force;
    

    // Update is called once per frame
    void Update()
    {
        if(Jogador1)
        {   
            if(Input.GetKeyDown(KeyCode.Space))
            {   
                Instantiate(barra, new Vector3(0, 0, 0), Quaternion.identity);   
            }
            if(Input.GetKey(KeyCode.Space))
            {   
                Debug.Log("player 1");

                barra.GetComponent<barravaria>().variar();
                force = barra.transform.lossyScale.y * 5;     
            }

            if(Input.GetKeyUp(KeyCode.Space))
            {
              Destroy(barra);
            }   

            if(Circle.transform.position.x > 3.85f && Input.GetKeyUp(KeyCode.Space))
                {
                    Circle.GetComponent<movement>().moveBolinha(force, Jogador1);
                    Debug.Log("player 1 parry");
                    force = 0f;
                }
        }
        else
        {
            Debug.Log("player 2");
             if(Input.GetKeyDown(KeyCode.K))
            {   
               Instantiate(barra, new Vector3(1, 2, 0), Quaternion.identity);  
            }

            if(Input.GetKey(KeyCode.K))
            {
                  barra.GetComponent<barravaria>().variar();
                  force = barra.transform.lossyScale.y * 5;
            }
            
            if(Input.GetKeyUp(KeyCode.K))
            {
              Destroy(barra);
            }   

            if(Circle.transform.position.x > 3.85f && Input.GetKeyUp(KeyCode.K))
                {
                    Circle.GetComponent<movement>().moveBolinha(force, Jogador1);
                    Debug.Log("player 2 parry");
                    force = 0f;
                }
        }
    }
}
    