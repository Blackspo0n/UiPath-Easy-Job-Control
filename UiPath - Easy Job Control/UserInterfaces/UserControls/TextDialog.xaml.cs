﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace UiPathEJC.UserInterfaces.UserControls
{
    /// <summary>
    /// Interaktionslogik für WaitingDialog.xaml
    /// </summary>
    public partial class TextDialog : UserControl
    {
        public TextDialog(string message)
        {
            InitializeComponent();
            Message.Text = message;
        }
    }
}
