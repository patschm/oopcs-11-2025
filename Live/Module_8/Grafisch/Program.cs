
namespace Grafisch;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {

        Form f1 = new Form();
        f1.Text = "Hello Form";
        f1.Width = 400;
        f1.Height = 300;

        Button b1 = new Button();
        b1.Text = "Click me!";
        b1.Location = new Point(100, 100);

        b1.Click += DoClick;

        f1.Controls.Add(b1);

        f1.ShowDialog();

        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        //ApplicationConfiguration.Initialize();
        //Application.Run(new Form1());
    }

    static void DoClick(object? sender, EventArgs e)
    {
        Button? b = sender as Button;
        if (b != null && b.Parent != null)
           b.Parent.BackColor = Color.Red;
    }
}