using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.Jobs;
using UnityEngine;

public class JobSystemTest2 : MonoBehaviour
{
    // https://www.youtube.com/watch?v=IzTbKdL8w8Q
    // 33:28

    // Start is called before the first frame update
    void Start()
    {
        Debug.LogFormat("���� ������ : {0}", Thread.CurrentThread.ManagedThreadId);
        Debug.LogFormat("���� ������ : {0}", Time.frameCount);

        StartCoroutine(CoJob());   
    }

    IEnumerator CoJob()
    {
        // �� ����
        TestJob testJob;

        // �����ٸ�
        JobHandle Handle = testJob.Schedule();

        // �����ϰ� �񵿱�� �۾��� ������ �� �ִ�.
        while(!Handle.IsCompleted)
        {
            yield return null;
        }

        Handle.Complete();

        Debug.LogFormat("���� ������ : {0}", Time.frameCount);
    }

    struct TestJob : IJob
    {
        public void Execute()
        {
            // ���� �۾��� ���⼭ ó��
            Debug.LogFormat("���� ������ : {0}", Thread.CurrentThread.ManagedThreadId);
            print("�۾� ����");
        }
    }
}
