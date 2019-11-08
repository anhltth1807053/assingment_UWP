using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using UWP_Demo.CS;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace UWP_Demo.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MenuDemo : Page
    {
        private List<Student> listStudents;
        public MenuDemo()
        {
           
            listStudents = new List<Student>();
            listStudents.Add(new Student
            {
                rollNumber = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcSMOwSqdsnaJxTAqA4E5rT0IJ1JzXiDfQRmNLqgW4cLwBFfKzyD",
                name = "Hung"
            });
            this.InitializeComponent();
        }

    }
}
