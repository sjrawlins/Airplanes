using System.Collections.Generic;
using Airplane.Models;
using iFactr.UI;
using iFactr.UI.Controls;

namespace Airplane.Views
{
    class MyListView : ListView<List<Aircraft>>
    {
        /// <summary>
        /// Called when the view is ready to be rendered.
        /// </summary>
        protected override void OnRender()
        {
            Title = "ListView<Aircraft>";
            Sections[0].ItemCount = Model.Count;
        }

        /// <summary>
        /// Called when a cell is ready to be rendered on the screen.  Return the ICell instance
        /// that should be placed at the given index within the given section.
        /// </summary>
        /// <param name="section">The section that will contain the cell.</param>
        /// <param name="index">The index at which the cell will be placed in the section.</param>
        /// <param name="recycledCell">An already instantiated cell that is ready for reuse, or null if no cell has been recycled.</param>
        protected override ICell OnCellRequested(int section, int index, ICell recycledCell)
        {
            // On platforms that support cell recycling (Android and iOS), recycledCell is passed-in, otherwise is null.
            // In any case, a cell must be returned.
            AircraftCell cell = recycledCell as AircraftCell;
            if (cell == null)
            {
                cell = new AircraftCell();
            }

            // Having obtained a cell, now set its public properties; these are the value which CHANGE from cell to cell
            cell.Index.Text = "[" + index.ToString() + "] ";
            cell.Maker.Text = Model[index].Maker.ToString();  // from enum to string
            cell.Model.Text = Model[index].Model;
            cell.Capacity.Text =  "(Holds " + Model[index].Capacity.ToString() + " PAX)"; // from int to string

            return cell;
        }

        /// <summary>
        /// Called when a reuse identifier is needed for a cell or tile.  Return the identifier that should be used
        /// to determine which cells or tiles may be reused for the item at the given index within the given section.
        /// This is only called on platforms that support recycling.  See Remarks for details.
        /// </summary>
        /// <param name="section">The section that will contain the item.</param>
        /// <param name="index">The index at which the item will be placed in the section.</param>
        protected override int OnItemIdRequested(int section, int index)
        {
            return 0;
        }
    }

    class AircraftCell : GridCell
    {
        public Label Index;
        public Label Maker;
        public Label Model;
        public Label Capacity;

        Thickness margin = new Thickness(2, 8);

        public AircraftCell()
        {
            Columns.Add(Column.AutoSized);
            Columns.Add(Column.AutoSized);
            Columns.Add(Column.AutoSized);
            Columns.Add(new Column(4, LayoutUnitType.Star));

            Index = new Label() {
                Margin = margin,
                HorizontalAlignment = HorizontalAlignment.Right,
            };
            AddChild(Index);

            Maker = new Label() { Margin = margin, };
            AddChild(Maker);

            Model = new Label() { Margin = margin, };
            AddChild(Model);

            //AddChild(new Label("Holds") { Margin = margin, });
            Capacity = new Label() { Margin = margin, };
            AddChild(Capacity);
        }

    }
}
