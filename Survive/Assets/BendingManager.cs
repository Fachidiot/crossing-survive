using UnityEngine;
using UnityEngine.Rendering;

[ExecuteAlways] // 에디트 모드 나 플레이 모드일때 항상 실행
public class BendingManager : MonoBehaviour
{
    static float cullingDepth = 180;

    #region Constants
    const string BENDING_FEATURE = "ENABLE_BENDING";
    #endregion

    #region  MonoBehaviour
    void Awake()
    {
        if (Application.isPlaying)
            Shader.EnableKeyword(BENDING_FEATURE);
        else
            Shader.DisableKeyword(BENDING_FEATURE);
    }

    void OnEnable()
    {
        RenderPipelineManager.beginCameraRendering += OnBeginCameraRendering;
        RenderPipelineManager.endCameraRendering += OnEndCameraRendering;
    }

    void OnDisable()
    {
        RenderPipelineManager.beginCameraRendering -= OnBeginCameraRendering;
        RenderPipelineManager.endCameraRendering -= OnEndCameraRendering;
    }

    #endregion

    #region Methods

    static void OnBeginCameraRendering(ScriptableRenderContext context, Camera camera)
    {
        camera.cullingMatrix = Matrix4x4.Ortho(-cullingDepth, cullingDepth, -cullingDepth, cullingDepth, 0.002f, cullingDepth) * camera.worldToCameraMatrix;
    }

    static void OnEndCameraRendering(ScriptableRenderContext context, Camera camera)
    {
        camera.ResetCullingMatrix();
    }

    #endregion
}
