using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.Jobs;
using UnityEngine;

public class JobSystemTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.LogFormat("���� ������ : {0}", Thread.CurrentThread.ManagedThreadId);
        Debug.LogFormat("���� ������ : {0}", Time.frameCount);

        // �� ����
        TestJob testJob;

        // �����ٸ�
        //testJob.Schedule(); // ���� �����忡 �����ٸ����� ������ �����ٸ��� �۾��� ��ũ��������� ������. �̶� ��ũ������(����Ƽ����...)�� "�񾲷���"��� �Ҹ�, �ھ��� ������ŭ ����(ex �����ھ�� 4���� �⾲���� ����)

        // �ش� �۾��� ���������� ����ϰ� �ʹٸ�
        JobHandle Handle = testJob.Schedule();
        Handle.Complete();

        Debug.LogFormat("���� ������ : {0}", Time.frameCount);
    }

    // IJob�� �񵿱�� ���� �����带 �ϳ� �� ����ϰڴٴ� �ǹ�
    struct TestJob : IJob
    {
        public void Execute()
        {
            // ���� �۾��� ���⼭ ó��
            Debug.LogFormat("���� ������ : {0}", Thread.CurrentThread.ManagedThreadId);
            print("�۾� ����");
        }
    }

    struct TestJob2 : IJob
    {
        public void Execute()
        {
            Debug.LogFormat("���� ������ : {0}", Thread.CurrentThread.ManagedThreadId);
            print("�۾� ����2");
        }
    }
}
