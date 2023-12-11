// Unity built-in shader source. Copyright (c) 2016 Unity Technologies. MIT license (see license.txt)

Shader "Legacy Shaders/Diffuse_Culloff" {
Properties {
    _Color ("Main Color", Color) = (1,1,1,1)
    _MainTex ("Front (RGB)", 2D) = "white" {}
    _BackMainTex("Back (RGB)", 2D) = "white" {}
}
SubShader {
    Tags { "RenderType"="Opaque" }
    LOD 200

    Cull Front

CGPROGRAM
#pragma surface surf Lambert

sampler2D _BackMainTex;
fixed4 _Color;

struct Input {
    float2 uv_BackMainTex;
};

void surf (Input IN, inout SurfaceOutput o) {
    fixed4 c = tex2D(_BackMainTex, IN.uv_BackMainTex) * _Color;
    o.Albedo = c.rgb;
    o.Alpha = c.a;
}
ENDCG

    Cull Back

CGPROGRAM
#pragma surface surf Lambert

sampler2D _MainTex;
fixed4 _Color;

struct Input {
    float2 uv_MainTex;
};

void surf(Input IN, inout SurfaceOutput o) {
    fixed4 c = tex2D(_MainTex, IN.uv_MainTex) * _Color;
    o.Albedo = c.rgb;
    o.Alpha = c.a;
}
ENDCG
}

Fallback "Legacy Shaders/VertexLit"
}
