using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace DunkinDonuts
{
	[TestFixture(Platform.Android)]
	[TestFixture(Platform.iOS)]
	public class Tests
	{
		IApp app;
		Platform platform;

		public Tests(Platform platform)
		{
			this.platform = platform;
		}

		[SetUp]
		public void BeforeEachTest()
		{
			app = AppInitializer.StartApp(platform);
			app.Screenshot("App Launched");
		}

		[Test]
		public void Repl()
		{
			app.Repl();
		}

		[Test]
		public void FirstTest()
		{
			app.Tap("ACCEPT");
			app.Screenshot("Let's start by Tapping on the TOS");

			app.Tap("SKIP");
			app.Screenshot("We Tapped on the 'Skip' Button");
			app.Tap("MAYBE LATER");
			app.Screenshot("Then we Tapped on the 'Maybe Later' Button");

			app.Tap("leftImage");
			app.Screenshot("Then we Tapped on the 'Hamburger' Icon");

			app.Tap("Menu & Nutrition");
			app.Screenshot("We Tapped on the 'Menu & Nutrition' Button");
			app.Tap("Donuts & Bagels");
			app.Screenshot("Then we Tapped on the 'Donuts & Bagels' Button");
			app.Tap("Donuts");
			app.Screenshot("Next, we Tapped on the 'Donuts' Button");
			app.Tap("plus");
			app.Screenshot("Then we Added the 'Surprise Me' Donut to 1");
			app.Tap("NUTRITION");
			app.Screenshot("We Tapped on the 'Nutrition' Tab");

			app.Tap("leftImage");
			app.Screenshot("Then we Tapped on the 'Hamburger' Icon");
			app.Tap("Home");
			app.Screenshot("Next we Tapped on the 'Home' Button");

			app.Tap("onTheGoButton");
			app.Screenshot("Then we Tapped on the 'On-The-Go' Button");
		}

	}
}
