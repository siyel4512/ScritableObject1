using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using System.Threading.Tasks;

public class AsyncTest : MonoBehaviour
{
    //// Start is called before the first frame update
    //async void Start()
    //{
    //    Debug.LogFormat("현재 쓰레드 : {0}", Thread.CurrentThread.ManagedThreadId);
    //    Debug.LogFormat("현재 프래임 : {0}", Time.frameCount);
    //    await TestAsync(); //  메인 쓰래드가 아닌 다른 쓰레드가 작업을 진행하고 있음
    //    Debug.LogFormat("현재 프래임 : {0}", Time.frameCount);
    //}

    //private async Task TestAsync()
    //{
    //    // await는 해당 작업이 끝날때까지 해당 함수가 기다름
    //    await Task.Run(()=> 
    //    {
    //        Debug.Log("작업 했음");
    //        Debug.LogFormat("현재 쓰레드 : {0}", Thread.CurrentThread.ManagedThreadId);
    //    });
    //}

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // 이벤트 핸들러로 사용한다면 나쁘지 않은 형태 (반환형을 Task에서 void로 변경...)
    private async void TestAsync()
    {
        // await는 해당 작업이 끝날때까지 해당 함수가 기다름
        await Task.Run(() =>
        {
            Debug.Log("작업 했음");
            Debug.LogFormat("현재 쓰레드 : {0}", Thread.CurrentThread.ManagedThreadId);
        });
    }
}
