Modified version of DebugGUI Graph that supports package manager integration.
Original Asset: https://assetstore.unity.com/packages/tools/gui/debuggui-graph-139275

Check out DebugGUIExamples.cs for a quick overview of the features, and the public DebugGUI.cs methods for more detailed information.

Note that the graphing and logging attributes will only work automatically for object present at start. 
The attributes can be force-reinitialized by calling DebugGUI.Instance.ForceReinitializeAttributes(), 
but this may be a very expensive operation depending on scene size.