// Shader created with Shader Forge v1.25 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.25;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,lico:0,lgpr:1,limd:3,spmd:1,trmd:0,grmd:1,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:3,bdst:7,dpts:2,wrdp:False,dith:0,rfrpo:True,rfrpn:Refraction,coma:15,ufog:True,aust:True,igpj:True,qofs:0,qpre:3,rntp:2,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False;n:type:ShaderForge.SFN_Final,id:4013,x:34986,y:32757,varname:node_4013,prsc:2|diff-3660-OUT,spec-1691-OUT,gloss-852-OUT,normal-9189-OUT,alpha-4430-OUT,refract-7911-OUT,voffset-3612-OUT,tess-6213-OUT;n:type:ShaderForge.SFN_Lerp,id:2075,x:32118,y:33210,varname:node_2075,prsc:2|A-596-OUT,B-8395-G,T-2764-OUT;n:type:ShaderForge.SFN_Lerp,id:3257,x:32336,y:33250,varname:node_3257,prsc:2|A-2075-OUT,B-8395-B,T-3251-OUT;n:type:ShaderForge.SFN_Vector1,id:2517,x:31799,y:33567,varname:node_2517,prsc:2,v1:-0.5;n:type:ShaderForge.SFN_Add,id:6951,x:32036,y:33468,varname:node_6951,prsc:2|A-8465-OUT,B-2517-OUT;n:type:ShaderForge.SFN_ConstantClamp,id:3251,x:32213,y:33429,varname:node_3251,prsc:2,min:0,max:1|IN-6951-OUT;n:type:ShaderForge.SFN_ConstantClamp,id:2764,x:31875,y:33316,varname:node_2764,prsc:2,min:0,max:1|IN-8465-OUT;n:type:ShaderForge.SFN_Lerp,id:4803,x:32741,y:33390,varname:node_4803,prsc:2|A-8140-OUT,B-596-OUT,T-542-OUT;n:type:ShaderForge.SFN_Vector1,id:2524,x:31799,y:33763,varname:node_2524,prsc:2,v1:-1;n:type:ShaderForge.SFN_Add,id:905,x:32052,y:33674,varname:node_905,prsc:2|A-8465-OUT,B-2524-OUT;n:type:ShaderForge.SFN_ConstantClamp,id:6649,x:32229,y:33635,varname:node_6649,prsc:2,min:0,max:1|IN-905-OUT;n:type:ShaderForge.SFN_Lerp,id:596,x:32096,y:33028,varname:node_596,prsc:2|A-8395-R,B-8395-B,T-935-OUT;n:type:ShaderForge.SFN_Time,id:5539,x:30808,y:33527,varname:node_5539,prsc:2;n:type:ShaderForge.SFN_Frac,id:5032,x:31239,y:33535,varname:node_5032,prsc:2|IN-4044-OUT;n:type:ShaderForge.SFN_Multiply,id:8465,x:31491,y:33579,varname:node_8465,prsc:2|A-5032-OUT,B-694-OUT;n:type:ShaderForge.SFN_Vector1,id:694,x:31257,y:33755,varname:node_694,prsc:2,v1:2.5;n:type:ShaderForge.SFN_Lerp,id:8140,x:32535,y:33338,varname:node_8140,prsc:2|A-3257-OUT,B-8395-A,T-6649-OUT;n:type:ShaderForge.SFN_Vector1,id:1699,x:31839,y:33985,varname:node_1699,prsc:2,v1:-1.5;n:type:ShaderForge.SFN_Add,id:5430,x:32092,y:33896,varname:node_5430,prsc:2|A-8465-OUT,B-1699-OUT;n:type:ShaderForge.SFN_ConstantClamp,id:542,x:32269,y:33857,varname:node_542,prsc:2,min:0,max:1|IN-5430-OUT;n:type:ShaderForge.SFN_Multiply,id:4044,x:31041,y:33535,varname:node_4044,prsc:2|A-5539-T,B-5598-OUT;n:type:ShaderForge.SFN_Vector1,id:5598,x:30808,y:33720,varname:node_5598,prsc:2,v1:0.4;n:type:ShaderForge.SFN_Tex2dAsset,id:3972,x:29403,y:32385,ptovrint:False,ptlb:Waves_pattern,ptin:_Waves_pattern,varname:_Noise,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:dd5e91ced001f3743be2e20c295246ab,ntxv:3,isnm:False;n:type:ShaderForge.SFN_Tex2d,id:7484,x:31306,y:30386,varname:node_9938,prsc:2,tex:dd5e91ced001f3743be2e20c295246ab,ntxv:0,isnm:False|UVIN-2729-OUT,TEX-3972-TEX;n:type:ShaderForge.SFN_Lerp,id:2795,x:31707,y:30445,varname:node_2795,prsc:2|A-1505-OUT,B-7484-G,T-3045-OUT;n:type:ShaderForge.SFN_Lerp,id:8778,x:31925,y:30485,varname:node_8778,prsc:2|A-2795-OUT,B-7484-B,T-287-OUT;n:type:ShaderForge.SFN_Vector1,id:4903,x:31388,y:30802,varname:node_4903,prsc:2,v1:-0.5;n:type:ShaderForge.SFN_Add,id:2271,x:31625,y:30703,varname:node_2271,prsc:2|A-3672-OUT,B-4903-OUT;n:type:ShaderForge.SFN_ConstantClamp,id:287,x:31802,y:30664,varname:node_287,prsc:2,min:0,max:1|IN-2271-OUT;n:type:ShaderForge.SFN_ConstantClamp,id:3045,x:31464,y:30551,varname:node_3045,prsc:2,min:0,max:1|IN-3672-OUT;n:type:ShaderForge.SFN_Lerp,id:5139,x:32338,y:30625,varname:node_5139,prsc:2|A-3067-OUT,B-1505-OUT,T-252-OUT;n:type:ShaderForge.SFN_Vector1,id:3475,x:31388,y:30998,varname:node_3475,prsc:2,v1:-1;n:type:ShaderForge.SFN_Add,id:9238,x:31641,y:30909,varname:node_9238,prsc:2|A-3672-OUT,B-3475-OUT;n:type:ShaderForge.SFN_ConstantClamp,id:5181,x:31818,y:30870,varname:node_5181,prsc:2,min:0,max:1|IN-9238-OUT;n:type:ShaderForge.SFN_Lerp,id:1505,x:31685,y:30263,varname:node_1505,prsc:2|A-7484-R,B-7484-B,T-6099-OUT;n:type:ShaderForge.SFN_Time,id:973,x:30397,y:30762,varname:node_973,prsc:2;n:type:ShaderForge.SFN_Frac,id:2410,x:30828,y:30770,varname:node_2410,prsc:2|IN-1635-OUT;n:type:ShaderForge.SFN_Multiply,id:3672,x:31080,y:30814,varname:node_3672,prsc:2|A-2410-OUT,B-887-OUT;n:type:ShaderForge.SFN_Vector1,id:887,x:30846,y:30990,varname:node_887,prsc:2,v1:2.5;n:type:ShaderForge.SFN_Lerp,id:3067,x:32124,y:30573,varname:node_3067,prsc:2|A-8778-OUT,B-7484-A,T-5181-OUT;n:type:ShaderForge.SFN_Vector1,id:5717,x:31428,y:31220,varname:node_5717,prsc:2,v1:-1.5;n:type:ShaderForge.SFN_Add,id:4723,x:31681,y:31131,varname:node_4723,prsc:2|A-3672-OUT,B-5717-OUT;n:type:ShaderForge.SFN_ConstantClamp,id:252,x:31858,y:31092,varname:node_252,prsc:2,min:0,max:1|IN-4723-OUT;n:type:ShaderForge.SFN_Multiply,id:1635,x:30630,y:30770,varname:node_1635,prsc:2|A-973-T,B-4085-OUT;n:type:ShaderForge.SFN_Vector1,id:4085,x:30427,y:30942,varname:node_4085,prsc:2,v1:0.5;n:type:ShaderForge.SFN_Vector1,id:6099,x:31445,y:30309,varname:node_6099,prsc:2,v1:0.5;n:type:ShaderForge.SFN_Vector1,id:935,x:31895,y:33043,varname:node_935,prsc:2,v1:0.5;n:type:ShaderForge.SFN_Tex2d,id:8395,x:31863,y:33130,varname:_node_8395,prsc:2,tex:dd5e91ced001f3743be2e20c295246ab,ntxv:0,isnm:False|UVIN-1452-OUT,TEX-3972-TEX;n:type:ShaderForge.SFN_Add,id:2182,x:32844,y:32419,varname:node_2182,prsc:2|A-5139-OUT,B-4803-OUT;n:type:ShaderForge.SFN_Slider,id:6213,x:34073,y:33470,ptovrint:False,ptlb:Tessaltion,ptin:_Tessaltion,varname:node_6213,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:1,cur:19.14231,max:100;n:type:ShaderForge.SFN_Multiply,id:7911,x:33974,y:32838,varname:node_7911,prsc:2|A-7427-OUT,B-4062-OUT,C-9250-OUT;n:type:ShaderForge.SFN_Slider,id:4062,x:33528,y:32823,ptovrint:False,ptlb:Refraction,ptin:_Refraction,varname:node_4062,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.03418804,max:0.25;n:type:ShaderForge.SFN_Slider,id:3614,x:35851,y:32645,ptovrint:False,ptlb:Opacity,ptin:_Opacity,varname:node_3614,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.5245801,max:200;n:type:ShaderForge.SFN_Multiply,id:2472,x:33972,y:33250,varname:node_2472,prsc:2|A-5927-OUT,B-8593-OUT,C-601-OUT;n:type:ShaderForge.SFN_Slider,id:8593,x:33520,y:33290,ptovrint:False,ptlb:Height,ptin:_Height,varname:node_8593,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.02666162,max:0.1;n:type:ShaderForge.SFN_NormalVector,id:601,x:33557,y:33429,prsc:2,pt:False;n:type:ShaderForge.SFN_NormalVector,id:9250,x:33685,y:32891,prsc:2,pt:False;n:type:ShaderForge.SFN_RemapRange,id:5927,x:33614,y:33102,varname:node_5927,prsc:2,frmn:0,frmx:1,tomn:-1,tomx:1|IN-2182-OUT;n:type:ShaderForge.SFN_TexCoord,id:6664,x:30270,y:30063,varname:node_6664,prsc:2,uv:0;n:type:ShaderForge.SFN_Slider,id:5337,x:34257,y:32365,ptovrint:False,ptlb:Roughness,ptin:_Roughness,varname:node_5337,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.3846154,max:1;n:type:ShaderForge.SFN_Color,id:5371,x:34453,y:31882,ptovrint:False,ptlb:Water_color_Shore,ptin:_Water_color_Shore,varname:node_5371,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.2,c2:0.5,c3:0.8,c4:1;n:type:ShaderForge.SFN_DepthBlend,id:1429,x:36314,y:32557,varname:node_1429,prsc:2|DIST-3614-OUT;n:type:ShaderForge.SFN_Color,id:8233,x:34453,y:32042,ptovrint:False,ptlb:Water_color_Sea,ptin:_Water_color_Sea,varname:node_8233,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0,c2:0.9172413,c3:1,c4:1;n:type:ShaderForge.SFN_Lerp,id:3537,x:34845,y:31962,varname:node_3537,prsc:2|A-5371-RGB,B-8233-RGB,T-820-OUT;n:type:ShaderForge.SFN_DepthBlend,id:820,x:34767,y:32223,varname:node_820,prsc:2|DIST-8063-OUT;n:type:ShaderForge.SFN_Slider,id:8063,x:34387,y:32254,ptovrint:False,ptlb:Color_Blend,ptin:_Color_Blend,varname:node_8063,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:126.7863,max:200;n:type:ShaderForge.SFN_DepthBlend,id:9649,x:32676,y:30092,varname:node_9649,prsc:2|DIST-9682-OUT;n:type:ShaderForge.SFN_Slider,id:9682,x:32201,y:30119,ptovrint:False,ptlb:Shore_waves_size,ptin:_Shore_waves_size,varname:node_9682,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:200;n:type:ShaderForge.SFN_Tex2d,id:5089,x:33425,y:30241,varname:node_5089,prsc:2,tex:dd5e91ced001f3743be2e20c295246ab,ntxv:0,isnm:False|UVIN-7263-OUT,TEX-3972-TEX;n:type:ShaderForge.SFN_TexCoord,id:7899,x:32703,y:30306,varname:node_7899,prsc:2,uv:0;n:type:ShaderForge.SFN_Time,id:641,x:29780,y:30063,varname:node_641,prsc:2;n:type:ShaderForge.SFN_Add,id:384,x:30723,y:30037,varname:node_384,prsc:2|A-5954-OUT,B-8021-R;n:type:ShaderForge.SFN_Add,id:8775,x:30723,y:30171,varname:node_8775,prsc:2|A-8021-G,B-4411-OUT;n:type:ShaderForge.SFN_Slider,id:6336,x:30038,y:29718,ptovrint:False,ptlb:PannerMacro_Xspeed,ptin:_PannerMacro_Xspeed,varname:node_6336,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:-0.25,cur:0,max:0.25;n:type:ShaderForge.SFN_Slider,id:8689,x:30081,y:30364,ptovrint:False,ptlb:PannerMacro_Yspeed,ptin:_PannerMacro_Yspeed,varname:node_8689,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:-0.25,cur:0,max:0.25;n:type:ShaderForge.SFN_Multiply,id:5954,x:30507,y:29931,varname:node_5954,prsc:2|A-6336-OUT,B-641-T;n:type:ShaderForge.SFN_Multiply,id:4411,x:30534,y:30263,varname:node_4411,prsc:2|A-641-T,B-8689-OUT;n:type:ShaderForge.SFN_Append,id:2729,x:30939,y:30091,varname:node_2729,prsc:2|A-384-OUT,B-8775-OUT;n:type:ShaderForge.SFN_Time,id:7438,x:30184,y:32904,varname:node_7438,prsc:2;n:type:ShaderForge.SFN_TexCoord,id:6909,x:30632,y:32913,varname:node_6909,prsc:2,uv:0;n:type:ShaderForge.SFN_Multiply,id:3961,x:30911,y:32772,varname:node_3961,prsc:2|A-9566-OUT,B-7438-T;n:type:ShaderForge.SFN_Add,id:8649,x:31127,y:32878,varname:node_8649,prsc:2|A-3961-OUT,B-3275-R;n:type:ShaderForge.SFN_Add,id:6205,x:31127,y:33012,varname:node_6205,prsc:2|A-3884-OUT,B-3275-G;n:type:ShaderForge.SFN_Multiply,id:3884,x:30938,y:33104,varname:node_3884,prsc:2|A-7438-T,B-9957-OUT;n:type:ShaderForge.SFN_Append,id:1452,x:31343,y:32932,varname:node_1452,prsc:2|A-8649-OUT,B-6205-OUT;n:type:ShaderForge.SFN_Multiply,id:4916,x:30325,y:33360,varname:node_4916,prsc:2|A-6909-UVOUT,B-8444-OUT;n:type:ShaderForge.SFN_Slider,id:9566,x:30439,y:32749,ptovrint:False,ptlb:PannerMicro_xspeed,ptin:_PannerMicro_xspeed,varname:node_9566,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:-0.25,cur:0,max:0.25;n:type:ShaderForge.SFN_Slider,id:9957,x:30417,y:33196,ptovrint:False,ptlb:PannerMicro_yspeed,ptin:_PannerMicro_yspeed,varname:node_9957,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:-0.25,cur:0,max:0.25;n:type:ShaderForge.SFN_Slider,id:8444,x:29918,y:33402,ptovrint:False,ptlb:Micro_water_scale,ptin:_Micro_water_scale,varname:node_8444,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:1,cur:1,max:20;n:type:ShaderForge.SFN_ComponentMask,id:3275,x:30562,y:33330,varname:node_3275,prsc:2,cc1:0,cc2:1,cc3:-1,cc4:-1|IN-4916-OUT;n:type:ShaderForge.SFN_ComponentMask,id:8021,x:30399,y:30469,varname:node_8021,prsc:2,cc1:0,cc2:1,cc3:-1,cc4:-1|IN-7194-OUT;n:type:ShaderForge.SFN_Multiply,id:7194,x:30160,y:30469,varname:node_7194,prsc:2|A-6664-UVOUT,B-8858-OUT;n:type:ShaderForge.SFN_Slider,id:8858,x:29742,y:30585,ptovrint:False,ptlb:Macro_water_scale,ptin:_Macro_water_scale,varname:node_8858,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:5;n:type:ShaderForge.SFN_RemapRange,id:7427,x:33839,y:32636,varname:node_7427,prsc:2,frmn:0,frmx:1,tomn:-1,tomx:1|IN-59-OUT;n:type:ShaderForge.SFN_Lerp,id:59,x:33691,y:30645,varname:node_59,prsc:2|A-5089-R,B-2182-OUT,T-9808-OUT;n:type:ShaderForge.SFN_Slider,id:9808,x:33282,y:30773,ptovrint:False,ptlb:Shore_waves_strength,ptin:_Shore_waves_strength,varname:node_9808,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:1,cur:1,max:0;n:type:ShaderForge.SFN_Time,id:5639,x:32290,y:29789,varname:node_5639,prsc:2;n:type:ShaderForge.SFN_Add,id:6275,x:33014,y:30054,varname:node_6275,prsc:2|A-71-OUT,B-9649-OUT;n:type:ShaderForge.SFN_Multiply,id:71,x:32640,y:29919,varname:node_71,prsc:2|A-5639-T,B-349-OUT;n:type:ShaderForge.SFN_Add,id:7263,x:33014,y:30253,varname:node_7263,prsc:2|A-6275-OUT,B-7899-UVOUT;n:type:ShaderForge.SFN_Slider,id:349,x:32187,y:29970,ptovrint:False,ptlb:Shore_waves_speed,ptin:_Shore_waves_speed,varname:node_349,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:-0.25,cur:0,max:0.25;n:type:ShaderForge.SFN_TexCoord,id:5953,x:32491,y:34038,varname:node_5953,prsc:2,uv:0;n:type:ShaderForge.SFN_ComponentMask,id:3059,x:32702,y:34028,varname:node_3059,prsc:2,cc1:0,cc2:-1,cc3:-1,cc4:-1|IN-5953-UVOUT;n:type:ShaderForge.SFN_Sin,id:9041,x:33633,y:34031,varname:node_9041,prsc:2|IN-213-OUT;n:type:ShaderForge.SFN_Multiply,id:213,x:33444,y:34031,varname:node_213,prsc:2|A-8439-OUT,B-9441-OUT,C-4582-OUT;n:type:ShaderForge.SFN_Vector1,id:8439,x:33191,y:33932,varname:node_8439,prsc:2,v1:10;n:type:ShaderForge.SFN_Tau,id:4582,x:33289,y:34198,varname:node_4582,prsc:2;n:type:ShaderForge.SFN_Time,id:980,x:32963,y:34251,varname:node_980,prsc:2;n:type:ShaderForge.SFN_Add,id:9441,x:33213,y:34031,varname:node_9441,prsc:2|A-7367-OUT,B-523-OUT;n:type:ShaderForge.SFN_RemapRange,id:11,x:33829,y:34031,varname:node_11,prsc:2,frmn:0,frmx:1,tomn:-1,tomx:1|IN-9041-OUT;n:type:ShaderForge.SFN_NormalVector,id:1075,x:33871,y:34275,prsc:2,pt:False;n:type:ShaderForge.SFN_Multiply,id:7652,x:34358,y:34239,varname:node_7652,prsc:2|A-11-OUT,B-1075-OUT,C-6013-OUT;n:type:ShaderForge.SFN_Slider,id:6013,x:33843,y:34481,ptovrint:False,ptlb:Sea_swell_height,ptin:_Sea_swell_height,varname:node_6013,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.025,max:0.5;n:type:ShaderForge.SFN_Add,id:3612,x:34354,y:33698,varname:node_3612,prsc:2|A-2472-OUT,B-7652-OUT;n:type:ShaderForge.SFN_RemapRangeAdvanced,id:7367,x:33011,y:34043,varname:node_7367,prsc:2|IN-3059-OUT,IMIN-4907-OUT,IMAX-1866-OUT,OMIN-4117-OUT,OMAX-9842-OUT;n:type:ShaderForge.SFN_Slider,id:4117,x:32518,y:34315,ptovrint:False,ptlb:Sea_swell_length,ptin:_Sea_swell_length,varname:node_4117,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:1,cur:1,max:0;n:type:ShaderForge.SFN_Multiply,id:523,x:33140,y:34158,varname:node_523,prsc:2|A-980-TSL,B-7941-OUT;n:type:ShaderForge.SFN_Slider,id:7941,x:32929,y:34414,ptovrint:False,ptlb:Sea_swell_speed,ptin:_Sea_swell_speed,varname:node_7941,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:1;n:type:ShaderForge.SFN_Vector1,id:4907,x:32675,y:34183,varname:node_4907,prsc:2,v1:0;n:type:ShaderForge.SFN_Vector1,id:1866,x:32675,y:34239,varname:node_1866,prsc:2,v1:1;n:type:ShaderForge.SFN_Vector1,id:9842,x:32675,y:34382,varname:node_9842,prsc:2,v1:0;n:type:ShaderForge.SFN_Slider,id:1691,x:34257,y:32457,ptovrint:False,ptlb:Metalness,ptin:_Metalness,varname:node_1691,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:1;n:type:ShaderForge.SFN_Lerp,id:3579,x:31707,y:31586,varname:node_3579,prsc:2|A-6736-OUT,B-6656-RGB,T-2322-OUT;n:type:ShaderForge.SFN_Lerp,id:8523,x:31925,y:31626,varname:node_8523,prsc:2|A-3579-OUT,B-8771-RGB,T-4415-OUT;n:type:ShaderForge.SFN_Vector1,id:517,x:31388,y:31943,varname:node_517,prsc:2,v1:-0.5;n:type:ShaderForge.SFN_Add,id:2345,x:31625,y:31844,varname:node_2345,prsc:2|A-6716-OUT,B-517-OUT;n:type:ShaderForge.SFN_ConstantClamp,id:4415,x:31802,y:31805,varname:node_4415,prsc:2,min:0,max:1|IN-2345-OUT;n:type:ShaderForge.SFN_ConstantClamp,id:2322,x:31464,y:31692,varname:node_2322,prsc:2,min:0,max:1|IN-6716-OUT;n:type:ShaderForge.SFN_Lerp,id:9570,x:32338,y:31766,varname:node_9570,prsc:2|A-7047-OUT,B-6736-OUT,T-6137-OUT;n:type:ShaderForge.SFN_Vector1,id:1556,x:31388,y:32139,varname:node_1556,prsc:2,v1:-1;n:type:ShaderForge.SFN_Add,id:6117,x:31641,y:32050,varname:node_6117,prsc:2|A-6716-OUT,B-1556-OUT;n:type:ShaderForge.SFN_ConstantClamp,id:5462,x:31818,y:32011,varname:node_5462,prsc:2,min:0,max:1|IN-6117-OUT;n:type:ShaderForge.SFN_Lerp,id:6736,x:31685,y:31404,varname:node_6736,prsc:2|A-215-RGB,B-8771-RGB,T-2807-OUT;n:type:ShaderForge.SFN_Lerp,id:7047,x:32124,y:31714,varname:node_7047,prsc:2|A-8523-OUT,B-7063-RGB,T-5462-OUT;n:type:ShaderForge.SFN_Vector1,id:2159,x:31428,y:32361,varname:node_2159,prsc:2,v1:-1.5;n:type:ShaderForge.SFN_Add,id:8208,x:31681,y:32272,varname:node_8208,prsc:2|A-6716-OUT,B-2159-OUT;n:type:ShaderForge.SFN_ConstantClamp,id:6137,x:31858,y:32233,varname:node_6137,prsc:2,min:0,max:1|IN-8208-OUT;n:type:ShaderForge.SFN_Vector1,id:2807,x:31445,y:31450,varname:node_2807,prsc:2,v1:0.5;n:type:ShaderForge.SFN_Time,id:5576,x:30397,y:31903,varname:node_5576,prsc:2;n:type:ShaderForge.SFN_Frac,id:6644,x:30828,y:31911,varname:node_6644,prsc:2|IN-1279-OUT;n:type:ShaderForge.SFN_Multiply,id:6716,x:31080,y:31955,varname:node_6716,prsc:2|A-6644-OUT,B-460-OUT;n:type:ShaderForge.SFN_Vector1,id:460,x:30846,y:32131,varname:node_460,prsc:2,v1:2.5;n:type:ShaderForge.SFN_Multiply,id:1279,x:30630,y:31911,varname:node_1279,prsc:2|A-5576-T,B-6093-OUT;n:type:ShaderForge.SFN_Vector1,id:6093,x:30427,y:32083,varname:node_6093,prsc:2,v1:0.5;n:type:ShaderForge.SFN_Add,id:1328,x:32852,y:32743,varname:node_1328,prsc:2|A-9570-OUT,B-5173-OUT;n:type:ShaderForge.SFN_Lerp,id:3776,x:30991,y:34413,varname:node_3776,prsc:2|A-8629-OUT,B-2102-RGB,T-7627-OUT;n:type:ShaderForge.SFN_Lerp,id:7398,x:31209,y:34453,varname:node_7398,prsc:2|A-3776-OUT,B-8042-RGB,T-6293-OUT;n:type:ShaderForge.SFN_Vector1,id:1746,x:30672,y:34770,varname:node_1746,prsc:2,v1:-0.5;n:type:ShaderForge.SFN_Add,id:6545,x:30909,y:34671,varname:node_6545,prsc:2|A-6699-OUT,B-1746-OUT;n:type:ShaderForge.SFN_ConstantClamp,id:6293,x:31086,y:34632,varname:node_6293,prsc:2,min:0,max:1|IN-6545-OUT;n:type:ShaderForge.SFN_ConstantClamp,id:7627,x:30748,y:34519,varname:node_7627,prsc:2,min:0,max:1|IN-6699-OUT;n:type:ShaderForge.SFN_Lerp,id:5173,x:31622,y:34593,varname:node_5173,prsc:2|A-465-OUT,B-8629-OUT,T-2758-OUT;n:type:ShaderForge.SFN_Vector1,id:2429,x:30672,y:34966,varname:node_2429,prsc:2,v1:-1;n:type:ShaderForge.SFN_Add,id:4644,x:30925,y:34877,varname:node_4644,prsc:2|A-6699-OUT,B-2429-OUT;n:type:ShaderForge.SFN_ConstantClamp,id:4625,x:31102,y:34838,varname:node_4625,prsc:2,min:0,max:1|IN-4644-OUT;n:type:ShaderForge.SFN_Lerp,id:465,x:31408,y:34541,varname:node_465,prsc:2|A-7398-OUT,B-5311-RGB,T-4625-OUT;n:type:ShaderForge.SFN_Add,id:6902,x:30965,y:35099,varname:node_6902,prsc:2|A-6699-OUT,B-8794-OUT;n:type:ShaderForge.SFN_ConstantClamp,id:2758,x:31142,y:35060,varname:node_2758,prsc:2,min:0,max:1|IN-6902-OUT;n:type:ShaderForge.SFN_Vector1,id:737,x:30729,y:34277,varname:node_737,prsc:2,v1:0.5;n:type:ShaderForge.SFN_Lerp,id:8629,x:30969,y:34231,varname:node_8629,prsc:2|A-5152-RGB,B-8042-RGB,T-737-OUT;n:type:ShaderForge.SFN_Vector1,id:8794,x:30712,y:35188,varname:node_8794,prsc:2,v1:-1.5;n:type:ShaderForge.SFN_Frac,id:4606,x:30112,y:34738,varname:node_4606,prsc:2|IN-728-OUT;n:type:ShaderForge.SFN_Multiply,id:6699,x:30364,y:34782,varname:node_6699,prsc:2|A-4606-OUT,B-6575-OUT;n:type:ShaderForge.SFN_Vector1,id:6575,x:30130,y:34958,varname:node_6575,prsc:2,v1:2.5;n:type:ShaderForge.SFN_Multiply,id:728,x:29914,y:34738,varname:node_728,prsc:2|A-9976-T,B-7168-OUT;n:type:ShaderForge.SFN_Time,id:9976,x:29681,y:34730,varname:node_9976,prsc:2;n:type:ShaderForge.SFN_Vector1,id:7168,x:29711,y:34910,varname:node_7168,prsc:2,v1:0.5;n:type:ShaderForge.SFN_Tex2dAsset,id:5896,x:29403,y:32991,ptovrint:False,ptlb:Waves_pattern_normal_B,ptin:_Waves_pattern_normal_B,varname:node_5896,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:16ef51d67db8e2546ad6b300f836bfec,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Tex2dAsset,id:697,x:29403,y:32800,ptovrint:False,ptlb:Waves_pattern_normal_G,ptin:_Waves_pattern_normal_G,varname:node_697,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:22927d575be0a004982326a43e3e639c,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Tex2dAsset,id:5463,x:29403,y:32598,ptovrint:False,ptlb:Waves_pattern_normal_R,ptin:_Waves_pattern_normal_R,varname:node_5463,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:c87e63f182c6d2f45900c14b8c740786,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Tex2dAsset,id:6416,x:29403,y:33189,ptovrint:False,ptlb:Waves_pattern_normal_A,ptin:_Waves_pattern_normal_A,varname:node_6416,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:e0a34826bb8ddc241822c9934a8c7172,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Tex2d,id:5152,x:30301,y:33859,varname:node_5152,prsc:2,tex:c87e63f182c6d2f45900c14b8c740786,ntxv:0,isnm:False|UVIN-1452-OUT,TEX-5463-TEX;n:type:ShaderForge.SFN_Tex2d,id:2102,x:30301,y:34034,varname:node_2102,prsc:2,tex:22927d575be0a004982326a43e3e639c,ntxv:0,isnm:False|UVIN-1452-OUT,TEX-697-TEX;n:type:ShaderForge.SFN_Tex2d,id:8042,x:30305,y:34216,varname:node_8042,prsc:2,tex:16ef51d67db8e2546ad6b300f836bfec,ntxv:0,isnm:False|UVIN-1452-OUT,TEX-5896-TEX;n:type:ShaderForge.SFN_Tex2d,id:5311,x:30305,y:34382,varname:node_5311,prsc:2,tex:e0a34826bb8ddc241822c9934a8c7172,ntxv:3,isnm:True|UVIN-1452-OUT,TEX-6416-TEX;n:type:ShaderForge.SFN_Tex2d,id:215,x:30956,y:31149,varname:node_215,prsc:2,tex:c87e63f182c6d2f45900c14b8c740786,ntxv:0,isnm:False|UVIN-2729-OUT,TEX-5463-TEX;n:type:ShaderForge.SFN_Tex2d,id:6656,x:30956,y:31321,varname:node_6656,prsc:2,tex:22927d575be0a004982326a43e3e639c,ntxv:0,isnm:False|UVIN-2729-OUT,TEX-697-TEX;n:type:ShaderForge.SFN_Tex2d,id:8771,x:30956,y:31495,varname:node_8771,prsc:2,tex:16ef51d67db8e2546ad6b300f836bfec,ntxv:0,isnm:False|UVIN-2729-OUT,TEX-5896-TEX;n:type:ShaderForge.SFN_Tex2d,id:7063,x:30956,y:31666,varname:node_7063,prsc:2,tex:e0a34826bb8ddc241822c9934a8c7172,ntxv:0,isnm:False|UVIN-2729-OUT,TEX-6416-TEX;n:type:ShaderForge.SFN_Blend,id:9189,x:32852,y:32575,varname:node_9189,prsc:2,blmd:10,clmp:True|SRC-9570-OUT,DST-5173-OUT;n:type:ShaderForge.SFN_Multiply,id:5479,x:32872,y:30925,varname:node_5479,prsc:2|A-5639-T,B-349-OUT;n:type:ShaderForge.SFN_DepthBlend,id:1583,x:32828,y:31139,varname:node_1583,prsc:2|DIST-9682-OUT;n:type:ShaderForge.SFN_Add,id:163,x:33267,y:31058,varname:node_163,prsc:2|A-5479-OUT,B-1583-OUT;n:type:ShaderForge.SFN_TexCoord,id:9614,x:32855,y:31353,varname:node_9614,prsc:2,uv:0;n:type:ShaderForge.SFN_Add,id:3986,x:33166,y:31300,varname:node_3986,prsc:2|A-163-OUT,B-9614-UVOUT;n:type:ShaderForge.SFN_Lerp,id:9118,x:33885,y:31676,varname:node_9118,prsc:2|A-3855-RGB,B-9189-OUT,T-9808-OUT;n:type:ShaderForge.SFN_Tex2d,id:3855,x:33524,y:31502,ptovrint:False,ptlb:useless,ptin:_useless,varname:node_3855,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:0,isnm:False|UVIN-3986-OUT;n:type:ShaderForge.SFN_DepthBlend,id:9233,x:32740,y:30156,varname:node_9233,prsc:2;n:type:ShaderForge.SFN_DepthBlend,id:6802,x:32804,y:30220,varname:node_6802,prsc:2;n:type:ShaderForge.SFN_DepthBlend,id:3136,x:32868,y:30284,varname:node_3136,prsc:2;n:type:ShaderForge.SFN_Tex2d,id:275,x:36267,y:32164,varname:node_275,prsc:2,tex:471bb7eba5056e844b702c9aff042236,ntxv:3,isnm:False|UVIN-5578-OUT,TEX-4642-TEX;n:type:ShaderForge.SFN_DepthBlend,id:9138,x:36110,y:31969,varname:node_9138,prsc:2|DIST-2315-OUT;n:type:ShaderForge.SFN_Slider,id:2315,x:35704,y:31995,ptovrint:False,ptlb:foam_area,ptin:_foam_area,varname:node_2315,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:50;n:type:ShaderForge.SFN_TexCoord,id:7487,x:35546,y:32157,varname:node_7487,prsc:2,uv:0;n:type:ShaderForge.SFN_Slider,id:4081,x:35546,y:32332,ptovrint:False,ptlb:foam1_size,ptin:_foam1_size,varname:node_4081,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:1,max:20;n:type:ShaderForge.SFN_Multiply,id:5578,x:35756,y:32157,varname:node_5578,prsc:2|A-7487-UVOUT,B-4081-OUT;n:type:ShaderForge.SFN_OneMinus,id:1686,x:36288,y:31932,varname:node_1686,prsc:2|IN-9138-OUT;n:type:ShaderForge.SFN_Multiply,id:5042,x:36600,y:32072,varname:node_5042,prsc:2|A-1686-OUT,B-982-OUT,C-2738-OUT;n:type:ShaderForge.SFN_Add,id:4430,x:36788,y:32219,varname:node_4430,prsc:2|A-5042-OUT,B-1429-OUT;n:type:ShaderForge.SFN_Blend,id:3660,x:35008,y:32346,varname:node_3660,prsc:2,blmd:6,clmp:True|SRC-3537-OUT,DST-5042-OUT;n:type:ShaderForge.SFN_Slider,id:2738,x:36136,y:32424,ptovrint:False,ptlb:Foam_opacity,ptin:_Foam_opacity,varname:node_2738,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.3114368,max:1;n:type:ShaderForge.SFN_Add,id:852,x:34700,y:32571,varname:node_852,prsc:2|A-5337-OUT,B-5042-OUT;n:type:ShaderForge.SFN_Tex2d,id:9997,x:36255,y:31654,varname:node_9997,prsc:2,tex:471bb7eba5056e844b702c9aff042236,ntxv:0,isnm:False|UVIN-545-OUT,TEX-4642-TEX;n:type:ShaderForge.SFN_Tex2dAsset,id:4642,x:35861,y:31725,ptovrint:False,ptlb:foam_pattern,ptin:_foam_pattern,varname:node_4642,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:471bb7eba5056e844b702c9aff042236,ntxv:0,isnm:False;n:type:ShaderForge.SFN_TexCoord,id:1886,x:35843,y:31514,varname:node_1886,prsc:2,uv:0;n:type:ShaderForge.SFN_Multiply,id:545,x:36092,y:31583,varname:node_545,prsc:2|A-1886-UVOUT,B-8114-OUT;n:type:ShaderForge.SFN_Slider,id:8114,x:35473,y:31609,ptovrint:False,ptlb:foam2_size,ptin:_foam2_size,varname:node_8114,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:1.478489,max:50;n:type:ShaderForge.SFN_Add,id:982,x:36475,y:31824,varname:node_982,prsc:2|A-9997-R,B-275-R;proporder:3972-5463-697-5896-6416-4642-5371-8233-8063-5337-1691-8593-6213-3614-4062-6336-8689-9566-9957-8444-8858-9682-9808-349-6013-4117-7941-4081-8114-2315-2738-3855;pass:END;sub:END;*/

Shader "Shader Forge/TESTShader" {
    Properties {
        _Waves_pattern ("Waves_pattern", 2D) = "bump" {}
        _Waves_pattern_normal_R ("Waves_pattern_normal_R", 2D) = "white" {}
        _Waves_pattern_normal_G ("Waves_pattern_normal_G", 2D) = "white" {}
        _Waves_pattern_normal_B ("Waves_pattern_normal_B", 2D) = "white" {}
        _Waves_pattern_normal_A ("Waves_pattern_normal_A", 2D) = "white" {}
        _foam_pattern ("foam_pattern", 2D) = "white" {}
        _Water_color_Shore ("Water_color_Shore", Color) = (0.2,0.5,0.8,1)
        _Water_color_Sea ("Water_color_Sea", Color) = (0,0.9172413,1,1)
        _Color_Blend ("Color_Blend", Range(0, 200)) = 126.7863
        _Roughness ("Roughness", Range(0, 1)) = 0.3846154
        _Metalness ("Metalness", Range(0, 1)) = 0
        _Height ("Height", Range(0, 0.1)) = 0.02666162
        _Tessaltion ("Tessaltion", Range(1, 100)) = 19.14231
        _Opacity ("Opacity", Range(0, 200)) = 0.5245801
        _Refraction ("Refraction", Range(0, 0.25)) = 0.03418804
        _PannerMacro_Xspeed ("PannerMacro_Xspeed", Range(-0.25, 0.25)) = 0
        _PannerMacro_Yspeed ("PannerMacro_Yspeed", Range(-0.25, 0.25)) = 0
        _PannerMicro_xspeed ("PannerMicro_xspeed", Range(-0.25, 0.25)) = 0
        _PannerMicro_yspeed ("PannerMicro_yspeed", Range(-0.25, 0.25)) = 0
        _Micro_water_scale ("Micro_water_scale", Range(1, 20)) = 1
        _Macro_water_scale ("Macro_water_scale", Range(0, 5)) = 0
        _Shore_waves_size ("Shore_waves_size", Range(0, 200)) = 0
        _Shore_waves_strength ("Shore_waves_strength", Range(1, 0)) = 1
        _Shore_waves_speed ("Shore_waves_speed", Range(-0.25, 0.25)) = 0
        _Sea_swell_height ("Sea_swell_height", Range(0, 0.5)) = 0.025
        _Sea_swell_length ("Sea_swell_length", Range(1, 0)) = 1
        _Sea_swell_speed ("Sea_swell_speed", Range(0, 1)) = 0
        _foam1_size ("foam1_size", Range(0, 20)) = 1
        _foam2_size ("foam2_size", Range(0, 50)) = 1.478489
        _foam_area ("foam_area", Range(0, 50)) = 0
        _Foam_opacity ("Foam_opacity", Range(0, 1)) = 0.3114368
        _useless ("useless", 2D) = "white" {}
        [HideInInspector]_Cutoff ("Alpha cutoff", Range(0,1)) = 0.5
    }
    SubShader {
        Tags {
            "IgnoreProjector"="True"
            "Queue"="Transparent"
            "RenderType"="Transparent"
        }
        GrabPass{ }
        Pass {
            Name "FORWARD"
            Tags {
                "LightMode"="ForwardBase"
            }
            Blend SrcAlpha OneMinusSrcAlpha
            ZWrite Off
            
            CGPROGRAM
            #pragma hull hull
            #pragma domain domain
            #pragma vertex tessvert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDBASE
            #include "UnityCG.cginc"
            #include "Tessellation.cginc"
            #include "UnityPBSLighting.cginc"
            #include "UnityStandardBRDF.cginc"
            #pragma multi_compile_fwdbase
            #pragma multi_compile_fog
            #pragma exclude_renderers gles3 metal d3d11_9x xbox360 xboxone ps3 ps4 psp2 
            #pragma target 5.0
            #pragma glsl
            uniform sampler2D _GrabTexture;
            uniform sampler2D _CameraDepthTexture;
            uniform float4 _TimeEditor;
            uniform sampler2D _Waves_pattern; uniform float4 _Waves_pattern_ST;
            uniform float _Tessaltion;
            uniform float _Refraction;
            uniform float _Opacity;
            uniform float _Height;
            uniform float _Roughness;
            uniform float4 _Water_color_Shore;
            uniform float4 _Water_color_Sea;
            uniform float _Color_Blend;
            uniform float _Shore_waves_size;
            uniform float _PannerMacro_Xspeed;
            uniform float _PannerMacro_Yspeed;
            uniform float _PannerMicro_xspeed;
            uniform float _PannerMicro_yspeed;
            uniform float _Micro_water_scale;
            uniform float _Macro_water_scale;
            uniform float _Shore_waves_strength;
            uniform float _Shore_waves_speed;
            uniform float _Sea_swell_height;
            uniform float _Sea_swell_length;
            uniform float _Sea_swell_speed;
            uniform float _Metalness;
            uniform sampler2D _Waves_pattern_normal_B; uniform float4 _Waves_pattern_normal_B_ST;
            uniform sampler2D _Waves_pattern_normal_G; uniform float4 _Waves_pattern_normal_G_ST;
            uniform sampler2D _Waves_pattern_normal_R; uniform float4 _Waves_pattern_normal_R_ST;
            uniform sampler2D _Waves_pattern_normal_A; uniform float4 _Waves_pattern_normal_A_ST;
            uniform float _foam_area;
            uniform float _foam1_size;
            uniform float _Foam_opacity;
            uniform sampler2D _foam_pattern; uniform float4 _foam_pattern_ST;
            uniform float _foam2_size;
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
                float4 screenPos : TEXCOORD5;
                float4 projPos : TEXCOORD6;
                UNITY_FOG_COORDS(7)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.tangentDir = normalize( mul( _Object2World, float4( v.tangent.xyz, 0.0 ) ).xyz );
                o.bitangentDir = normalize(cross(o.normalDir, o.tangentDir) * v.tangent.w);
                float4 node_641 = _Time + _TimeEditor;
                float2 node_8021 = (o.uv0*_Macro_water_scale).rg;
                float2 node_2729 = float2(((_PannerMacro_Xspeed*node_641.g)+node_8021.r),(node_8021.g+(node_641.g*_PannerMacro_Yspeed)));
                float4 node_9938 = tex2Dlod(_Waves_pattern,float4(node_2729,0.0,0));
                float node_1505 = lerp(node_9938.r,node_9938.b,0.5);
                float4 node_973 = _Time + _TimeEditor;
                float node_3672 = (frac((node_973.g*0.5))*2.5);
                float4 node_7438 = _Time + _TimeEditor;
                float2 node_3275 = (o.uv0*_Micro_water_scale).rg;
                float2 node_1452 = float2(((_PannerMicro_xspeed*node_7438.g)+node_3275.r),((node_7438.g*_PannerMicro_yspeed)+node_3275.g));
                float4 _node_8395 = tex2Dlod(_Waves_pattern,float4(node_1452,0.0,0));
                float node_596 = lerp(_node_8395.r,_node_8395.b,0.5);
                float4 node_5539 = _Time + _TimeEditor;
                float node_8465 = (frac((node_5539.g*0.4))*2.5);
                float node_2182 = (lerp(lerp(lerp(lerp(node_1505,node_9938.g,clamp(node_3672,0,1)),node_9938.b,clamp((node_3672+(-0.5)),0,1)),node_9938.a,clamp((node_3672+(-1.0)),0,1)),node_1505,clamp((node_3672+(-1.5)),0,1))+lerp(lerp(lerp(lerp(node_596,_node_8395.g,clamp(node_8465,0,1)),_node_8395.b,clamp((node_8465+(-0.5)),0,1)),_node_8395.a,clamp((node_8465+(-1.0)),0,1)),node_596,clamp((node_8465+(-1.5)),0,1)));
                float node_4907 = 0.0;
                float4 node_980 = _Time + _TimeEditor;
                v.vertex.xyz += (((node_2182*2.0+-1.0)*_Height*v.normal)+((sin((10.0*((_Sea_swell_length + ( (o.uv0.r - node_4907) * (0.0 - _Sea_swell_length) ) / (1.0 - node_4907))+(node_980.r*_Sea_swell_speed))*6.28318530718))*2.0+-1.0)*v.normal*_Sea_swell_height));
                o.posWorld = mul(_Object2World, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                o.projPos = ComputeScreenPos (o.pos);
                COMPUTE_EYEDEPTH(o.projPos.z);
                o.screenPos = o.pos;
                return o;
            }
            #ifdef UNITY_CAN_COMPILE_TESSELLATION
                struct TessVertex {
                    float4 vertex : INTERNALTESSPOS;
                    float3 normal : NORMAL;
                    float4 tangent : TANGENT;
                    float2 texcoord0 : TEXCOORD0;
                };
                struct OutputPatchConstant {
                    float edge[3]         : SV_TessFactor;
                    float inside          : SV_InsideTessFactor;
                    float3 vTangent[4]    : TANGENT;
                    float2 vUV[4]         : TEXCOORD;
                    float3 vTanUCorner[4] : TANUCORNER;
                    float3 vTanVCorner[4] : TANVCORNER;
                    float4 vCWts          : TANWEIGHTS;
                };
                TessVertex tessvert (VertexInput v) {
                    TessVertex o;
                    o.vertex = v.vertex;
                    o.normal = v.normal;
                    o.tangent = v.tangent;
                    o.texcoord0 = v.texcoord0;
                    return o;
                }
                float Tessellation(TessVertex v){
                    return _Tessaltion;
                }
                float4 Tessellation(TessVertex v, TessVertex v1, TessVertex v2){
                    float tv = Tessellation(v);
                    float tv1 = Tessellation(v1);
                    float tv2 = Tessellation(v2);
                    return float4( tv1+tv2, tv2+tv, tv+tv1, tv+tv1+tv2 ) / float4(2,2,2,3);
                }
                OutputPatchConstant hullconst (InputPatch<TessVertex,3> v) {
                    OutputPatchConstant o = (OutputPatchConstant)0;
                    float4 ts = Tessellation( v[0], v[1], v[2] );
                    o.edge[0] = ts.x;
                    o.edge[1] = ts.y;
                    o.edge[2] = ts.z;
                    o.inside = ts.w;
                    return o;
                }
                [domain("tri")]
                [partitioning("fractional_odd")]
                [outputtopology("triangle_cw")]
                [patchconstantfunc("hullconst")]
                [outputcontrolpoints(3)]
                TessVertex hull (InputPatch<TessVertex,3> v, uint id : SV_OutputControlPointID) {
                    return v[id];
                }
                [domain("tri")]
                VertexOutput domain (OutputPatchConstant tessFactors, const OutputPatch<TessVertex,3> vi, float3 bary : SV_DomainLocation) {
                    VertexInput v = (VertexInput)0;
                    v.vertex = vi[0].vertex*bary.x + vi[1].vertex*bary.y + vi[2].vertex*bary.z;
                    v.normal = vi[0].normal*bary.x + vi[1].normal*bary.y + vi[2].normal*bary.z;
                    v.tangent = vi[0].tangent*bary.x + vi[1].tangent*bary.y + vi[2].tangent*bary.z;
                    v.texcoord0 = vi[0].texcoord0*bary.x + vi[1].texcoord0*bary.y + vi[2].texcoord0*bary.z;
                    VertexOutput o = vert(v);
                    return o;
                }
            #endif
            float4 frag(VertexOutput i) : COLOR {
                #if UNITY_UV_STARTS_AT_TOP
                    float grabSign = -_ProjectionParams.x;
                #else
                    float grabSign = _ProjectionParams.x;
                #endif
                i.normalDir = normalize(i.normalDir);
                i.screenPos = float4( i.screenPos.xy / i.screenPos.w, 0, 0 );
                i.screenPos.y *= _ProjectionParams.x;
                float3x3 tangentTransform = float3x3( i.tangentDir, i.bitangentDir, i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float4 node_641 = _Time + _TimeEditor;
                float2 node_8021 = (i.uv0*_Macro_water_scale).rg;
                float2 node_2729 = float2(((_PannerMacro_Xspeed*node_641.g)+node_8021.r),(node_8021.g+(node_641.g*_PannerMacro_Yspeed)));
                float4 node_215 = tex2D(_Waves_pattern_normal_R,node_2729);
                float4 node_8771 = tex2D(_Waves_pattern_normal_B,node_2729);
                float3 node_6736 = lerp(node_215.rgb,node_8771.rgb,0.5);
                float4 node_6656 = tex2D(_Waves_pattern_normal_G,node_2729);
                float4 node_5576 = _Time + _TimeEditor;
                float node_6716 = (frac((node_5576.g*0.5))*2.5);
                float4 node_7063 = tex2D(_Waves_pattern_normal_A,node_2729);
                float3 node_9570 = lerp(lerp(lerp(lerp(node_6736,node_6656.rgb,clamp(node_6716,0,1)),node_8771.rgb,clamp((node_6716+(-0.5)),0,1)),node_7063.rgb,clamp((node_6716+(-1.0)),0,1)),node_6736,clamp((node_6716+(-1.5)),0,1));
                float4 node_7438 = _Time + _TimeEditor;
                float2 node_3275 = (i.uv0*_Micro_water_scale).rg;
                float2 node_1452 = float2(((_PannerMicro_xspeed*node_7438.g)+node_3275.r),((node_7438.g*_PannerMicro_yspeed)+node_3275.g));
                float4 node_5152 = tex2D(_Waves_pattern_normal_R,node_1452);
                float4 node_8042 = tex2D(_Waves_pattern_normal_B,node_1452);
                float3 node_8629 = lerp(node_5152.rgb,node_8042.rgb,0.5);
                float4 node_2102 = tex2D(_Waves_pattern_normal_G,node_1452);
                float4 node_9976 = _Time + _TimeEditor;
                float node_6699 = (frac((node_9976.g*0.5))*2.5);
                float4 node_5311 = tex2D(_Waves_pattern_normal_A,node_1452);
                float3 node_5173 = lerp(lerp(lerp(lerp(node_8629,node_2102.rgb,clamp(node_6699,0,1)),node_8042.rgb,clamp((node_6699+(-0.5)),0,1)),node_5311.rgb,clamp((node_6699+(-1.0)),0,1)),node_8629,clamp((node_6699+(-1.5)),0,1));
                float3 node_9189 = saturate(( node_5173 > 0.5 ? (1.0-(1.0-2.0*(node_5173-0.5))*(1.0-node_9570)) : (2.0*node_5173*node_9570) ));
                float3 normalLocal = node_9189;
                float3 normalDirection = normalize(mul( normalLocal, tangentTransform )); // Perturbed normals
                float3 viewReflectDirection = reflect( -viewDirection, normalDirection );
                float sceneZ = max(0,LinearEyeDepth (UNITY_SAMPLE_DEPTH(tex2Dproj(_CameraDepthTexture, UNITY_PROJ_COORD(i.projPos)))) - _ProjectionParams.g);
                float partZ = max(0,i.projPos.z - _ProjectionParams.g);
                float4 node_5639 = _Time + _TimeEditor;
                float2 node_7263 = (((node_5639.g*_Shore_waves_speed)+saturate((sceneZ-partZ)/_Shore_waves_size))+i.uv0);
                float4 node_5089 = tex2D(_Waves_pattern,node_7263);
                float4 node_9938 = tex2D(_Waves_pattern,node_2729);
                float node_1505 = lerp(node_9938.r,node_9938.b,0.5);
                float4 node_973 = _Time + _TimeEditor;
                float node_3672 = (frac((node_973.g*0.5))*2.5);
                float4 _node_8395 = tex2D(_Waves_pattern,node_1452);
                float node_596 = lerp(_node_8395.r,_node_8395.b,0.5);
                float4 node_5539 = _Time + _TimeEditor;
                float node_8465 = (frac((node_5539.g*0.4))*2.5);
                float node_2182 = (lerp(lerp(lerp(lerp(node_1505,node_9938.g,clamp(node_3672,0,1)),node_9938.b,clamp((node_3672+(-0.5)),0,1)),node_9938.a,clamp((node_3672+(-1.0)),0,1)),node_1505,clamp((node_3672+(-1.5)),0,1))+lerp(lerp(lerp(lerp(node_596,_node_8395.g,clamp(node_8465,0,1)),_node_8395.b,clamp((node_8465+(-0.5)),0,1)),_node_8395.a,clamp((node_8465+(-1.0)),0,1)),node_596,clamp((node_8465+(-1.5)),0,1)));
                float2 sceneUVs = float2(1,grabSign)*i.screenPos.xy*0.5+0.5 + ((lerp(node_5089.r,node_2182,_Shore_waves_strength)*2.0+-1.0)*_Refraction*i.normalDir).rg;
                float4 sceneColor = tex2D(_GrabTexture, sceneUVs);
                float3 lightDirection = normalize(_WorldSpaceLightPos0.xyz);
                float3 lightColor = _LightColor0.rgb;
                float3 halfDirection = normalize(viewDirection+lightDirection);
////// Lighting:
                float attenuation = 1;
                float3 attenColor = attenuation * _LightColor0.xyz;
                float Pi = 3.141592654;
                float InvPi = 0.31830988618;
///////// Gloss:
                float2 node_545 = (i.uv0*_foam2_size);
                float4 node_9997 = tex2D(_foam_pattern,node_545);
                float2 node_5578 = (i.uv0*_foam1_size);
                float4 node_275 = tex2D(_foam_pattern,node_5578);
                float node_5042 = ((1.0 - saturate((sceneZ-partZ)/_foam_area))*(node_9997.r+node_275.r)*_Foam_opacity);
                float gloss = 1.0 - (_Roughness+node_5042); // Convert roughness to gloss
                float specPow = exp2( gloss * 10.0+1.0);
/////// GI Data:
                UnityLight light;
                #ifdef LIGHTMAP_OFF
                    light.color = lightColor;
                    light.dir = lightDirection;
                    light.ndotl = LambertTerm (normalDirection, light.dir);
                #else
                    light.color = half3(0.f, 0.f, 0.f);
                    light.ndotl = 0.0f;
                    light.dir = half3(0.f, 0.f, 0.f);
                #endif
                UnityGIInput d;
                d.light = light;
                d.worldPos = i.posWorld.xyz;
                d.worldViewDir = viewDirection;
                d.atten = attenuation;
                Unity_GlossyEnvironmentData ugls_en_data;
                ugls_en_data.roughness = 1.0 - gloss;
                ugls_en_data.reflUVW = viewReflectDirection;
                UnityGI gi = UnityGlobalIllumination(d, 1, normalDirection, ugls_en_data );
                lightDirection = gi.light.dir;
                lightColor = gi.light.color;
////// Specular:
                float NdotL = max(0, dot( normalDirection, lightDirection ));
                float LdotH = max(0.0,dot(lightDirection, halfDirection));
                float3 diffuseColor = saturate((1.0-(1.0-lerp(_Water_color_Shore.rgb,_Water_color_Sea.rgb,saturate((sceneZ-partZ)/_Color_Blend)))*(1.0-node_5042))); // Need this for specular when using metallic
                float specularMonochrome;
                float3 specularColor;
                diffuseColor = DiffuseAndSpecularFromMetallic( diffuseColor, _Metalness, specularColor, specularMonochrome );
                specularMonochrome = 1-specularMonochrome;
                float NdotV = max(0.0,dot( normalDirection, viewDirection ));
                float NdotH = max(0.0,dot( normalDirection, halfDirection ));
                float VdotH = max(0.0,dot( viewDirection, halfDirection ));
                float visTerm = SmithBeckmannVisibilityTerm( NdotL, NdotV, 1.0-gloss );
                float normTerm = max(0.0, NDFBlinnPhongNormalizedTerm(NdotH, RoughnessToSpecPower(1.0-gloss)));
                float specularPBL = max(0, (NdotL*visTerm*normTerm) * unity_LightGammaCorrectionConsts_PIDiv4 );
                float3 directSpecular = (floor(attenuation) * _LightColor0.xyz) * pow(max(0,dot(halfDirection,normalDirection)),specPow)*specularPBL*lightColor*FresnelTerm(specularColor, LdotH);
                float3 specular = directSpecular;
/////// Diffuse:
                NdotL = max(0.0,dot( normalDirection, lightDirection ));
                half fd90 = 0.5 + 2 * LdotH * LdotH * (1-gloss);
                float3 directDiffuse = ((1 +(fd90 - 1)*pow((1.00001-NdotL), 5)) * (1 + (fd90 - 1)*pow((1.00001-NdotV), 5)) * NdotL) * attenColor;
                float3 indirectDiffuse = float3(0,0,0);
                indirectDiffuse += UNITY_LIGHTMODEL_AMBIENT.rgb; // Ambient Light
                float3 diffuse = (directDiffuse + indirectDiffuse) * diffuseColor;
/// Final Color:
                float3 finalColor = diffuse + specular;
                fixed4 finalRGBA = fixed4(lerp(sceneColor.rgb, finalColor,(node_5042+saturate((sceneZ-partZ)/_Opacity))),1);
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }
        Pass {
            Name "ShadowCaster"
            Tags {
                "LightMode"="ShadowCaster"
            }
            Offset 1, 1
            
            CGPROGRAM
            #pragma hull hull
            #pragma domain domain
            #pragma vertex tessvert
            #pragma fragment frag
            #define UNITY_PASS_SHADOWCASTER
            #include "UnityCG.cginc"
            #include "Lighting.cginc"
            #include "Tessellation.cginc"
            #include "UnityPBSLighting.cginc"
            #include "UnityStandardBRDF.cginc"
            #pragma fragmentoption ARB_precision_hint_fastest
            #pragma multi_compile_shadowcaster
            #pragma multi_compile_fog
            #pragma exclude_renderers gles3 metal d3d11_9x xbox360 xboxone ps3 ps4 psp2 
            #pragma target 5.0
            #pragma glsl
            uniform float4 _TimeEditor;
            uniform sampler2D _Waves_pattern; uniform float4 _Waves_pattern_ST;
            uniform float _Tessaltion;
            uniform float _Height;
            uniform float _PannerMacro_Xspeed;
            uniform float _PannerMacro_Yspeed;
            uniform float _PannerMicro_xspeed;
            uniform float _PannerMicro_yspeed;
            uniform float _Micro_water_scale;
            uniform float _Macro_water_scale;
            uniform float _Sea_swell_height;
            uniform float _Sea_swell_length;
            uniform float _Sea_swell_speed;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float4 tangent : TANGENT;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                V2F_SHADOW_CASTER;
                float2 uv0 : TEXCOORD1;
                float3 normalDir : TEXCOORD2;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                float4 node_641 = _Time + _TimeEditor;
                float2 node_8021 = (o.uv0*_Macro_water_scale).rg;
                float2 node_2729 = float2(((_PannerMacro_Xspeed*node_641.g)+node_8021.r),(node_8021.g+(node_641.g*_PannerMacro_Yspeed)));
                float4 node_9938 = tex2Dlod(_Waves_pattern,float4(node_2729,0.0,0));
                float node_1505 = lerp(node_9938.r,node_9938.b,0.5);
                float4 node_973 = _Time + _TimeEditor;
                float node_3672 = (frac((node_973.g*0.5))*2.5);
                float4 node_7438 = _Time + _TimeEditor;
                float2 node_3275 = (o.uv0*_Micro_water_scale).rg;
                float2 node_1452 = float2(((_PannerMicro_xspeed*node_7438.g)+node_3275.r),((node_7438.g*_PannerMicro_yspeed)+node_3275.g));
                float4 _node_8395 = tex2Dlod(_Waves_pattern,float4(node_1452,0.0,0));
                float node_596 = lerp(_node_8395.r,_node_8395.b,0.5);
                float4 node_5539 = _Time + _TimeEditor;
                float node_8465 = (frac((node_5539.g*0.4))*2.5);
                float node_2182 = (lerp(lerp(lerp(lerp(node_1505,node_9938.g,clamp(node_3672,0,1)),node_9938.b,clamp((node_3672+(-0.5)),0,1)),node_9938.a,clamp((node_3672+(-1.0)),0,1)),node_1505,clamp((node_3672+(-1.5)),0,1))+lerp(lerp(lerp(lerp(node_596,_node_8395.g,clamp(node_8465,0,1)),_node_8395.b,clamp((node_8465+(-0.5)),0,1)),_node_8395.a,clamp((node_8465+(-1.0)),0,1)),node_596,clamp((node_8465+(-1.5)),0,1)));
                float node_4907 = 0.0;
                float4 node_980 = _Time + _TimeEditor;
                v.vertex.xyz += (((node_2182*2.0+-1.0)*_Height*v.normal)+((sin((10.0*((_Sea_swell_length + ( (o.uv0.r - node_4907) * (0.0 - _Sea_swell_length) ) / (1.0 - node_4907))+(node_980.r*_Sea_swell_speed))*6.28318530718))*2.0+-1.0)*v.normal*_Sea_swell_height));
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex );
                TRANSFER_SHADOW_CASTER(o)
                return o;
            }
            #ifdef UNITY_CAN_COMPILE_TESSELLATION
                struct TessVertex {
                    float4 vertex : INTERNALTESSPOS;
                    float3 normal : NORMAL;
                    float4 tangent : TANGENT;
                    float2 texcoord0 : TEXCOORD0;
                };
                struct OutputPatchConstant {
                    float edge[3]         : SV_TessFactor;
                    float inside          : SV_InsideTessFactor;
                    float3 vTangent[4]    : TANGENT;
                    float2 vUV[4]         : TEXCOORD;
                    float3 vTanUCorner[4] : TANUCORNER;
                    float3 vTanVCorner[4] : TANVCORNER;
                    float4 vCWts          : TANWEIGHTS;
                };
                TessVertex tessvert (VertexInput v) {
                    TessVertex o;
                    o.vertex = v.vertex;
                    o.normal = v.normal;
                    o.tangent = v.tangent;
                    o.texcoord0 = v.texcoord0;
                    return o;
                }
                float Tessellation(TessVertex v){
                    return _Tessaltion;
                }
                float4 Tessellation(TessVertex v, TessVertex v1, TessVertex v2){
                    float tv = Tessellation(v);
                    float tv1 = Tessellation(v1);
                    float tv2 = Tessellation(v2);
                    return float4( tv1+tv2, tv2+tv, tv+tv1, tv+tv1+tv2 ) / float4(2,2,2,3);
                }
                OutputPatchConstant hullconst (InputPatch<TessVertex,3> v) {
                    OutputPatchConstant o = (OutputPatchConstant)0;
                    float4 ts = Tessellation( v[0], v[1], v[2] );
                    o.edge[0] = ts.x;
                    o.edge[1] = ts.y;
                    o.edge[2] = ts.z;
                    o.inside = ts.w;
                    return o;
                }
                [domain("tri")]
                [partitioning("fractional_odd")]
                [outputtopology("triangle_cw")]
                [patchconstantfunc("hullconst")]
                [outputcontrolpoints(3)]
                TessVertex hull (InputPatch<TessVertex,3> v, uint id : SV_OutputControlPointID) {
                    return v[id];
                }
                [domain("tri")]
                VertexOutput domain (OutputPatchConstant tessFactors, const OutputPatch<TessVertex,3> vi, float3 bary : SV_DomainLocation) {
                    VertexInput v = (VertexInput)0;
                    v.vertex = vi[0].vertex*bary.x + vi[1].vertex*bary.y + vi[2].vertex*bary.z;
                    v.normal = vi[0].normal*bary.x + vi[1].normal*bary.y + vi[2].normal*bary.z;
                    v.tangent = vi[0].tangent*bary.x + vi[1].tangent*bary.y + vi[2].tangent*bary.z;
                    v.texcoord0 = vi[0].texcoord0*bary.x + vi[1].texcoord0*bary.y + vi[2].texcoord0*bary.z;
                    VertexOutput o = vert(v);
                    return o;
                }
            #endif
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3 normalDirection = i.normalDir;
                SHADOW_CASTER_FRAGMENT(i)
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
