using System;
using System.Collections.Generic;
using System.Linq;

using iFactr.UI;
using iFactr.UI.Controls;
using MonoCross.Utilities;

namespace Airplane.Views
{
    // TODO: Change the generic type to the type of your model.
    class MyGridView : GridView<string>
    {
        /// <summary>
        /// Called when the view is ready to be rendered.
        /// </summary>
        protected override void OnRender()
        {
            Thickness margin = new Thickness(5, 8);
            Title = "GridView";
            Columns.Add(Column.AutoSized);
            Columns.Add(Column.AutoSized);
            AddChild(new Label()
            {
                Text = "Airplane Selector",
                ColumnSpan = 2,
                TextAlignment = TextAlignment.Center,
                Margin = new Thickness(10),
            });
            AddChild(new Label("Freighters Only")
            {
                Margin = margin,
            }); // { BackgroundColor = Color.Purple, ForegroundColor = Color.Orange, });
            AddChild(new Switch(false)
            {
                SubmitKey = "Freighters",
                Margin = margin,
            });
            //AddChild(new Label("Futurific")
            //{
            //    Margin = margin,
            //});
            //AddChild(new Switch(false)
            //{
            //    SubmitKey = "Future",
            //    Margin = margin,
            //});
            AddChild(new Label("A 1-to-10 Slider:")
            {
                Margin = margin,
            });
            AddChild(new Slider(1, 10)
            {
                ColumnSpan = 2,
                Margin = margin,
            });
            var navButton = new Button("Show List")
            {
                ColumnSpan = 2,
                HorizontalAlignment = HorizontalAlignment.Stretch,
                Margin = margin,
            };
            navButton.Clicked += (o, e) =>
            {
                Submit("ListView");
            };
            navButton.Clicked += NavButton_Clicked;
            AddChild(navButton);
        }

        private void NavButton_Clicked(object sender, EventArgs e)
        {
            Device.Log.Debug("2nd Clicked Handler reached");
        }
    }
}
