using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 3.0f;

    void Update()
    {
        Vector3 playerInput = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        Vector3 hizEklentisi = playerInput * Time.deltaTime * speed;

        transform.Translate(hizEklentisi);
    }
}
