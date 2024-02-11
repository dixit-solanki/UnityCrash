Shader "Custom/GreenScreenShader"
{
    Properties
    {
        _MainTex ("Texture", 2D) = "white" {}
        _KeyColor ("Key Color", Color) = (0,1,0,1)
        _Threshold ("Threshold", Float) = 0.1
    }
    SubShader
    {
        Tags { "Queue"="Transparent" }

        Pass
        {
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag

            #include "UnityCG.cginc"

            struct appdata
            {
                float4 vertex : POSITION;
                float2 uv : TEXCOORD0;
            };

            struct v2f
            {
                float2 uv : TEXCOORD0;
                float4 vertex : SV_POSITION;
            };

            sampler2D _MainTex;
            float4 _KeyColor;
            float _Threshold;

            v2f vert (appdata v)
            {
                v2f o;
                o.vertex = UnityObjectToClipPos(v.vertex);
                o.uv = v.uv;
                return o;
            }

            fixed4 frag (v2f i) : SV_Target
            {
                fixed4 texColor = tex2D(_MainTex, i.uv);
                fixed4 keyColor = _KeyColor;

                float threshold = _Threshold;

                if(texColor.g > keyColor.g - threshold && texColor.g < keyColor.g + threshold &&
                    texColor.r > keyColor.r - threshold && texColor.r < keyColor.r + threshold &&
                    texColor.b > keyColor.b - threshold && texColor.b < keyColor.b + threshold) 
                {
                    discard;
                }

                return texColor;
            }
            ENDCG
        }
    }
}
