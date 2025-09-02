
// Amir Moeini Rad
// September 2025

// Main Concept: Separate Main Method from Form Class

using System.Windows.Forms;
using System.Drawing;

namespace SeparateMainDemo
{
    class MainApp
    {
        public static void Main()
        {
            // Run the application with an instance of the HelloWorld form.
            Application.Run(new HelloWorld());
        }
    }

    
    ///////////////////////////////////////////
    

    class HelloWorld : Form
    {
        // Constructor
        public HelloWorld()
        {
            // Form's title and background color.
            Text = "Hello, World!";
            BackColor = Color.White;
        }


        // A metod inherited from the Form class.
        // This method is called when the form needs to be repainted.
        // This method is an event handler for the Paint event.
        protected override void OnPaint(PaintEventArgs e)
        {
            //base.OnPaint(e);


            // The 'Graphics' class provides methods to draw on the form.
            Graphics grfx = e.Graphics;
            // Draw a string at the specified location (0,0).
            grfx.DrawString("Hello, Windows Forms!", Font, Brushes.Black, 0, 0);


            // Show a message box
            // Every time the form is repainted, this message box will appear.
            MessageBox.Show("OnPaint Method", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}