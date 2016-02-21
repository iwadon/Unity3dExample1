using UnityEngine;

public class FloorController : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        var z = Input.GetAxis("Horizontal");
        var x = Input.GetAxis("Vertical");
        var rot = transform.rotation;
        rot.x = rot.x + (x / 4 - rot.x) / 2;
        rot.z = rot.z + (-z / 4 - rot.z) / 2;
        transform.rotation = rot;
    }
}
