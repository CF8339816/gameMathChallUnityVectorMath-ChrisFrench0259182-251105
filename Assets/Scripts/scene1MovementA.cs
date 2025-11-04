


using UnityEngine;
using UnityEditor.ShaderGraph.Internal;
public class scene1MovementA : MonoBehaviour
{
    [Header("Movement")]
    [SerializeField] float slide = 1.0f;
    [SerializeField] int speed = 0;
    [SerializeField] Vector3 startPosition;
    [SerializeField] float yOffset = 0;
    [SerializeField] float zOffset = 0;
    [SerializeField] float xOffset = 0;

    void Start()
    {
      
        startPosition = transform.position;
    }

    void Update()
    {

        float yOffset = Mathf.Sin(Time.time * speed) * slide;
        Vector3 newPositionY = startPosition + new Vector3(0, yOffset, 0);
        float xOffset = Mathf.Sin(Time.time * speed) * slide;
        Vector3 newPositionX = startPosition + new Vector3( xOffset, 0, 0);
        float zOffset = Mathf.Sin(Time.time * speed) * slide;
        Vector3 newPositionZ = startPosition + new Vector3(0, 0, zOffset);



        transform.position = newPositionX + newPositionY + newPositionZ;
    }
}


//{
//    [SerializeField] int speed = 0;
//    [SerializeField] int xmove = 0;
//    [SerializeField] int ymove = 0;
//    [SerializeField] int zmove = 0;
//    Vector3 startPosition;

//    void Start()
//    {

//        transform.position = startPosition;
//       // transform.position = new Vector3(0, 0, 0);
//    }

//    // Update is called once per frame
//    void Update()
//    {//Time.time
//        transform.position = new Vector3(0 + 10 * Mathf.Sin(Time.time * xmove), 0 , 0);
//        transform.position = new Vector3(0, 0 + 10 * Mathf.Sin(Time.time * ymove), 0);
//        transform.position = new Vector3(0, 0 , 0 + 10 * Mathf.Sin(Time.time * zmove));
//    }
//}