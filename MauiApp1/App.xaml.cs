﻿using MauiApp1.Views;

namespace MauiApp1;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new ClassroomPage(); //AppShell();
	}
}
