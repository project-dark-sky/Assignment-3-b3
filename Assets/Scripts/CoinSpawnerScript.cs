using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawnerScript : MonoBehaviour
{

    public GameObject coin;
    public float spawnRate = 1;
    private float timer = 0;
    public float leftMaxBorder = -13;
    public float rightMaxBorder =13;


    // Start is called before the first frame update
    void Start()
    {
        createCoin();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            createCoin();
            timer = 0;
        }


    }

    void createCoin()
    {
 
        Instantiate(coin, new Vector3(Random.Range(leftMaxBorder, rightMaxBorder) , transform.position.y, 0) , transform.rotation);
    }


}
