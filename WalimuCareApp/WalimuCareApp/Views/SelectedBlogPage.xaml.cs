﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WalimuCareApp.CustomRenderer;
using WalimuCareApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WalimuCareApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SelectedBlogPage : CustomContentPageRenderer
    {
        public SelectedBlogPage()
        {
            InitializeComponent();

            BindingContext = DependencyService.Get<WellnessBlogViewModel>();
        }
    }
}