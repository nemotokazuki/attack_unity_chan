using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{

    //Player��Animator�R���|�[�l���g�ۑ��p
    private Animator animator;



    //����̃R���C�_�[
    private Collider handCollider;
    //�E���̃R���C�_�[
    private Collider footCollider;



    // Use this for initialization
    void Start()
    {
        //Player��Animator�R���|�[�l���g���擾����
        animator = GetComponent<Animator>();

        //����̃R���C�_�[���擾
        handCollider = GameObject.Find("Character1_LeftHand").GetComponent<SphereCollider>();
        //�E���̃R���C�_�[���擾
        footCollider = GameObject.Find("Character1_RightToeBase").GetComponent<SphereCollider>();
    }

    // Update is called once per frame
    void Update()
    {

        //A��������jab
        if (Input.GetKeyDown(KeyCode.A))
        {
            animator.SetBool("Jab", true);

            //����R���C�_�[���I���ɂ���
            handCollider.enabled = true;

            //��莞�Ԍ�ɃR���C�_�[�̋@�\���I�t�ɂ���
            Invoke("ColliderReset", 0.3f);
        }

        //S��������Hikick
        if (Input.GetKeyDown(KeyCode.S))
        {
            animator.SetBool("Hikick", true);

            //�E���R���C�_�[���I���ɂ���
            footCollider.enabled = true;

            //��莞�Ԍ�ɃR���C�_�[�̋@�\���I�t�ɂ���
            Invoke("ColliderReset", 1.5f);
        }

        //D��������Spinkick
        if (Input.GetKeyDown(KeyCode.D))
        {
            animator.SetBool("Spinkick", true);

            //�E���R���C�_�[���I���ɂ���
            footCollider.enabled = true;

            //��莞�Ԍ�ɃR���C�_�[�̋@�\���I�t�ɂ���
            Invoke("ColliderReset", 1.5f);
        }

    }
    private void ColliderReset()
    {
        handCollider.enabled = false;
        footCollider.enabled = false;
    }

}