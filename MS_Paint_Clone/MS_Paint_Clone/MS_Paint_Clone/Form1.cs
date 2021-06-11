/************************************************************
 *                                                          *
 *  Program Name: MS_Paint_Clone                            *
 *                                                          *
 *  Date: 05/06/2021                                        *
 *                                                          *
 *  Programmers:  Ahmed Khan                                *
 *                                                          *
 *  Purpose:  This is a WinForm application that I did as a *
 *  side project to keep myself busy.  Tried to see if I    *
 *  could implement features like the actual MS Paint       *
 *  application.                                            *
 *                                                          *
 ************************************************************/

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace MS_Paint_Clone
{
    public partial class Form1 : Form
    {
        // holds filename if current project already exists as a file
        private static string currentFilename = null;

        // point that holds location of mousedown event
        private static Point one;

        // bitmap that holds the bitmap that gets saved to png and loaded on picturebox
        Bitmap bitM;

        // an int to keep track of if a file was opened or not, comes in use in Canvas_Print to determine if bitM will be blank or exisiting image
        int openBitMInt = 0;

        // temporary bitmap to hold loaded images for open menu item
        Bitmap openBitM;

        // holds all the points for a single line, point, trace.
        private static List<Point> pointList = new List<Point>();

        // a list and stack, list holds all the lines and points drawn and undoStack is to hold lines to undo and redo with ease.
        private static List<Tuple<Pen, List<Point>>> lineStack = new List<Tuple<Pen, List<Point>>>();
        private static Stack<Tuple<Pen, List<Point>>> undoStack = new Stack<Tuple<Pen, List<Point>>>();

        // an int to check if mouse had moved before mouseDown event has occured
        private static int initialCheckInt = 0;

        // graphics object used in Canvas_MouseMove to trace lines as they are drawn
        Graphics g;

        // holds default color and future color changes to drawing utensil
        Color chosenColor = Color.Black;

        // bool used to determine when a mouse is held down in Canvas_MouseMove
        bool mouseHeld = false;

        // two strings to keep track of current chosen drawing tool and last selected tool for cases where current is eraser and user chooses color, current will switch back to pencil or brush
        string drawingTool = "pencil";
        string lastToolSelected = "pencil";

        // A list that holds the 5 most recently opened/saved files.
        private static List<string> recentlyOpenedList = new List<string>();



        /************************************************************
         *                                                          *
         *  Class Name:  Form1                                      *
         *                                                          *
         *  Purpose:  This is the class that implements all the     *
         *            functionality of the paint form controls.     *
         *            Form implements a basic take on MS Paint.     *
         *                                                          *
         ************************************************************/
        public Form1()
        {
            InitializeComponent();

            // intialize Graphics object
            g = Canvas.CreateGraphics();


            //string and streamreader for input from recently open files from recentlyopened.txt
            string input;
            StreamReader recentlyOpened;

            // try to initialize the streamreader
            try
            {
                recentlyOpened = new System.IO.StreamReader("..\\..\\..\\recentlyopened.txt");
            }
            catch (Exception)
            {
                Console.WriteLine("Error: \"recentlyopened.txt\" file was not found or could not be read.");
                return;
            }

            int x = 0;
            // add 5 most recent opened files to recentlyOpened list
            while ((input = recentlyOpened.ReadLine()) != null && x < 5)
            {
                recentlyOpenedList.Add(input);
                x++;
            }

            // add upto 5 most recent opened files as menu items
            if(recentlyOpenedList.Count > 0)
            {
                int i = 0;
                foreach (string fileName in recentlyOpenedList)
                {
                    if(i < 5)
                    {
                        recentlyOpenedToolStripMenuItem.DropDownItems.Add(new ToolStripMenuItem(fileName));     // create new ToolStripMenuItem with name of each filename.
                    }
                    i++;
                }
            }

            recentlyOpened.Close();     // close streamreader.

        }



        /***********************************************************
        *                                                          *
        *  Method Name:  Canvas_Paint()                            *
        *                                                          *
        *  Parameters: an object called sender representing the    *
        *              clicked object and an PaintEventArgs object.*
        *                                                          *
        *  Purpose:  This method paints/draws using graphics and   *
        *            bitmaps to the screen and image property of   *
        *            a picture box called canvas.                  *
        *            This method is an event handler.  Runs when   *
        *            Refresh() or Invalidate() are called on the   *
        *            picture box object.                           *
        *                                                          *
        *  Return:  void, no return.                               *
        *                                                          *
        ************************************************************/
        private void Canvas_Paint(object sender, PaintEventArgs e)
        {
            // decide whether to use a blank background or opened png (openBitM) as background of bitmap, only an opened file will trigger this conditional.
            if(openBitMInt > 0) {
                bitM = openBitM;
            } else
                bitM = new Bitmap(ClientRectangle.Width, ClientRectangle.Height);

            // create graphics object that will draw to the bitmap
            Graphics graphic = Graphics.FromImage(bitM);

            // make background of bitmap equal to the background color of the picture box.
            if (openBitMInt == 0)
                graphic.Clear(Canvas.BackColor);

            // draw all lines in lineStack if count is greater than 0
            if (lineStack.Count > 0)
            {
                int i = 0;

                foreach (Tuple<Pen, List<Point>> item in lineStack)
                {

                    if (item.Item2.Count > 1)
                    {
                        graphic.DrawLines(item.Item1, item.Item2.ToArray());        // this will run for all traced lines, greater than one pixel.

                    }
                    else if (item.Item2.Count == 1)                                 // these will run to draw one pixel depending on which drawing tool has been selected.
                    {
                        if (item.Item1.Width >= 5.0 && item.Item1.Width <= 8.0)
                        {
                            graphic.FillEllipse(item.Item1.Brush, new RectangleF(item.Item2[0].X - 3, item.Item2[0].Y - 3, (float)brushThicknessNumUpDown.Value, (float)brushThicknessNumUpDown.Value));

                        }
                        else if (item.Item1.Width >= 1.0 && item.Item1.Width <= 3.0)
                        {
                            graphic.DrawEllipse(item.Item1, new Rectangle(item.Item2[0].X, item.Item2[0].Y - 1, 1, 1));
                        }
                        else
                        {
                            graphic.FillEllipse(item.Item1.Brush, new RectangleF(item.Item2[0].X - 3, item.Item2[0].Y - 3, 8, 8));
                        }
                    }
                }
            }

            e.Graphics.DrawImage(bitM, 0, 0);           // update the Graphics object of passed in the Canvas_Paint method to update the image of Canvas using the bitmap we drew on/in
        }



        /***********************************************************
        *                                                          *
        *  Method Name:  Canvas_MouseDown()                        *
        *                                                          *
        *  Parameters: an object called sender representing the    *
        *              clicked object and an MouseEventArgs object.*
        *                                                          *
        *  Purpose:  This method records the location at which     *
        *            the MouseDown event occured and sets mouseHeld*
        *            to true to prepare for possible mosue         *
        *            movement/trace.                               *
        *            This method is an event handler.  Runs when   *
        *            MouseDown event occurs.                       *
        *                                                          *
        *  Return:  void, no return.                               *
        *                                                          *
        ************************************************************/
        private void Canvas_MouseDown(object sender, MouseEventArgs e)
        {
            if (undoStack.Count > 0)        // clearing undoStack for situation where user undoes many events and then makes a new one, thus messing with the timeline of undo's and redo's.  They reset.
                undoStack.Clear();

            one = e.Location;

            if (drawingTool != "line")      // if line tool has not been chosen, set mouseHeld to true.
            {
                mouseHeld = true;
            }
        }



        /***********************************************************
        *                                                          *
        *  Method Name:  Canvas_MouseMove()                        *
        *                                                          *
        *  Parameters: an object called sender representing the    *
        *              clicked object and an MouseEventArgs object.*
        *                                                          *
        *  Purpose:  This method records the location at which     *
        *            the MouseMove event occurs repeatedly when    * 
        *            tracing a line or shape.                      *
        *            This method is an event handler.  Runs when   *
        *            Mousemove event occurs.                       *
        *                                                          *
        *  Return:  void, no return.                               *
        *                                                          *
        ************************************************************/
        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseHeld == true && one.X != 0 && one.Y != 0)       // draw a line every time the mouse moves after MouseDown before a MouseUp occurs for trace preview
            {
                if (initialCheckInt == 0)                   // set initialCheckInt to 1 to signal mouse moved to MouseUp event, also add point one to pointList
                {
                    initialCheckInt++;
                    pointList.Add(one);
                }


                pointList.Add(e.Location);                  // add point to pointList every time mouse moves.


                // use "g" to trace the lines that were being drawn.
                if (pointList.Count > 1)
                {
                    if (drawingTool == "pencil")
                    {
                        using (Pen myPen = new Pen(chosenColor, (float)pencilThicknessNumUpDown.Value))
                        {
                            g.DrawLines(myPen, pointList.ToArray());                                        // drawlines draws lines using giving Pen object between each point in the given array
                        }
                    }
                    else if (drawingTool == "brush")
                    {
                        using (Pen myPen = new Pen(new SolidBrush(chosenColor), (float)brushThicknessNumUpDown.Value))
                        {
                            g.DrawLines(myPen, pointList.ToArray());                                        // drawlines draws lines using giving Pen object between each point in the given array
                        }                                                                                   // this one is a brush
                    }
                    else if (drawingTool == "eraser")
                    {
                        using (Pen myPen = new Pen(new SolidBrush(Canvas.BackColor), 10.0f))
                        {
                            g.DrawLines(myPen, pointList.ToArray());                                        // drawlines draws lines using giving Pen object between each point in the given array
                        }                                                                                   // this one is a brush
                    }
                }
            }
        }




        /***********************************************************
        *                                                          *
        *  Method Name:  Canvas_MouseUp()                          *
        *                                                          *
        *  Parameters: an object called sender representing the    *
        *              clicked object and an MouseEventArgs object.*
        *                                                          *
        *  Purpose:  This method records the location at which     *
        *            the MouseUp event occurs and add each line    *
        *            with the necessary drawing tool to lineStack. *
        *            This method is an event handler.  Runs when   *
        *            MouseUp event occurs.                         *
        *                                                          *
        *  Return:  void, no return.                               *
        *                                                          *
        ************************************************************/
        private void Canvas_MouseUp(object sender, MouseEventArgs e)
        {

            if (initialCheckInt == 0 && one.X != 0 && one.Y != 0 && e.X == one.X && e.Y == one.Y)    // if user drew a single point/pixel, wont execute if mouse moved after MouseUp happened at a different location then MouseDown
            {
                if (drawingTool == "pencil")
                {

                    lineStack.Add(new Tuple<Pen, List<Point>>(new Pen(chosenColor, (float)pencilThicknessNumUpDown.Value), new List<Point>() {new Point(e.X, e.Y)} ));

                }
                else if (drawingTool == "brush")
                {

                    lineStack.Add(new Tuple<Pen, List<Point>>(new Pen(new SolidBrush(chosenColor), (float)brushThicknessNumUpDown.Value), new List<Point>() { new Point(e.X, e.Y) }));

                }
                else if (drawingTool == "eraser")
                {

                    lineStack.Add(new Tuple<Pen, List<Point>>(new Pen(new SolidBrush(Canvas.BackColor), 10.0f), new List<Point>() { new Point(e.X, e.Y) }));

                }
            } else
            {   // add pointList with necessary Pen object to lineStack for drawing  Using drawingTool string to determine which drawing tool/Pen to use
                if (drawingTool == "pencil")
                {
                    lineStack.Add(new Tuple<Pen, List<Point>>(new Pen(chosenColor, (float)pencilThicknessNumUpDown.Value), new List<Point>(pointList)));

                }
                else if (drawingTool == "brush")
                {
                    lineStack.Add(new Tuple<Pen, List<Point>>(new Pen(new SolidBrush(chosenColor), (float)brushThicknessNumUpDown.Value), new List<Point>(pointList)));

                }
                else if (drawingTool == "eraser")
                {

                    lineStack.Add(new Tuple<Pen, List<Point>>(new Pen(new SolidBrush(Canvas.BackColor), 10.0f), new List<Point>(pointList)));

                }
                else if(drawingTool == "line")
                {
                    lineStack.Add(new Tuple<Pen, List<Point>>(new Pen(chosenColor, (float)pencilThicknessNumUpDown.Value), new List<Point>() { one, e.Location} ));
                }
            }


            mouseHeld = false;      // setting mouseHeld to false in preparation of next mouseHeldDown movement
            initialCheckInt = 0;    // set initialCheckInt to 0 in preparation of next mouseHeldDown movement 

            Canvas.Refresh();       // refresh Canvas to draw new line added to lineStack along with all existing lines in lineStack
            
            pointList.Clear();      // clear pointList for next line to be recorded.
        }


        /***********************************************************
        *                                                          *
        *  Method Name:  colorSelect_Click()                       *
        *                                                          *
        *  Parameters: an object called sender representing the    *
        *              clicked object and an EventArgs object.     *
        *                                                          *
        *  Purpose:  This method detects a click in the color      *
        *            selection labels to react to color changes.   *
        *            This method is an event handler.  Runs when   *
        *            a color is selected from the given choices.   *
        *                                                          *
        *  Return:  void, no return.                               *
        *                                                          *
        ************************************************************/
        private void colorSelect_Click(object sender, EventArgs e)
        {
            Label label = sender as Label;
            chosenColor = label.BackColor;          // update the chosen color and the currentColor label that shows the current selected color.
            currentColor.BackColor = chosenColor;

            if(drawingTool == "eraser")
            {
                drawingTool = lastToolSelected;         // set drawing tool to last selected tool if user selected color while using the eraser.

                if (lastToolSelected == "pencil")           // set focus to last selected tool to show switch in tools
                    pencilButton.Focus();
                if (lastToolSelected == "brush")
                    brushButton.Focus();
                if (lastToolSelected == "line")
                    lineButton.Focus();
            }
        }


        /***********************************************************
        *                                                          *
        *  Method Name:  pencilButton_Click()                      *
        *                                                          *
        *  Parameters: an object called sender representing the    *
        *              clicked object and an EventArgs object.     *
        *                                                          *
        *  Purpose:  This method detects a click on pencilButton   *
        *            and sets drawingTool to pencil to show users  *
        *            change in drawing tools.                      *
        *                                                          *
        *  Return:  void, no return.                               *
        *                                                          *
        ************************************************************/
        private void pencilButton_Click(object sender, EventArgs e)
        {
            drawingTool = "pencil";
            lastToolSelected = drawingTool;
        }


        /***********************************************************
        *                                                          *
        *  Method Name:  brushButton_Click()                       *
        *                                                          *
        *  Parameters: an object called sender representing the    *
        *              clicked object and an EventArgs object.     *
        *                                                          *
        *  Purpose:  This method detects a click on brushButton    *
        *            and sets drawingTool to brush to show users   *
        *            change in drawing tools.                      *
        *                                                          *
        *  Return:  void, no return.                               *
        *                                                          *
        ************************************************************/
        private void brushButton_Click(object sender, EventArgs e)
        {
            drawingTool = "brush";
            lastToolSelected = drawingTool;
        }


        /***********************************************************
        *                                                          *
        *  Method Name:  eraserButton_Click()                      *
        *                                                          *
        *  Parameters: an object called sender representing the    *
        *              clicked object and an EventArgs object.     *
        *                                                          *
        *  Purpose:  This method detects a click on eraserButton   *
        *            and sets drawingTool to eraser to show users  *
        *            change in drawing tools.                      *
        *                                                          *
        *  Return:  void, no return.                               *
        *                                                          *
        ************************************************************/
        private void eraserButton_Click(object sender, EventArgs e)
        {
            lastToolSelected = drawingTool;
            drawingTool = "eraser";
        }


        /***********************************************************
        *                                                          *
        *  Method Name:  lineButton_Click()                        *
        *                                                          *
        *  Parameters: an object called sender representing the    *
        *              clicked object and an EventArgs object.     *
        *                                                          *
        *  Purpose:  This method detects a click on pencilButton   *
        *            and sets drawingTool to line to show users    *
        *            change in drawing tools.                      *
        *                                                          *
        *  Return:  void, no return.                               *
        *                                                          *
        ************************************************************/
        private void lineButton_Click(object sender, EventArgs e)
        {
            drawingTool = "line";
            lastToolSelected = drawingTool;
        }


        /***********************************************************
        *                                                          *
        *  Method Name:  undoToolStripMenuItem_Click()             *
        *                                                          *
        *  Parameters: an object called sender representing the    *
        *              clicked object and an EventArgs object.     *
        *                                                          *
        *  Purpose:  This method detects a click in the undo       *
        *            menustrip item to react to undo changes.      *
        *            This method is an event handler.  Runs when   *
        *            a user undoes a drawing/change.               *
        *                                                          *
        *  Return:  void, no return.                               *
        *                                                          *
        ************************************************************/
        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lineStack.Count == 1)          // if lineStack count is just one, put in undoStack and reset Canvas.Image and refresh the Canvas
            {
                undoStack.Push(lineStack[lineStack.Count - 1]);
                lineStack.RemoveAt(lineStack.Count - 1);
                Canvas.Image = null;
                Canvas.Refresh();
            }

            if (lineStack.Count > 0)            // if lineStack.Count is greater than 0, push the most recent change into the undoStack and refresh the Canvas
            {
                undoStack.Push(lineStack[lineStack.Count - 1]);
                lineStack.RemoveAt(lineStack.Count - 1);
                Canvas.Refresh();
            }
        }


        /***********************************************************
        *                                                          *
        *  Method Name:  redoToolStripMenuItem_Click()             *
        *                                                          *
        *  Parameters: an object called sender representing the    *
        *              clicked object and an EventArgs object.     *
        *                                                          *
        *  Purpose:  This method detects a click in the redo       *
        *            menustrip item to react to redo changes.      *
        *            This method is an event handler.  Runs when   *
        *            a user redoes a drawing/change.               *
        *                                                          *
        *  Return:  void, no return.                               *
        *                                                          *
        ************************************************************/
        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (undoStack.Count > 0)            // if undoStack.Count is greater than 0, add the popped line back into linesStack and refresh the canvas
            {
                lineStack.Add(undoStack.Pop());
                Canvas.Refresh();
            }
        }


        /***********************************************************
        *                                                          *
        *  Method Name:  saveAsToolStripMenuItem_Click()           *
        *                                                          *
        *  Parameters: an object called sender representing the    *
        *              clicked object and an EventArgs object.     *
        *                                                          *
        *  Purpose:  This method detects a click in the Save As    *
        *            menuitem to react to user wanting to save     *
        *            an image/png.                                 *
        *            This method is an event handler.  Runs when   *
        *            a user selects Save As.                       *
        *                                                          *
        *  Return:  void, no return.                               *
        *                                                          *
        ************************************************************/
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream myStream;            // declare a stream object for file

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())    // create SaveFileDialog
            {
                saveFileDialog.Filter = "Images|*.png";                     // set filter to png

                saveFileDialog.RestoreDirectory = true;                     // set restoredirectory to true to return to last directory when in the file explorer

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if ((myStream = saveFileDialog.OpenFile()) != null)     // file specified by user is assigned to myStream
                    {
                        // Code to write the stream goes here.
                        bitM.Save(myStream, ImageFormat.Png);               // use myStream to save bitM (bitmap) to a png file

                        if (myStream != null)
                        {
                            currentFilename = saveFileDialog.FileName;      // update currentfilename to saved filename
                        }

                        myStream.Close();                                   // close myStream
                    }
                }
            }


            // add currentFilename to recentlyOpenedList if criteria is met and make sure list does not exceed 5 entries
            if (currentFilename != null)
            {
                if (recentlyOpenedList.Contains(currentFilename))
                    recentlyOpenedList.Remove(currentFilename);

                recentlyOpenedList.Insert(0, currentFilename);

                while (recentlyOpenedList.Count > 5)
                {
                    recentlyOpenedList.RemoveAt(recentlyOpenedList.Count - 1);
                }
            }

        }


        /***********************************************************
        *                                                          *
        *  Method Name:  editColorsButton_Click()                  *
        *                                                          *
        *  Parameters: an object called sender representing the    *
        *              clicked object and an EventArgs object.     *
        *                                                          *
        *  Purpose:  This method detects a click in the editColor  *
        *            button to react to a user wanting to change   *
        *            to a custom color of their choosing.          *
        *            This method is an event handler.  Runs when   *
        *            a user selects editColorButton.               *
        *                                                          *
        *  Return:  void, no return.                               *
        *                                                          *
        ************************************************************/
        private void editColorsButton_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();            // create ColorDialog

            colorDialog.AllowFullOpen = true;                       // allow full custom color selection
            colorDialog.ShowHelp = true;                            // allow help button
            colorDialog.Color = chosenColor;                        // preselect the chosenColor as the default color in the color selector

            if (colorDialog.ShowDialog() == DialogResult.OK)
                chosenColor = colorDialog.Color;                    // assign color chosen from picker to chosenColor

            if (drawingTool == "eraser")
            {
                drawingTool = lastToolSelected;         // set drawing tool to last selected tool if user selected color while using the eraser.

                if (lastToolSelected == "pencil")           // set focus to last selected tool to show switch in tools
                    pencilButton.Focus();
                if (lastToolSelected == "brush")
                    brushButton.Focus();
                if (lastToolSelected == "line")
                    lineButton.Focus();
            }
        }


        /***********************************************************
        *                                                          *
        *  Method Name:  Form1_KeyDown()                           *
        *                                                          *
        *  Parameters: an object called sender representing the    *
        *              clicked object and an KeyEventArgs object.  *
        *                                                          *
        *  Purpose:  This method detects keyboard shortcuts such   *
        *            as ctrl+z for undo and ctrl+x for redo.       *
        *            This method is an event handler.  Runs when   *
        *            a user selects Save As.                       *
        *                                                          *
        *  Return:  void, no return.                               *
        *                                                          *
        ************************************************************/
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Control && e.KeyCode == Keys.Z)    // undo shortcut
            {
                if (lineStack.Count == 1)                           // if lineStack count is just one, put in undoStack and reset Canvas.Image and refresh the Canvas
                {
                    undoStack.Push(lineStack[lineStack.Count - 1]);
                    lineStack.RemoveAt(lineStack.Count - 1);
                    Canvas.Image = null;
                    Canvas.Refresh();
                }

                if (lineStack.Count > 0)                            // if lineStack.Count is greater than 0, push the most recent change into the undoStack and refresh the Canvas
                {
                    undoStack.Push(lineStack[lineStack.Count - 1]);
                    lineStack.RemoveAt(lineStack.Count - 1);
                    Canvas.Refresh();
                }
            } else if (e.Control && e.KeyCode == Keys.X)    // redo shortcut
            {
                if (undoStack.Count > 0)
                {
                    lineStack.Add(undoStack.Pop());
                    Canvas.Refresh();
                }
            }
        }


        /***********************************************************
        *                                                          *
        *  Method Name:  newToolStripMenuItem_Click()              *
        *                                                          *
        *  Parameters: an object called sender representing the    *
        *              clicked object and an EventArgs object.     *
        *                                                          *
        *  Purpose:  This method detects a click in the New        *
        *            menuitem to react to user wanting to create   *
        *            an new drawing.                               *
        *            This method is an event handler.  Runs when   *
        *            a user selects New.                           *
        *                                                          *
        *  Return:  void, no return.                               *
        *                                                          *
        ************************************************************/
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

            // prompt user to save the file if lineStack.Count is greater than 0
            if(lineStack.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to save changes to " + (currentFilename != null ? currentFilename : "untitled"), "Paint", MessageBoxButtons.YesNoCancel);

                if (dialogResult == DialogResult.Yes)
                {
                    save();
                } else if (dialogResult == DialogResult.Cancel)
                {
                    return;
                }
            }

            // reset necessary variables for new drawing
            Canvas.Image = null;
            lineStack.Clear();
            pointList.Clear();
            chosenColor = Color.Black;
            drawingTool = "pencil";
            lastToolSelected = "pencil";
            currentFilename = null;
            openBitMInt = 0;
        }


        /***********************************************************
        *                                                          *
        *  Method Name:  openToolStripMenuItem_Click()             *
        *                                                          *
        *  Parameters: an object called sender representing the    *
        *              clicked object and an EventArgs object.     *
        *                                                          *
        *  Purpose:  This method detects a click in the Open       *
        *            menuitem to react to user wanting to open     *
        *            an image/png.                                 *
        *            This method is an event handler.  Runs when   *
        *            a user selects Open.                          *
        *                                                          *
        *  Return:  void, no return.                               *
        *                                                          *
        ************************************************************/
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog openFileDialog = new OpenFileDialog())         // create open file dialog
            {
                openFileDialog.InitialDirectory = "c:\\";                   // open default location is the root C drive
                openFileDialog.Filter = "Images|*.png";                     // set filter to png
                openFileDialog.RestoreDirectory = true;



                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    openBitMInt = 0;

                    using (Bitmap temp = new Bitmap(openFileDialog.FileName))
                    {
                        openBitM = new Bitmap(temp);                            // load png into a bitmap to be loaded into the Canvas picture box
                    }

                    currentFilename = openFileDialog.FileName;                  // set currentFilename since the file already exists or it wont be able to opened



                    // add currentFilename to recentlyOpenedList if criteria is met and make sure list does not exceed 5 entries
                    if (currentFilename != null)
                    {
                        if (recentlyOpenedList.Contains(currentFilename))
                            recentlyOpenedList.Remove(currentFilename);

                        recentlyOpenedList.Insert(0, currentFilename);

                        while (recentlyOpenedList.Count > 5)
                        {
                            recentlyOpenedList.RemoveAt(recentlyOpenedList.Count - 1);
                        }
                    }


                    // reset necessary variables to prepare for opening of a png file
                    Canvas.Image = null;
                    lineStack.Clear();
                    pointList.Clear();
                    chosenColor = Color.Black;
                    drawingTool = "pencil";
                    lastToolSelected = "pencil";
                    openBitMInt++;
                }
            }

            // refresh Canvas to show the new opened png image/bitmap
            Canvas.Refresh();
        }


        /***********************************************************
        *                                                          *
        *  Method Name:  saveToolStripMenuItem_Click()             *
        *                                                          *
        *  Parameters: an object called sender representing the    *
        *              clicked object and an EventArgs object.     *
        *                                                          *
        *  Purpose:  This method just calls the save method        *
        *            This method is an event handler.  Runs when   *
        *            a user selects Save.                          *
        *                                                          *
        *  Return:  void, no return.                               *
        *                                                          *
        ************************************************************/
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            save();
        }


        /***********************************************************
        *                                                          *
        *  Method Name:  save()                                    *
        *                                                          *
        *  Parameters: no parameters                               *
        *                                                          *
        *  Purpose:  This method checks if there is a              *
        *            currentFilename set and saves to it if there  *
        *            is otherwise prompts user with the            *
        *            SaveFileDialog to create a file to save.      *
        *            This method is part of an event handler.      *
        *            Runs when a user selects Save which calls     *
        *            saveToolStripMenuItem_Click.                  *
        *                                                          *
        *  Return:  void, no return.                               *
        *                                                          *
        ************************************************************/
        private void save()
        {
            if (currentFilename == null)            // make user save as if no file already exists (if currentFilename is equal to null)
            {
                Stream myStream;

                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Images|*.png";     // set filter/ save option to png

                    saveFileDialog.RestoreDirectory = true;

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        if ((myStream = saveFileDialog.OpenFile()) != null)
                        {
                            // Code to write the stream goes here.
                            bitM.Save(myStream, ImageFormat.Png);       // save bitmap to a png at fileame specified in myStream

                            if (myStream != null)
                            {
                                currentFilename = saveFileDialog.FileName;      // update currentFilename with new name of saved file
                            }

                            myStream.Close();
                        }
                    }
                }

            }
            else
            {
                bitM.Save(currentFilename, ImageFormat.Png);                            // simply save to existing file/pathname if currentFilename is not null
            }


            // add currentFilename to recentlyOpenedList if criteria is met and make sure list does not exceed 5 entries
            if (currentFilename != null)
            {
                if (recentlyOpenedList.Contains(currentFilename))
                    recentlyOpenedList.Remove(currentFilename);

                recentlyOpenedList.Insert(0, currentFilename);

                while (recentlyOpenedList.Count > 5)
                {
                    recentlyOpenedList.RemoveAt(recentlyOpenedList.Count - 1);
                }
            }
        }


        /***********************************************************
        *                                                          *
        *  Method Name:  OnClosing()                               *
        *                                                          *
        *  Parameters: a CancelEventArgs e                         *
        *                                                          *
        *  Purpose:  This method is an overridden method that runs *
        *            when the program is about to close,           *
        *            specifically when the user X's out of the     *
        *            program.  Before the program ends the         *
        *            recentlyopened.txt file is updated with the   *
        *            most recent opened or saved files.            *
        *            This method is an event handler.  Runs when   *
        *            a user selects closes or X's out of the       *
        *            program.                                      *
        *                                                          *
        *  Return:  void, no return.                               *
        *                                                          *
        ************************************************************/
        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            StreamWriter recentlyOpenedWrite;               // create streamwriter

            try
            {
                recentlyOpenedWrite = new System.IO.StreamWriter("..\\..\\..\\recentlyopened.txt"); // intiailize streamwriter with path, this constructor overwrites all existing data in the file
            }
            catch (Exception)
            {
                Console.WriteLine("Error: \"recentlyopened.txt\" file was not found or could not be opened for writing in override void OnClosing.");
                return;
            }

            int i = 0;

            // add/write at most 5 filenames/lines of the most recent opened and saved files to the recentlyopened.txt file
            if (recentlyOpenedList.Count > 0)
            {
                foreach (string fileName in recentlyOpenedList)
                {
                    if(i < 5)
                    {
                        recentlyOpenedWrite.WriteLine(fileName);
                        i++;
                    }
                }
            }

            // flush streamwriter or streamwriter wont write to the file
            recentlyOpenedWrite.Flush();

            // call the base OnClosing function to complete the program closing.
            base.OnClosing(e);
        }

    }
}
