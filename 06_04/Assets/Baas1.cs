using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Firebase;
using Firebase.Database;

public class Baas1 : MonoBehaviour
{
    DatabaseReference baas;
    Vector3 asukoht;
    Component jaagup;
    Component oliver;

    void Start()
    {
        jaagup = GameObject.CreatePrimitive(PrimitiveType.Cube).GetComponent<Component>();
        oliver = GameObject.CreatePrimitive(PrimitiveType.Cube).GetComponent<Component>();
        baas = FirebaseDatabase.DefaultInstance.RootReference;

        baas.Child("0406").Child("jaagup").GetValueAsync().ContinueWith(task => {
            if (task.IsFaulted) { Debug.Log("probleem" + task); }
            else if (task.IsCompleted)
            {
                DataSnapshot snapshot = task.Result;
                //Debug.Log(snapshot); 
                //Debug.Log(snapshot.Value);
                //Debug.Log(snapshot.GetRawJsonValue());
                Debug.Log(snapshot.Child("x").Value);
                float ax = float.Parse(snapshot.Child("x").Value + "");
                Debug.Log("arv " + ax);
                asukoht = new Vector3(
                  float.Parse(snapshot.Child("x").Value + ""),
                  float.Parse(snapshot.Child("y").Value + ""),
                  float.Parse(snapshot.Child("z").Value + ""));
                Debug.Log(asukoht);
                //jaagup.transform.position=asukoht;
                Debug.Log("kohal");
            }
        });
        baas.Child("0406").Child("jaagup").ValueChanged += HandleValueChanged;

        baas.Child("0406").Child("oliver").SetValueAsync(this.transform.position.x);
        baas.Child("0406").Child("oliver").SetValueAsync(this.transform.position.y);
        baas.Child("0406").Child("oliver").SetValueAsync(this.transform.position.z);
    }

    void HandleValueChanged(object sender, ValueChangedEventArgs args)
    {
        if (args.DatabaseError != null)
        {
            Debug.LogError(args.DatabaseError.Message);
        }

        DataSnapshot snapshot = args.Snapshot;
        Debug.Log(snapshot.Key);
        string x = snapshot.Child("x").Value + "";
        string y = snapshot.Child("y").Value + "";
        string z = snapshot.Child("z").Value + "";
        

        asukoht = new Vector3(float.Parse(x), float.Parse(y), float.Parse(z));
        oliver.transform.position = asukoht;
    }

    // Update is called once per frame
    void Update()
    {
        jaagup.transform.position = asukoht;
    }
}
