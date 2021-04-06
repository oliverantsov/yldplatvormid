using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keskus : MonoBehaviour
{
    // Start is called before the first frame update
    Component kera;
    Component juhtKera;
    Component tabamisKera;
    float m = 1;
    float g = -9.8f;
    float jaikus = 25; //njuutonit meetri kohta
    Vector3 v = new Vector3(0, 0, 0);
    //Lisage muutuja nööri pikkuse tarbeks
    //Elastsusjõud tekib võrdeliselt kera ja juhtKera kaugusega, mis ületab nööri pikkust
    float kummipikkus = 0.5f;
    //Kuva palli värvi abil, et kui suure pinge all on kumm
    //Lisa kummile maxpikkus - üle selle kumm katkeb ja pall kukub vabalt minema
    //Iga kaadriga kiirus veidi väheneb
    float ohukoef = 0.994f;
    float maxpikkus = 10f;
    void Start()
    {
        kera = GameObject.CreatePrimitive(PrimitiveType.Sphere).GetComponent<Component>();
        juhtKera = GameObject.CreatePrimitive(PrimitiveType.Sphere).GetComponent<Component>();
        tabamisKera = GameObject.CreatePrimitive(PrimitiveType.Sphere).GetComponent<Component>();
        juhtKera.transform.position = new Vector3(0, 3, 0);
        juhtKera.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
        tabamisKera.transform.position = new Vector3(9, 5, 0);
    }

    // Update is called once per frame
    void Update()
    {
        //Juhtpall jälgib ainult allavajutatud hiirt
        if (Input.GetMouseButton(0))
        {
            juhtKera.transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10));
            /*if(tabamisKera.transform.position.x = kera.transform.position.x | tabamisKera.transform.position.y = kera.transform.position.y) 
            { 
                tabamisKera.GetComponent<Renderer>().material.color = new Color(1, 1, 1, 1);
            }*/
        }

        Vector3 kumm = juhtKera.transform.position - kera.transform.position;
        float kummijoud = 0;
        if (kummipikkus < kumm.magnitude)
        {
            kummijoud = (kumm.magnitude - kummipikkus) * jaikus;
            float varv = 1 - (kumm.magnitude - kummipikkus) / (maxpikkus - kummipikkus);
            kera.GetComponent<Renderer>().material.color = new Color(1, varv, varv, 1);
        }
        else
        {
            kera.GetComponent<Renderer>().material.color = new Color(1, 1, 1, 1);
        }
        float kiirendus = kummijoud / m;
        if(kumm.magnitude < maxpikkus)
        {
            v += Time.deltaTime * kumm.normalized * kiirendus;
        }
        v += Time.deltaTime * Vector3.up * g;
        v = v * ohukoef;
        kera.transform.position += v * Time.deltaTime;


        //Kui pall kukub alla koordinaati -50, siis tekib uuesti juhtpalli asukohta.
        if (kera.transform.position.y <= -50)
        {
            kera.transform.position = juhtKera.transform.position;
        }

    }
}

/*
   *  On vaid piiratud ala, kus saab juhtpalli liigutada;
   *  Kui kerale saadakse pihta, siis antakse mingitmoodi märku;
*/