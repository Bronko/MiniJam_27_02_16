using UnityEngine;
using System.Collections;

public class PrefabSpawner : MonoBehaviour
{

    public GameObject[] prefabs;
    public GameObject player;

    private Rigidbody myRB;
    public Transform Reference;

    private float time;
    private int randPrefab;

    private float randPositionX, randPositionZ, randPositionY;
    private Vector3 RandSize;
    // x 130 -440
    //z -160 120
    // Use this for initialization

        void Awake()
    {

        myRB = player.GetComponent<Rigidbody>();
    }
    void Start()
    {
        time = Time.time;
    }

    // Update is called once per frame
    void Update()
    {


        Vector3 offset = myRB.velocity;
        

        offset.Normalize();
        offset *= 200;
        offset += (-myRB.transform.up * 400) + (myRB.transform.forward * 800);
        for (int i = 0; i < 1; ++i)
        {
            float size = Random.Range(1, 40) / 10f;
            RandSize = new Vector3(
                size,
                size,
                size
                );
                randPrefab = Random.Range(0, prefabs.Length);
                randPositionX = Random.Range(player.transform.position.x - 190, player.transform.position.x +190);
                randPositionY = Random.Range(player.transform.position.y - 190, player.transform.position.z + 190);
                randPositionZ = Random.Range(player.transform.position.z - 190, player.transform.position.z + 190);
                GameObject go = Instantiate(prefabs[randPrefab], offset + new Vector3(randPositionX, randPositionY, randPositionZ), Quaternion.identity) as GameObject;
            go.transform.localScale = RandSize;
            go.transform.Rotate(Random.Range(0, 360), Random.Range(0, 360), Random.Range(0, 360));
            }
      
    }
}
