Team Name: The Pixelated Pringles
Project Name: Creationometry
Team Members: Brandon Bandholz, Megan Baxter, Xueting Hu, Callie Seehafer, Reese Wunderlich
Last update: 05/10/2021

Run Instructions:

1. Select and run Creationometry.exe


Build Instructions:

1. Open the Creationometry folder and open "Creationometry.sln" in Visual Studio 2019.
2. Select "Build Solution" from the "Build" drop down menu.


Files Needed to Run the System:
1. No additional files are needed.


Assumptions Made About Locations of Documents:
1. No assumptions about locations.


Known Bugs:

1. The system will experience a lag when first interacting with the Canvas. For example, when
   selecting the element and moving it. This bug could not be fixed because we ran out of time.

2. A bug occurs if the following steps are taken:
   a. Click on an ellipse to open the ellipse modification menu.
   b. Change the value of p0x.
   c. Click on the canvas to close the menu.
   The shape does not move and the value does not change. The cause of this issue is unknown, but likely has to do with the
   timing of multiple event handlers causing an issue. Another issue occurs if the user continues with these steps:
   d. Click on the ellipse again to open the menu.
   e. Change the value of p0x to the same value as last time.
   f. Tab out of the p0x entry field.
   This avoids the previously mentioned issue. However, the input control believes that the value has not been changed, so
   it does not update the value in the ellipse. The reason for this issue is known, but we ran out of time to fix it.

3. The buttons in the object toolbox change size when the program window is resized. However, they do not change
   size when the window is maximized. As a result, they appear too small when the program is opened. This bug could
   not be fixed because after extensive searching, no solution or discussion relevant to the issue could be found online.

4. If the user selects a shape while a shape is selected (same or different shape), the newly selected shape moves to the
   location of the mouse when it is released. This almost always results in the shape being offset slightly. We know the reason
   for this bug, but we did not have time to fix it.


Known Design Deficiencies:
1. Undo/Redo is not currently implemented for moving elements when doing "click" and "drag".
2. Undo/Redo is not currently implemented for changing the border color or border weight of the elements using the border editing menu.
   The borders of ellipses and circles can also be modified using the relevant portion of the menu for editing ellipses. Undo and redo are
   implemented for this method of modification.
3. The system does not fully implement double-buffering. There is flickering when the display updates.
4. When moving an ellipse or circle using "click" and "drag" it is relocated based off of the upper-left corner instead of a center point.
5. The rectilinear pattern, radial pattern, text box, and image elements are not implemented. These are represented
   by the bottom four buttons in the object toolbox, which all do nothing when clicked.
6. The element modification menus are not implemented for any shape besides the ellipse (which includes circles). For the ellipse modification
   menu, only the border editing section can be used.
7. The features under the File and View dropdown menus are not implemented.
8. The user can not specify the number of sides for a regular polygon.
9. The user can not specify the shape and size of any shape.
10. The user can not see the polygon while they are drawing it. There is no indication that they are actively drawing
    a polygon. The drawing process is ended by clicking on the free-draw polygon object toolbox button a second time.
11. Rather than having fixed dimensions, the canvas fills up a portion of the window. As a result, shapes that are initially visible on the
    canvas may end up outside the boundary of the canvas if the window is made smaller. The canvas does not scale or zoom when the window
    is resized. This is not how a user might expect the canvas to work. We tried various property settings, adding
    scroll bars, and additional logic, but nothing allowed us to add this functionality.
12. If the user moves a shape off the canvas, it can only be retrieved through undo. However, since moving an shape does not
    have undo/redo implemented, the user may have to undo multiple steps.


Running Tests:
1. Open the Creationometry folder and open "Creationometry.sln" in Visual Studio 2019.
2. Select "Run All Tests" from the "Test" drop down menu.
3. Confirm there is a green checkmark next to each test.

Feature guide:
Since our program is not very straightforward, we have included the following list of features to get the user started.
- The object toolbox on the left side can be used to add lines, circles, ellipses, regular polygons, and freely-drawn
  polygons to the canvas.
- The user can undo and redo their actions by using the buttons under "Edit" or by using the shortcuts listed there.
- The user can select shapes on the canvas.
- The user can drag the selected shape to move it.
- The user can change the border weight and border color of the selected shape on the right side of the screen. (This
  works slightly differently for the ellipses and circles.)
- The user can remove, duplicate, or rotate the selected shape by selecting the features under "Tools."
- By clicking "Canvas Color", the user can change the color of the canvas.
- When an ellipse or circle is selected, a menu opens on the right side. This menu can be used to change the border
  width, opacity, and color. The menu can also be used to change the x-value of the center point, but this feature has bugs.