using System;
using UnityEngine;

public class scene2ScalarPosition : MonoBehaviour
{

    [SerializeField] float step= 0.1f;
    static int scalar = 1;




    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Vector3 startPos = new Vector3(0, 0, 0);
        startPos = transform.position;
        transform.position = startPos * scalar;
    }

    // Update is called once per frame
    void Update()
    {
        //if (!Console.KeyAvailable) return;
        //ConsoleKeyInfo inputKey = Console.ReadKey(true);
        //if (inputKey.Key == ConsoleKey.S)
        //{
        //    scalar -= (int)step;
        //}
        //if (inputKey.Key == ConsoleKey.W)
        //{
        //    scalar += (int)step;
        //}


        if (Input.GetKeyDown(KeyCode.W))
        {
            
            scalar += (int)step;
          
        }

        
        if (Input.GetKeyDown(KeyCode.S))
        {
            
            scalar -= (int)step;
           
        }


    }

   
}
