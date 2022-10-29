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
        Debug.LogFormat("현재 쓰레드 : {0}", Thread.CurrentThread.ManagedThreadId);
        Debug.LogFormat("현재 프래임 : {0}", Time.frameCount);

        StartCoroutine(CoJob());
    }

    IEnumerator CoJob()
    {
        // 잡 생성
        TestJob testJob;

        // 스케줄링
        JobHandle Handle = testJob.Schedule(1000, 64);  // For 문을 1000번 돌리겠다는 의미
                                                        // 한번에 몇개씩 작업을 할것인지를 의미 (한번에 64개씩 작업하겠다는 의미)
                                                        // 즉 1000번을 64개씩 나눠서 작업하겠다는 의미

        // 안전하게 비동기로 작업을 진행할 수 있다.
        while (!Handle.IsCompleted)
        {
            yield return null;
        }

        Handle.Complete();

        Debug.LogFormat("현재 프래임 : {0}", Time.frameCount);
    }

    // 여러개를 동시에 사용
    struct TestJob : IJobParallelFor
    {
        public void Execute(int index)
        {
            Debug.Log($"병렬 쓰레드 인덱스 값 : {index}");
        }
    }
}
