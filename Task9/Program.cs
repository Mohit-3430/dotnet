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
        Application.SetHighDpiMode(HighDpiMode.SystemAware);
        Application.EnableVisualStyles();
        Application.Run(new MyForm());
    }
}

