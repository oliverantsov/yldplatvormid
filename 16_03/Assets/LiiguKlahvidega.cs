using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiiguKlahvidega : MonoBehaviour
{
    Color[] v2rvid = { Color.red, Color.blue, Color.yellow, Color.black };
    int v2rv = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            this.transform.position += new Vector3(-1, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            this.transform.position += new Vector3(1, 0, 0);
        }

        //lisa klahvid y-suunas liikumiseks
        if (Input.GetKeyDown(KeyCode.W))
        {
            this.transform.position += new Vector3(0, 1, 0);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            this.transform.position += new Vector3(0, -1, 0);
        }

        //lisa klahvid z-suunas liikumiseks
        if (Input.GetKeyDown(KeyCode.Z))
        {
            this.transform.position += new Vector3(0, 0, 1);
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            this.transform.position += new Vector3(0, 0, -1);
        }

        //Kui oled jõudnud kohale x=5, y=3, siis kukud algkohta tagasi
        if (this.transform.position.x == 5 && this.transform.position.y == 3)
        {
            this.transform.position = new Vector3(0, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.U))
        {
            Component uus = GameObject.CreatePrimitive(PrimitiveType.Cube).GetComponent<Component>();
            uus.transform.position = this.transform.position;
            uus.GetComponent<Renderer>().material.color = this.GetComponent<Renderer>().material.color;
        }

        //Aktiivne värv on liikuva kuubiku peal, seda saab klahviga muuta
        if (Input.GetKeyDown(KeyCode.C))
        {
            v2rv++;
            if (v2rv >= v2rvid.Length)
            {
                v2rv = 0;
            }
            this.GetComponent<Renderer>().material.color = v2rvid[v2rv];
        }

        Ray kiir = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if(Physics.Raycast(kiir, out hit, 100))
        {
            if (Input.GetKeyDown(KeyCode.K))
            {
                Destroy(hit.collider.gameObject);
            }
        }

    }
}
