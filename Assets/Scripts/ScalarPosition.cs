//using System;
//using UnityEngine;

//public class ScalarPosition : MonoBehaviour
//{

//    [SerializeField] float step;
//    static int scalar = 1;




//    // Start is called once before the first execution of Update after the MonoBehaviour is created
//    void Start()
//    {
//        Vector3 startPos = new Vector3(0, 0, 0); 
//    }

//    // Update is called once per frame
//    void Update()
//    {
    

//        if (!Console.KeyAvailable) return;

//        ConsoleKeyInfo inputKey = Console.ReadKey(true);

//        if (inputKey.Key == ConsoleKey.S)  startPos = startPos * scalar -= 1;

//        if (inputKey.Key == ConsoleKey.W) startPos = startPos + scalar += 1;



//    }
//}
