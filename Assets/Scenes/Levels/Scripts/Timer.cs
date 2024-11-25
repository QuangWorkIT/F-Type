using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Timer : MonoBehaviour
{
    public TMP_Text time;
    public float timer;
    // Start is called before the first frame update
    void Start()
    {
        time.text = Mathf.Ceil(timer).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
            time.text = Mathf.Ceil(timer).ToString();
        }
        else
        {
            time.text = "0";
            end();
            Debug.Log("End time");
        }
    }

    private void end()
    {
        PlayerControllerScript moveMent = FindObjectOfType<PlayerControllerScript>();
        WeaponScript fire = FindObjectOfType<WeaponScript>();
        if (moveMent != null && fire != null)
        {
            moveMent.enabled = false;
            fire.enabled = false;
        }
    }
}
