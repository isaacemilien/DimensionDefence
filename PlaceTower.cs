using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceTower : MonoBehaviour
{
    #region FIELDS
    Camera camera;
    [SerializeField] GameObject tower;
        
    #endregion

    #region MONOBEHAVIOUR METHODS 

    void Start()
    {
        camera = GetComponent<Camera>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                Transform objectHit = hit.transform;
                if(objectHit.tag == "PlaceBlock")
                {
                    //Instantiate(tower, objectHit.transform.position, Quaternion.identity);
                    tower.transform.position = new Vector3(objectHit.position.x, objectHit.position.y + 1, objectHit.position.z);
                }
            }
        }
    }
    #endregion

    #region METHODS 
    
    #endregion
}
