using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.Jobs;
using UnityEngine;

public class JobSystemTest3 : MonoBehaviour
{
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
        JobHandle Handle = testJob.Schedule(1000, 64);  // For ���� 1000�� �����ڴٴ� �ǹ�
                                                        // �ѹ��� ��� �۾��� �Ұ������� �ǹ� (�ѹ��� 64���� �۾��ϰڴٴ� �ǹ�)
                                                        // �� 1000���� 64���� ������ �۾��ϰڴٴ� �ǹ�

        // �����ϰ� �񵿱�� �۾��� ������ �� �ִ�.
        while (!Handle.IsCompleted)
        {
            yield return null;
        }

        Handle.Complete();

        Debug.LogFormat("���� ������ : {0}", Time.frameCount);
    }

    // �������� ���ÿ� ���
    struct TestJob : IJobParallelFor
    {
        public void Execute(int index)
        {
            Debug.Log($"���� ������ �ε��� �� : {index}");
        }
    }
}
