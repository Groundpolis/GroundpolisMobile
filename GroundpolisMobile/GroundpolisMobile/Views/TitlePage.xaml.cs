﻿using GroundpolisMobile.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GroundpolisMobile.Views
{
	public partial class TitlePage
	{
		public TitlePage()
		{
			InitializeComponent();
			BindingContext = new TitlePageViewModel();
		}
	}
}