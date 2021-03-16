using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiiguKlahvidega2 : MonoBehaviour
{
    Color[] v2rvid = { Color.red, Color.blue, Color.yellow, Color.black };
    int v2rv = 0;
    int i;
    Color vanaToon;
    Collider aktiivne = null;
    // Start is called before the first frame update
    void Start()
    {

    }

    void OnTriggerEnter(Collider kujund)
    {
        Debug.Log(kujund.name);
        if (kujund.name == "Cube")
        {
            if (aktiivne != null) { aktiivsestTagasi(); }
            aktiivne = kujund;
            vanaToon = aktiivne.GetComponent<Renderer>().material.color;
            aktiivne.GetComponent<Renderer>().material.color = Color.red;
        }
        
    }

    void OnTriggerExit(Collider kujund)
    {
        if (aktiivne != null)
        {
            aktiivsestTagasi();
        }
    }

    void aktiivsestTagasi()
    {
        aktiivne.GetComponent<Renderer>().material.color = vanaToon;
        aktiivne = null;
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
            if (aktiivne == null)
            {
                Component uus = GameObject.CreatePrimitive(PrimitiveType.Cube).GetComponent<Component>();
                uus.transform.position = this.transform.position;
                int juhuarv = Random.Range(0, 3);
                int juhusuurus = Random.Range(1, 9);
                Debug.Log(juhuarv);
                //Vastavalt juhuarvule otsustada, kas panna kuubi sisse kera
                //Kera localScale valida juhuslikult vahemikust 0.3 ... 0.8
                if (juhuarv == 0)
                {
                    Component uusKera = GameObject.CreatePrimitive(PrimitiveType.Sphere).GetComponent<Component>();
                    uusKera.transform.position = this.transform.position;
                    uusKera.GetComponent<Renderer>().material.color = Color.black;
                    uusKera.transform.localScale = new Vector3(juhusuurus*0.1f, juhusuurus*0.1f, juhusuurus*0.1f);
                }
                
            }
            
        }

        //Võimalda aktiivset kujundit kustutada
        if (Input.GetKeyDown(KeyCode.K))
        {
            if (aktiivne != null)
            {
                Destroy(aktiivne.gameObject);
            }
        }

        //Võimalda aktiivse kujundi värvi vahetada
        if (Input.GetKeyDown(KeyCode.C))
        {
            v2rv++;
            if (v2rv >= v2rvid.Length)
            {
                v2rv = 0;
            }
            aktiivne.GetComponent<Renderer>().material.color = v2rvid[v2rv];
            vanaToon = v2rvid[v2rv];
        }

        //Minecraft-stiilis kustutamine (ploki sees on kindel arv asju, destroy'des kustutab "välise" ploki ära & näitab sisemisi objekte)

    }
}
