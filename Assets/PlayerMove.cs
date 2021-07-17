using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    //�d�͓��̕ύX���ł���悤�Ƀp�u���b�N�ϐ��Ƃ���
    public float gravity;
    public float speed;
    public float jumpSpeed;
    public float rotateSpeed;

    //�O������l���ς��Ȃ��悤��Private�Œ�`
    private CharacterController characterController;
    private Animator animator;
    private Vector3 moveDirection = Vector3.zero;

    // Use this for initialization
    void Start()
    {
        characterController = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        //ray���g�p�����ڒn����
        if (CheckGrounded() == true)
        {

            //�O�i����
            if (Input.GetKey(KeyCode.UpArrow))
            {
                moveDirection.z = speed;
            }
            else
            {
                moveDirection.z = 0;
            }

            //�����]��
            //�����L�[�̂ǂ����������Ă��鎞
            if (Input.GetKey(KeyCode.LeftArrow) && Input.GetKey(KeyCode.RightArrow))
            {
                //������ς��Ȃ�
            }
            //�������L�[��������Ă��鎞
            else if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Rotate(0, rotateSpeed * -1, 0);
            }
            //�E�����L�[��������Ă��鎞
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.Rotate(0, rotateSpeed, 0);
            }

            //jump
            if (Input.GetKeyDown(KeyCode.Space))
            {
                moveDirection.y = jumpSpeed;
            }

            //�d�͂𔭐�������
            moveDirection.y -= gravity * Time.deltaTime;

            //�ړ��̎��s
            Vector3 globalDirection = transform.TransformDirection(moveDirection);
            characterController.Move(globalDirection * Time.deltaTime);

            //���x���O�ȏ�̎��ARun�����s����
            animator.SetBool("Run", moveDirection.z > 0.0f);
        }
    }

    //ray���g�p�����ڒn���胁�\�b�h
    public bool CheckGrounded()
    {

        //�����ʒu�ƌ���
        var ray = new Ray(transform.position + Vector3.up * 0.1f, Vector3.down);

        //ray�̒T���͈�
        var tolerance = 0.3f;

        //ray��Hit����
        //�������F��΂�Ray
        //�������FRay�̍ő勗��
        return Physics.Raycast(ray, tolerance);
    }

}