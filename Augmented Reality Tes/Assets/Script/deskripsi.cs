using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class deskripsi : MonoBehaviour
{

    [Header("Deskripsi Senjata")]
    public TrackableAR[] tr;
    public string[] nama;
    [TextArea]
    public string[] deskrip;

    [Header("UI Deskripsi")]
    public Text txtNama;
    public Text txtDeskripsi;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < tr.Length; i++)
        {
            if (tr[i].GetMarker())
            {
                txtNama.text = nama[i];
                txtDeskripsi.text = deskrip[i];
                print("nama berhasil");
            }
            else
            {
                txtNama.text = "";
                txtDeskripsi.text = "";
            }
        }
    }
}

