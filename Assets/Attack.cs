using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{

    //Player��Animator�R���|�[�l���g�ۑ��p
    private Animator animator;

    // Use this for initialization
    void Start()
    {
        //Player��Animator�R���|�[�l���g���擾����
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        //A��������jab
        if (Input.GetKeyDown(KeyCode.A))
        {
            animator.SetBool("Jab", true);
        }

        //S��������Hikick
        if (Input.GetKeyDown(KeyCode.S))
        {
            animator.SetBool("Hikick", true);
        }

        //D��������Spinkick
        if (Input.GetKeyDown(KeyCode.D))
        {
            animator.SetBool("Spinkick", true);
        }

    }

}