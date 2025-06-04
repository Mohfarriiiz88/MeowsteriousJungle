using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class latihan1 : MonoBehaviour
{
    // Start is called before the first frame update

    public int healt = 100;
    float speed = 5.5f;
    bool isLive = true;
    string namaPlayer = "sadako";
    char grade = 'A';


    void Start()
    {
        int serangan = 80;
        healt = healt - serangan;
        Debug.Log("Healrh Player : " + healt);

        bool isDead = (healt < -0);
        Debug.Log("apakah Player mati? : " + isDead);

        if (isLive && healt > 50)
        {
            Debug.Log("Masih Hidup Kamu");
        } else if (healt > 0)
        {
            Debug.Log("Hati hati coy");
        }
        else
        {
            Debug.Log("Masih Hidup Kamu");
            isLive = false;
        }

        ambil();
        SkilTambahDarah(30);

        StartCoroutine(contohCoro());
        StatusPlayer(30);
    }
    public void ambil()
    {
        Debug.Log(namaPlayer);
    }
    public void SkilTambahDarah(int dr) {
        healt = healt + dr;
        Debug.Log("Player telah bertambah Darahnya " + healt);
    }
    // Update is called once per frame
    string StatusPlayer(int darah)
    {
        if (darah > 50)
            return "hidup";
        else if (darah > 0)
            return "lemah";
        else
            return "Mati ";

    }
    IEnumerator contohCoro()
    {
        Debug.Log("Sebelum");
        yield return new WaitForSeconds(2f);
        Debug.Log("Sesudah");
    }
    void Update()
    {
        
    }
}
