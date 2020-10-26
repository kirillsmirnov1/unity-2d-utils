## ScreenEdges

On scene start creates four PlatformEffector2D objects surrounding screen. Effectors stop objects from going out of screen, especially if you don't forget to set the layer mask.

Works only if scene's main camera is orthographic. 

![](https://raw.githubusercontent.com/kirillsmirnov1/unity-2d-utils/main/img/ScreenEdges_0.PNG)

Also there is `ScreenEdgesHighTop` top platform moved upwards. Can be used when some objects might go higher, but shouldn't go away at all.

![](https://raw.githubusercontent.com/kirillsmirnov1/unity-2d-utils/main/img/ScreenEdges_1.PNG)

_Also_, you can inherit class which adds same gaps for every edge. It's pretty easy, I just had no need for it yet.