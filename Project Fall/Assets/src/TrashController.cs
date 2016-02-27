using UnityEngine;
using System.Collections;

public class TrashController : MonoBehaviour
{

    private int[] rotatespeed = { 21, 26, 31, 36, 41 };
    public int rand;
    // Use this for initialization
    void Start()
    {
        rand = Random.Range(0, rotatespeed.Length);
    }

    // Update is called once per frame
    void Update()
    {
        // if(Input.GetKey(KeyCode.LeftArrow))
        transform.Rotate(Time.deltaTime * rotatespeed[rand], Time.deltaTime * rotatespeed[rand], 0, Space.World);
    }
}
