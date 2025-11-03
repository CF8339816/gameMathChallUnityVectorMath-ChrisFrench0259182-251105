using UnityEditor.ShaderGraph.Internal;
using UnityEngine;

public class movePlat2 : MonoBehaviour
{
    [SerializeField] int speed = 0;
    [SerializeField] int xmove = 0;
    [SerializeField] int ymove = 0;
    [SerializeField] int zmove = 0;
    Vector3 startPosition;

    void Start()
    {

        transform.position = startPosition;
       // transform.position = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {//Time.time
        transform.position = new Vector3(0 + 10 * Mathf.Sin(Time.time * xmove), 0 , 0);
        transform.position = new Vector3(0, 0 + 10 * Mathf.Sin(Time.time * ymove), 0);
        transform.position = new Vector3(0, 0 , 0 + 10 * Mathf.Sin(Time.time * zmove));
    }
}