﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XF_MicunaFood.Views.ShellTemplates
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FlyoutMenuItemTemplate : Grid
    {
        public FlyoutMenuItemTemplate()
        {
            InitializeComponent();
        }
    }
}