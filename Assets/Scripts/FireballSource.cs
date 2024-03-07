using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballSource : MonoBehaviour
{
    public Transform targetpoint;
    public Camera cameralink;
    public float targetInskyDistance;
    // Start is called before the first frame update
    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    private void Update()
    {
        var ray = cameralink.ViewportPointToRay(new Vector3 (0.5f, 0.7f, 0));

        transform.LookAt(targetpoint.position);

        RaycastHit hit;
        if (Physics.Raycast(ray,out hit))
        {
            targetpoint.position = hit.point;
        }
        else
        {
            targetpoint.position = ray.GetPoint(targetInskyDistance);
        }
    }

    
    
}
