# XRSleepPauseError
1. What happened
Recently, we have begun encoutnering an error with our builds of a VR App for the Meta Quest 3 headset. Every now and then, after having our App open on the headset and setting it aside, where it then goes into sleep mode, an unexpected effect will be permenantly applied to the session. When you press the Meta home button on the right controller to bring up the overlay menu, the camera in Unity loses tracking of the headset. The camera gets put into the floor of the scene and the picture does not move along as you move your head around in VR. When you unpause again tracking is regained, but from then on, pausing causes this graphical error consistently.

We are uncertain when it began but it is likely related one or both of these changes our project recently went through:
- Updating our Unity with the new security patch (We went from Unity 6000.0.51f1 to Unity 6000.0.58f2)
- Recent updates to the Meta Quest 3 headset
The most likely suspect is the Meta Quest 3 update, as the error is reproducible on older builds made before the security patch. It is additionally not possible on Meta Quest 2 headsets, which supports this idea. We will also be reporting this issue to Meta, as it is unclear if this is an issue that should be solved in Unity's XR systems or in Meta's software.

2. How can we reproduce it using the example you attached
I have attached a project built clean from scratch, following Meta's guide found here:
https://developers.meta.com/horizon/documentation/unity/unity-project-setup/

Using the attached project, here's a step by step guide how to reach this bug:
1. Make a build for Android with the attached project
2. Load the APK onto a Meta Quest 3 headset
3. Open the app and verify head and hand tracking are working in the scene
4. Set aside the headset for around 30 seconds (this has been the most consistent timing for us to reproduce this bug)
5. Put the headset back on and verify that everything is still working as expected (move your head and hands, pause using the Meta Home Button, etc.)
6. Set aside the headset again for another 30 seconds
7. Put it one once again
8. You should now see that, when you bring up the Meta overlay menu with the Meta Home Button, the camera in Unity gets stuck in the floor and loses tracking. When you unpause, tracking is regained. But from then on, tracking is lost every time you bring up the Meta overlay menu.

Additional info:
- The bug goes away again if you do another round of setting the headset aside for 30 seconds. Doing so will give you a none buggy session again. Presumably more 30 second cycles will continue to switch between having the error and not having it
