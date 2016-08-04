using UnityEngine;
using System.Collections;

public class PlayerWitcher : Witcher
{
    public Vector3 wayPoint;
    void Start()
    {
        wayPoint = transform.position;
    }

    public void FixedUpdate()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                Debug.Log("hit");
                wayPoint = new Vector3(hit.point.x, hit.point.y, transform.position.z);
            }
        }
        transform.position = Vector3.MoveTowards(transform.position, wayPoint, speed * Time.fixedDeltaTime);
        Debug.DrawLine(transform.position, wayPoint, Color.red);
    }
}
