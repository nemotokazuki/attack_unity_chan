using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHit : MonoBehaviour
{

    //�I�u�W�F�N�g�ƐڐG�����u�ԂɌĂяo�����
    void OnTriggerEnter(Collider other)
    {

        //�U���������肪Enemy�̏ꍇ
        if (other.CompareTag("Enemy"))
        {

            Destroy(other.gameObject);

        }
    }
}