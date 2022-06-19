using System;
using System.Windows.Forms;

public class MyForm : Form
{
    public MyForm()
    {
        InitComponents();
    }
    private void InitComponents()
    {
        ColorDialog dlg = new ColorDialog();
        dlg.ShowDialog();
    }
    static void Main()
    {
        // SystemAware	1	The window queries for the DPI of the primary monitor once and uses this for the application on all monitors.
        Application.SetHighDpiMode(HighDpiMode.SystemAware);
        //  Visual styles are the colors, fonts, and other visual elements that form an operating system theme. 
        Application.EnableVisualStyles();
        // Begins running a standard application message loop on the current thread.
        Application.Run(new MyForm());
    }
}

