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
        Debug.LogFormat("현재 쓰레드 : {0}", Thread.CurrentThread.ManagedThreadId);
        Debug.LogFormat("현재 프래임 : {0}", Time.frameCount);

        StartCoroutine(CoJob());   
    }

    IEnumerator CoJob()
    {
        // 잡 생성
        TestJob testJob;

        // 스케줄링
        JobHandle Handle = testJob.Schedule();

        // 안전하게 비동기로 작업을 진행할 수 있다.
        while(!Handle.IsCompleted)
        {
            yield return null;
        }

        Handle.Complete();

        Debug.LogFormat("현재 프래임 : {0}", Time.frameCount);
    }

    struct TestJob : IJob
    {
        public void Execute()
        {
            // 실제 작업은 여기서 처리
            Debug.LogFormat("현재 쓰레드 : {0}", Thread.CurrentThread.ManagedThreadId);
            print("작업 했음");
        }
    }
}
