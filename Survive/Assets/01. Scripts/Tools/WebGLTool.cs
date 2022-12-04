using System.Runtime.InteropServices;

public class WebGLTool
{

#if !UNITY_EDITOR && UNITY_WEBGL
        [DllImport("__Internal")]
        private static extern bool IsMobile();
#endif

    public static bool isMobile()
    {
#if !UNITY_EDITOR && UNITY_WEBGL
            return IsMobile();
#else
        return false;
#endif
    }

}