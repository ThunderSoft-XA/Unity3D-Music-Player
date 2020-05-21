# Unity3D-Music-Player

Basic Information:

Maintainer: Kou Zhiwu、YongRong、YanShiqin、FangBo.

Start date: April 24th, 2019.

SDK tools:Qualcomm 3D Audio Plugin for Unity

Function description:
Using this audio plugin to develop a music player based on Unity for music playback, tentative and other functions.

Document introduction:

APP: apk for test.

doc: used to introduce the demo.

picture:pictures in this demo.

Abouts Assets :

===>AudioMixer.mixer:an AudioMixer.

===>Editor/Q3DAudio 
	| 
	|--Q3DAudioGlobalSettingsEditor.cs：mainly to add Q3DAudioGlobalSettings's attributes in Unity interface. 
	|--Q3DAudioRoomEditor.cs:mainly to add Q3DAudioRoom's attributes in Unity interface. 
	|--Q3DAudioSourceEditor.cs：mainly to add Q3DAudioSource's attributes in Unity interface.

===>Mat: a Material ball for cube.

===>Music:some Audio clips.

===>Materials:some textures used in planet models.

===>Plugins:some dynamic libraries used in different Architecture, such armeabi-v7a、x86、x86_64.

===>Q3DAudio 
|--PluginLibs/ ：some dynamic libraries too. 
	 |--Scripts 
	 |--Q3DAudioGlobalSettings.cs: get Q3DAudioGlobalSettings attribute values from inspector and handle it accordingly.
	 |--Q3DAudioListener.cs: get Q3DAudioListener attribute values from inspector and handle it accordingly. 
	 |--Q3DAudioManager.cs: get Q3DAudioManager attribute values from inspector and handle it accordingly. 
	 |--Q3DAudioRoom.cs: get Q3DAudioRoom values from inspector and handle it accordingly. 
	 |--Q3DAudioSource.cs: get Q3DAudioSource attribute values from inspector and handle it accordingly.

===>Resources
     |--button:some button pictures.
     |--Skyboxs:some pictures for Skybox.

===>Scenes
     |--mainScene.unity:a Scene Perspective.

===>Scripts 
	|--PlanetMove.cs: mainly to make planets achieve rotation　and revolution. 
	|--SwitchToMain.cs: switch to main Scene. 
	|--SwitchToNepture.cs: switch to Nepture Scene. 
	|--SwitchToUp.cs: switch to looking up Scene. 
	|--ZoomInAndout.cs: mainly to make gameobjects zoom in and out.

===>SpeakModel : some speaker models.
Usage Instructions:

1、Download code from github according to the repository from “https://github.com/ThunderSoft-XA/Solar-System-With-3D-Sound.git”. 
2、install Unity, and any version of Unity before Unity 5 will not work with this product. 
3、douuble click *.unity to open the demo. 
4、compile them into APK and install it to android device. 
5、open the APK, and you will enjoy it. 
6、if you care about some performance indicators, you can use Snapdragon Profiler to view it.
