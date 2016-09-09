using UnityEngine;
using System.Collections;

public class CreateWallScript : MonoBehaviour
{
    public GameObject wallObj;
    public GameObject startPoint;

    public void CreateWall()
    {
        //float _x = startPoint.transform.position.x;
        //float _y = startPoint.transform.position.y;

        for (int j = 0; j < 50; j++)
        {
            for (int i = 0; i < 50; i++)
            {
                Instantiate(wallObj, new Vector3(i, j, 0), Quaternion.identity);
            }
        }


    }
}
