using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class up : MonoBehaviour
{

    //��� ������.
    public GameObject box;
    GameObject player;

    //������������� ���������� ������������ ��������� �����������.
    public float S;
    public float K;

    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }

    //����� ������� ����� ���������� �� ������� ����� ������.
    public void Update()
    {
        float direction = player.transform.position.x - transform.position.x;
        if ((Input.GetKey(KeyCode.M)) && (Mathf.Abs(direction) < 1))
        {
            box.transform.Translate(0, S, 0);
        }

        if ((Input.GetKey(KeyCode.N)) && (Mathf.Abs(direction) < 1))
        {
            box.transform.Translate(0, 0 - K, 0);
        }
    }
}