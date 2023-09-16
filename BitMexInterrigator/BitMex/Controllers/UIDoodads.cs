using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitMexInterrogator.BitMex.Controllers
{
    public class UIDoodads
    {
        private List<string> selectedColumns = new List<string>();
        public GroupBox groupBoxColumnSelections;
        private DataGridView _dgInstruments; // Add a reference to the ListView

        public UIDoodads(GroupBox groupBox, DataGridView dgInstruments)
        {
            groupBoxColumnSelections = groupBox;
            _dgInstruments = dgInstruments;
        }

        public string[] getColumnSelections()
        {
            // Get the properties of the Instrument class
            var instrumentProperties = typeof(Instrument).GetProperties();

            // Extract the property names as an array of strings
            var propertyNames = instrumentProperties.Select(property => property.Name).ToArray();

            return propertyNames;
        }

        int rowCount = 0; // Initialize the row count
        int colCount = 0; // Initialize the column count
        const int checkBoxWidth = 150; // Width of each checkbox
        const int checkBoxHeight = 20; // Height of each checkbox
        const int horizontalSpacing = 10; // Horizontal spacing between checkboxes
        const int verticalSpacing = 5; // Vertical spacing between checkboxes
        public void AddColumnSelectionOption(string columnName)
        {


            // Create a new checkbox for the column selection option
            CheckBox checkBox = new CheckBox
            {
                Text = columnName,
                Name = $"checkBox{columnName}", // Unique name for each checkbox
                Tag = columnName, // Store the column name in the Tag property for easy retrieval
                Checked = false, // You can set the default state here
                Width = checkBoxWidth, // Set the width of each checkbox
                Height = checkBoxHeight, // Set the height of each checkbox
                AutoSize = false // Disable auto-sizing
            };

            // Calculate the X and Y position for the checkbox in the grid
            int x = colCount * (checkBoxWidth + horizontalSpacing) + 10; // 10 is the starting X position
            int y = rowCount * (checkBoxHeight + verticalSpacing) + 10; // 10 is the starting Y position

            // Set the location for the checkbox
            checkBox.Location = new Point(x, y);

            // Increment the column count and reset it when it reaches a certain limit
            colCount++;
            if (colCount >= 3) // Adjust the number of columns as needed
            {
                colCount = 0;
                rowCount++;
            }

            // Add an event handler to handle changes in checkbox state
            checkBox.CheckedChanged += ColumnSelectionOption_CheckedChanged;

            // Add the checkbox to the group box
            groupBoxColumnSelections.Controls.Add(checkBox);
        }

        private void ColumnSelectionOption_CheckedChanged(object sender, EventArgs e)
        {
            // Get the checkbox that triggered the event
            CheckBox checkBox = (CheckBox)sender;

            // Retrieve the associated column name from the Tag property
            string columnName = checkBox.Tag.ToString();

            // Handle the checkbox state change, e.g., update selectedColumns list
            if (checkBox.Checked)
            {
                // Add the column name to the selectedColumns list
                selectedColumns.Add(columnName);
            }
            else
            {
                // Remove the column name from the selectedColumns list
                selectedColumns.Remove(columnName);
            }

            // Update the ListView based on the selected columns
            UpdateListViewColumns();
        }

        private void UpdateListViewColumns()
        {
            // Clear existing columns
            _dgInstruments.Columns.Clear();

            // Add columns based on the selected columns
            foreach (var columnName in selectedColumns)
            {
                _dgInstruments.Columns.Add(columnName, columnName);
            }
        }

    }
}
