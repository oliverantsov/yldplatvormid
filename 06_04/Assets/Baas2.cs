using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Firebase;
using Firebase.Database;

public class Baas2 : MonoBehaviour
{
    DatabaseReference baas;
    Dictionary<string, Component> kasutajad = new Dictionary<string, Component>();
    public String mina = "oliver";

    void Start()
    {
        baas = FirebaseDatabase.DefaultInstance.RootReference;
        alusta();
    }

    async void alusta()
    {
        await baas.Child("0406").GetValueAsync().ContinueWith(task => {
            if (task.IsFaulted) { Debug.Log("probleem" + task); }
            else if (task.IsCompleted)
            {
                DataSnapshot snapshot = task.Result;
                foreach (var kataloog in snapshot.Children)
                {
                    Debug.Log(kataloog.Key);
                    baas.Child("0406").Child(kataloog.Key).ValueChanged += HandleValueChanged;

                    //kasutajad[kataloog.Key] = GameObject.CreatePrimitive(PrimitiveType.Cube).GetComponent<Component>();
                }

            }
        });
    }

    void HandleValueChanged(object sender, ValueChangedEventArgs args)
    {
        if (args.DatabaseError != null)
        {
            Debug.LogError(args.DatabaseError.Message);
        }

        DataSnapshot snapshot = args.Snapshot;
        Debug.Log(snapshot.Key+" muutis");
        if (!kasutajad.ContainsKey(snapshot.Key))
        {
            kasutajad[snapshot.Key] = GameObject.CreatePrimitive(PrimitiveType.Cube).GetComponent<Component>();
        }
        try
        {
            string x = snapshot.Child("x").Value + "";
            string y = snapshot.Child("y").Value + "";
            string z = snapshot.Child("z").Value + "";


            Vector3 asukoht = new Vector3(float.Parse(x), float.Parse(y), float.Parse(z));
            kasutajad[snapshot.Key].transform.position = asukoht;
        } catch (Exception ex)
        {
            Debug.Log(ex);
        }
    }

    // Update is called once per frame
    void Update()
    {
        bool muudetud = false;
        if (!kasutajad.ContainsKey(mina))
        {
            kasutajad[mina] = GameObject.CreatePrimitive(PrimitiveType.Cube).GetComponent<Component>();
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            kasutajad[mina].transform.position += new Vector3(-1, 0, 0);
            muudetud = true;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            kasutajad[mina].transform.position += new Vector3(1, 0, 0);
            muudetud = true;
        }
        if (muudetud)
        {
            baas.Child("0406").Child(mina).Child("x").SetValueAsync(kasutajad[mina].transform.position.x);
            baas.Child("0406").Child(mina).Child("y").SetValueAsync(kasutajad[mina].transform.position.y);
            baas.Child("0406").Child(mina).Child("z").SetValueAsync(kasutajad[mina].transform.position.z);
        }
    }
}
