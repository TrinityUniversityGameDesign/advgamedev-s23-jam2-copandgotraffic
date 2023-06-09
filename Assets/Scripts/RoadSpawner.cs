using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class RoadSpawner : MonoBehaviour
{

    public List<GameObject> roads;
    private float offset = 38f;
    // Start is called before the first frame update
    void Start()
    {
        if (roads != null && roads.Count > 0)
        {
            roads = roads.OrderBy(r => r.transform.position.x).ToList();
            for (int i = 0; i < roads.Count; i++)
            {
                Debug.Log("Road count: " + roads[i]);
            }
        }
    }

    public void MoveRoad()
    {
        GameObject moveRoad = roads[0];
        roads.Remove(moveRoad);
        float newX = roads[roads.Count - 1].transform.position.x + offset;
        moveRoad.transform.position = new Vector3(newX, 0, 0);
        roads.Add(moveRoad);
    }

}
