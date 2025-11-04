using UnityEngine;

public class PositionSummer : MonoBehaviour
{
    [Header("MovementObjectsToSum")]
    public GameObject cubeA;
    public GameObject cubeB;

    void Update()
    {
       
        if (cubeA != null && cubeB != null)
        {
            transform.position = cubeA.transform.position + cubeB.transform.position;
        }
    }
}
