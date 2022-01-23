using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnviromentManager : MonoBehaviour
{
    public GameObject enviromentObject;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnviroment", 1f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
    }
    void SpawnEnviroment()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * 50);
        Instantiate(enviromentObject, transform.position, enviromentObject.transform.rotation);
    }
}
