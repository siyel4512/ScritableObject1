// ���� ��α� : https://blog.naver.com/cdw0424/221592662392

using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.Jobs;
using UnityEngine;
using Unity.Collections;

public class JobSystemTest4 : MonoBehaviour
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

        var A = new NativeArray<int>(100, Allocator.TempJob); // NativeArray<int>(�迭�� � ���� ���������, Allocator.TempJob....)
        var B = new NativeArray<int>(100, Allocator.TempJob); //Allocator.Temp... ���� �ݵ�� �޸𸮸� ��ȯ������Ѵ�.
        var Result = new NativeArray<int>(100, Allocator.TempJob);

        // �� �־��ֱ�
        for (int i = 0; i < 100; i++)
        {
            A[i] = i;
            yield return null;
        }
        for (int i = 0; i < 100; i++)
        {
            B[i] = i;
            yield return null;
        }

        // �� ����
        TestJob testJob;

        // ������
        testJob.a = A;
        testJob.b = B;
        testJob.result = Result;

        // �����ٸ�
        JobHandle Handle = testJob.Schedule(100, 32);

        // �����ϰ� �񵿱�� �۾��� ������ �� �ִ�.
        while (!Handle.IsCompleted)
        {
            yield return null;
        }

        Handle.Complete();

        for (int i = 0; i < 100; i++)
        {
            Debug.LogFormat("��� : {0} + {1} = {2}", A[i], B[i], Result[i]);
            yield return null;
        }

        // �޸� ����
        A.Dispose();
        B.Dispose();
        Result.Dispose();
    }

    // ��ȯ��
    struct TestJob : IJobParallelFor
    {
        public NativeArray<int> a;
        public NativeArray<int> b;
        public NativeArray<int> result;

        public void Execute(int index)
        {
            result[index] = a[index] + b[index];
        }
    }
}
