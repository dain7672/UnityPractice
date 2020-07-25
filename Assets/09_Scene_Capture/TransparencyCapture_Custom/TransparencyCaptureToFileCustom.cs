using System.Collections;
using UnityEngine;

public class TransparencyCaptureToFileCustom:MonoBehaviour
{
    private int currentFrame = 0;
    public IEnumerator capture(int currentFrame)
    {

        yield return new WaitForEndOfFrame();
        //After Unity4,you have to do this function after WaitForEndOfFrame in Coroutine
        //Or you will get the error:"ReadPixels was called to read pixels from system frame buffer, while not inside drawing frame"
        zzTransparencyCaptureCustom.captureScreenshot("capture/capture" + currentFrame + ".png");
        //파일 저장경로가 이상하다면 아래 사용
        //zzTransparencyCapture.captureScreenshot(System.IO.Path.Combine(Application.dataPath, "Assets", "capture.png"));
    }

    void Start () {
        StartCoroutine(CaptureEveryFrames());
    }
 
    IEnumerator CaptureEveryFrames () {
        while(true){ // This creates a never-ending loop
            yield return new WaitForEndOfFrame();
            zzTransparencyCaptureCustom.captureScreenshot("capture/capture" + currentFrame + ".png");
            Debug.Log("frame: " + currentFrame);
            currentFrame++;
            yield return null;
        }
    }
    void Update()
    {
        // if (Input.GetKeyDown(KeyCode.C))
        // StartCoroutine(capture(currentFrame));
        // capture(currentFrame);
        // yield return null;
        // currentFrame++;
    }
}