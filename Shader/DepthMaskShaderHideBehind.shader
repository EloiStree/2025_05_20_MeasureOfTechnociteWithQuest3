Shader "Hidden/DepthMaskHideBehind"
{
    SubShader
    {
        Tags { "Queue" = "Geometry-1" }
        ColorMask 0 // Hides the object from rendering
        ZWrite On   // Writes depth to occlude objects behind
        Pass {}
    }
}
