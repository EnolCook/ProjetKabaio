// Shader created with Shader Forge v1.26 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.26;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,lico:1,lgpr:1,limd:0,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:3,bdst:7,dpts:2,wrdp:True,dith:0,rfrpo:True,rfrpn:Refraction,coma:15,ufog:True,aust:False,igpj:True,qofs:0,qpre:3,rntp:2,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False;n:type:ShaderForge.SFN_Final,id:9361,x:33209,y:32712,varname:node_9361,prsc:2|normal-9165-RGB,emission-2460-OUT,custl-5085-OUT,alpha-7016-OUT;n:type:ShaderForge.SFN_LightAttenuation,id:8068,x:32734,y:33086,varname:node_8068,prsc:2;n:type:ShaderForge.SFN_LightColor,id:3406,x:32734,y:32952,varname:node_3406,prsc:2;n:type:ShaderForge.SFN_LightVector,id:6869,x:31141,y:32554,varname:node_6869,prsc:2;n:type:ShaderForge.SFN_NormalVector,id:9684,x:31141,y:32682,prsc:2,pt:True;n:type:ShaderForge.SFN_HalfVector,id:9471,x:31141,y:32833,varname:node_9471,prsc:2;n:type:ShaderForge.SFN_Dot,id:7782,x:31353,y:32605,cmnt:Lambert,varname:node_7782,prsc:2,dt:0|A-6869-OUT,B-9684-OUT;n:type:ShaderForge.SFN_Dot,id:3269,x:31353,y:32771,cmnt:Blinn-Phong,varname:node_3269,prsc:2,dt:1|A-9684-OUT,B-9471-OUT;n:type:ShaderForge.SFN_Multiply,id:2746,x:32465,y:32866,cmnt:Specular Contribution,varname:node_2746,prsc:2|A-4469-OUT,B-5267-OUT,C-4865-RGB;n:type:ShaderForge.SFN_Tex2d,id:851,x:32070,y:32349,ptovrint:False,ptlb:Diffuse,ptin:_Diffuse,varname:node_851,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:0859e48169a58304cbc7b7500a6f4b93,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Multiply,id:1941,x:32465,y:32693,cmnt:Diffuse Contribution,varname:node_1941,prsc:2|A-544-OUT,B-4469-OUT;n:type:ShaderForge.SFN_Color,id:5927,x:32070,y:32534,ptovrint:False,ptlb:Color,ptin:_Color,varname:node_5927,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.4477725,c2:0.4986129,c3:0.7426471,c4:1;n:type:ShaderForge.SFN_Exp,id:1700,x:32001,y:33654,varname:node_1700,prsc:2,et:1|IN-9978-OUT;n:type:ShaderForge.SFN_Slider,id:5328,x:31460,y:33656,ptovrint:False,ptlb:Gloss,ptin:_Gloss,varname:node_5328,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.4348061,max:1;n:type:ShaderForge.SFN_Power,id:5267,x:32199,y:33540,varname:node_5267,prsc:2|VAL-3269-OUT,EXP-1700-OUT;n:type:ShaderForge.SFN_Add,id:2159,x:32734,y:32812,cmnt:Combine,varname:node_2159,prsc:2|A-1941-OUT,B-2746-OUT;n:type:ShaderForge.SFN_Multiply,id:5085,x:32979,y:32952,cmnt:Attenuate and Color,varname:node_5085,prsc:2|A-2159-OUT,B-3406-RGB,C-8068-OUT;n:type:ShaderForge.SFN_ConstantLerp,id:9978,x:31789,y:33656,varname:node_9978,prsc:2,a:1,b:11|IN-5328-OUT;n:type:ShaderForge.SFN_Color,id:4865,x:32199,y:33695,ptovrint:False,ptlb:Spec Color,ptin:_SpecColor,varname:node_4865,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:1,c2:1,c3:1,c4:1;n:type:ShaderForge.SFN_AmbientLight,id:7528,x:32687,y:32633,varname:node_7528,prsc:2;n:type:ShaderForge.SFN_Multiply,id:2460,x:32930,y:32596,cmnt:Ambient Light,varname:node_2460,prsc:2|A-544-OUT,B-7528-RGB;n:type:ShaderForge.SFN_Multiply,id:544,x:32268,y:32448,cmnt:Diffuse Color,varname:node_544,prsc:2|A-851-RGB,B-5927-RGB;n:type:ShaderForge.SFN_Append,id:3217,x:31786,y:32739,varname:node_3217,prsc:2|A-4385-OUT,B-7835-OUT;n:type:ShaderForge.SFN_Vector1,id:7835,x:31681,y:32873,varname:node_7835,prsc:2,v1:0.5;n:type:ShaderForge.SFN_RemapRange,id:4385,x:31578,y:32656,varname:node_4385,prsc:2,frmn:-1,frmx:1,tomn:0,tomx:1|IN-7782-OUT;n:type:ShaderForge.SFN_Tex2d,id:9165,x:32959,y:32382,ptovrint:False,ptlb:normal,ptin:_normal,varname:node_9165,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:e4fe5f44f589bff43b12a97fcfa06256,ntxv:3,isnm:True;n:type:ShaderForge.SFN_Tex2d,id:9390,x:31531,y:33224,ptovrint:False,ptlb:Thickness,ptin:_Thickness,varname:node_9390,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:0859e48169a58304cbc7b7500a6f4b93,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Blend,id:434,x:32186,y:32961,varname:node_434,prsc:2,blmd:1,clmp:True|SRC-9504-RGB,DST-9470-OUT;n:type:ShaderForge.SFN_Tex2d,id:9504,x:31971,y:32907,ptovrint:False,ptlb:SSSramp,ptin:_SSSramp,varname:node_9504,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:41fa4ec2ea96bb647b4c77d761997aab,ntxv:0,isnm:False|UVIN-3217-OUT;n:type:ShaderForge.SFN_Add,id:4469,x:32290,y:32793,varname:node_4469,prsc:2|A-4385-OUT,B-434-OUT;n:type:ShaderForge.SFN_Multiply,id:9470,x:31927,y:33234,varname:node_9470,prsc:2|A-1399-OUT,B-2381-OUT;n:type:ShaderForge.SFN_Slider,id:2381,x:31499,y:33467,ptovrint:False,ptlb:Thickness_influence,ptin:_Thickness_influence,varname:node_2381,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.9600611,max:2;n:type:ShaderForge.SFN_OneMinus,id:1399,x:31706,y:33178,varname:node_1399,prsc:2|IN-9390-RGB;n:type:ShaderForge.SFN_Slider,id:9307,x:32442,y:33437,ptovrint:False,ptlb:Opacity,ptin:_Opacity,varname:node_9307,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:-1,cur:-0.08022628,max:1;n:type:ShaderForge.SFN_Add,id:9818,x:32819,y:33310,varname:node_9818,prsc:2|A-9390-R,B-9307-OUT;n:type:ShaderForge.SFN_Clamp01,id:7016,x:32990,y:33269,varname:node_7016,prsc:2|IN-9818-OUT;proporder:851-5927-5328-4865-9165-9390-9504-2381-9307;pass:END;sub:END;*/

Shader "Shader Forge/S_SSSTEST" {
    Properties {
        _Diffuse ("Diffuse", 2D) = "white" {}
        _Color ("Color", Color) = (0.4477725,0.4986129,0.7426471,1)
        _Gloss ("Gloss", Range(0, 1)) = 0.4348061
        _SpecColor ("Spec Color", Color) = (1,1,1,1)
        _normal ("normal", 2D) = "bump" {}
        _Thickness ("Thickness", 2D) = "white" {}
        _SSSramp ("SSSramp", 2D) = "white" {}
        _Thickness_influence ("Thickness_influence", Range(0, 2)) = 0.9600611
        _Opacity ("Opacity", Range(-1, 1)) = -0.08022628
        [HideInInspector]_Cutoff ("Alpha cutoff", Range(0,1)) = 0.5
    }
    SubShader {
        Tags {
            "IgnoreProjector"="True"
            "Queue"="Transparent"
            "RenderType"="Transparent"
        }
        Pass {
            Name "FORWARD"
            Tags {
                "LightMode"="ForwardBase"
            }
            Blend SrcAlpha OneMinusSrcAlpha
            
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDBASE
            #include "UnityCG.cginc"
            #include "Lighting.cginc"
            #pragma multi_compile_fwdbase
            #pragma multi_compile_fog
            #pragma exclude_renderers gles3 metal d3d11_9x xbox360 xboxone ps3 ps4 psp2 
            #pragma target 3.0
            uniform sampler2D _Diffuse; uniform float4 _Diffuse_ST;
            uniform float4 _Color;
            uniform float _Gloss;
            uniform sampler2D _normal; uniform float4 _normal_ST;
            uniform sampler2D _Thickness; uniform float4 _Thickness_ST;
            uniform sampler2D _SSSramp; uniform float4 _SSSramp_ST;
            uniform float _Thickness_influence;
            uniform float _Opacity;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float4 tangent : TANGENT;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float4 posWorld : TEXCOORD1;
                float3 normalDir : TEXCOORD2;
                float3 tangentDir : TEXCOORD3;
                float3 bitangentDir : TEXCOORD4;
                UNITY_FOG_COORDS(5)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.tangentDir = normalize( mul( _Object2World, float4( v.tangent.xyz, 0.0 ) ).xyz );
                o.bitangentDir = normalize(cross(o.normalDir, o.tangentDir) * v.tangent.w);
                o.posWorld = mul(_Object2World, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3x3 tangentTransform = float3x3( i.tangentDir, i.bitangentDir, i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 _normal_var = UnpackNormal(tex2D(_normal,TRANSFORM_TEX(i.uv0, _normal)));
                float3 normalLocal = _normal_var.rgb;
                float3 normalDirection = normalize(mul( normalLocal, tangentTransform )); // Perturbed normals
                float3 lightDirection = normalize(_WorldSpaceLightPos0.xyz);
                float3 lightColor = _LightColor0.rgb;
                float3 halfDirection = normalize(viewDirection+lightDirection);
////// Lighting:
                float attenuation = 1;
////// Emissive:
                float4 _Diffuse_var = tex2D(_Diffuse,TRANSFORM_TEX(i.uv0, _Diffuse));
                float3 node_544 = (_Diffuse_var.rgb*_Color.rgb); // Diffuse Color
                float3 emissive = (node_544*UNITY_LIGHTMODEL_AMBIENT.rgb);
                float node_4385 = (dot(lightDirection,normalDirection)*0.5+0.5);
                float2 node_3217 = float2(node_4385,0.5);
                float4 _SSSramp_var = tex2D(_SSSramp,TRANSFORM_TEX(node_3217, _SSSramp));
                float4 _Thickness_var = tex2D(_Thickness,TRANSFORM_TEX(i.uv0, _Thickness));
                float3 node_4469 = (node_4385+saturate((_SSSramp_var.rgb*((1.0 - _Thickness_var.rgb)*_Thickness_influence))));
                float3 finalColor = emissive + (((node_544*node_4469)+(node_4469*pow(max(0,dot(normalDirection,halfDirection)),exp2(lerp(1,11,_Gloss)))*_SpecColor.rgb))*_LightColor0.rgb*attenuation);
                fixed4 finalRGBA = fixed4(finalColor,saturate((_Thickness_var.r+_Opacity)));
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }
        Pass {
            Name "FORWARD_DELTA"
            Tags {
                "LightMode"="ForwardAdd"
            }
            Blend One One
            
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDADD
            #include "UnityCG.cginc"
            #include "AutoLight.cginc"
            #include "Lighting.cginc"
            #pragma multi_compile_fwdadd
            #pragma multi_compile_fog
            #pragma exclude_renderers gles3 metal d3d11_9x xbox360 xboxone ps3 ps4 psp2 
            #pragma target 3.0
            uniform sampler2D _Diffuse; uniform float4 _Diffuse_ST;
            uniform float4 _Color;
            uniform float _Gloss;
            uniform sampler2D _normal; uniform float4 _normal_ST;
            uniform sampler2D _Thickness; uniform float4 _Thickness_ST;
            uniform sampler2D _SSSramp; uniform float4 _SSSramp_ST;
            uniform float _Thickness_influence;
            uniform float _Opacity;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float4 tangent : TANGENT;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float4 posWorld : TEXCOORD1;
                float3 normalDir : TEXCOORD2;
                float3 tangentDir : TEXCOORD3;
                float3 bitangentDir : TEXCOORD4;
                LIGHTING_COORDS(5,6)
                UNITY_FOG_COORDS(7)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.tangentDir = normalize( mul( _Object2World, float4( v.tangent.xyz, 0.0 ) ).xyz );
                o.bitangentDir = normalize(cross(o.normalDir, o.tangentDir) * v.tangent.w);
                o.posWorld = mul(_Object2World, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3x3 tangentTransform = float3x3( i.tangentDir, i.bitangentDir, i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 _normal_var = UnpackNormal(tex2D(_normal,TRANSFORM_TEX(i.uv0, _normal)));
                float3 normalLocal = _normal_var.rgb;
                float3 normalDirection = normalize(mul( normalLocal, tangentTransform )); // Perturbed normals
                float3 lightDirection = normalize(lerp(_WorldSpaceLightPos0.xyz, _WorldSpaceLightPos0.xyz - i.posWorld.xyz,_WorldSpaceLightPos0.w));
                float3 lightColor = _LightColor0.rgb;
                float3 halfDirection = normalize(viewDirection+lightDirection);
////// Lighting:
                float attenuation = LIGHT_ATTENUATION(i);
                float4 _Diffuse_var = tex2D(_Diffuse,TRANSFORM_TEX(i.uv0, _Diffuse));
                float3 node_544 = (_Diffuse_var.rgb*_Color.rgb); // Diffuse Color
                float node_4385 = (dot(lightDirection,normalDirection)*0.5+0.5);
                float2 node_3217 = float2(node_4385,0.5);
                float4 _SSSramp_var = tex2D(_SSSramp,TRANSFORM_TEX(node_3217, _SSSramp));
                float4 _Thickness_var = tex2D(_Thickness,TRANSFORM_TEX(i.uv0, _Thickness));
                float3 node_4469 = (node_4385+saturate((_SSSramp_var.rgb*((1.0 - _Thickness_var.rgb)*_Thickness_influence))));
                float3 finalColor = (((node_544*node_4469)+(node_4469*pow(max(0,dot(normalDirection,halfDirection)),exp2(lerp(1,11,_Gloss)))*_SpecColor.rgb))*_LightColor0.rgb*attenuation);
                fixed4 finalRGBA = fixed4(finalColor * saturate((_Thickness_var.r+_Opacity)),0);
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
