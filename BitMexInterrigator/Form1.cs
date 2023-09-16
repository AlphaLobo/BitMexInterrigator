using BitMexInterrigator.BitMex.Classes;
using BitMexInterrigator.BitMex.Controllers;
using BitMexInterrogator.BitMex.Controllers;

namespace BitMexInterrigator
{
    public partial class Form1 : Form
    {
        private InstrumentManager instrumentManager = new InstrumentManager();
        private List<string> selectedColumns = new List<string>();
        private UIDoodads UIDoodads= new UIDoodads();
        public Form1()
        {
            InitializeComponent();         
            InitializeColumnSelections();
        }

        private void UpdateListViewColumns()
        {
            // Clear existing columns
            lvInstruments.Columns.Clear();

            // Add columns based on the selected columns
            foreach (var columnName in selectedColumns)
            {
                lvInstruments.Columns.Add(columnName);
            }
        }
        private async void btnGetTradeableInstruments_Click(object sender, EventArgs e)
        {
            List<Instrument>? instruments = new List<Instrument>();
            instruments = await instrumentManager.getTradeableInstrumentsAsync();



            foreach (Instrument instrument in instruments)
            {
                if(instrument.state.ToLower() == "open")
                {
                    

                    //lvItem.SubItems.Add(instrument.symbol);
                    //lvItem.SubItems.Add(instrument.state);

                   // lvInstruments.Items.Add(lvItem);
                }
            }
        }

        private void InitializeColumnSelections()
        {
            // Get the properties of the Instrument class
            var instrumentProperties = typeof(Instrument).GetProperties();

            // Populate the UI with column selection options
            foreach (var property in instrumentProperties)
            {
                // Add checkboxes or other UI elements for each property
                // Allow users to select which columns to display
                AddColumnSelectionOption(property.Name);
            }
        }

        private void InitializeColumnExpectedData()
        {
            // Get the properties of the Instrument class
            List<string> instrumentPropertyList = UIDoodads.getColumnSelections().ToList();

            foreach (string propertyName in instrumentPropertyList)
            {
                ListViewItem lvItem = new ListViewItem(new[] { propertyName });
                lvInstruments.Items.Add(lvItem);
            }


        }

        private int rowCount = 0; // Initialize the row count
        private int colCount = 0; // Initialize the column count
        private const int checkBoxWidth = 150; // Width of each checkbox
        private const int checkBoxHeight = 20; // Height of each checkbox
        private const int horizontalSpacing = 10; // Horizontal spacing between checkboxes
        private const int verticalSpacing = 5; // Vertical spacing between checkboxes

        private void AddColumnSelectionOption(string columnName)
        {
            // Create a new checkbox for the column selection option
            CheckBox checkBox = new CheckBox
            {
                Text = columnName,
                Name = $"checkBox{columnName}", // Unique name for each checkbox
                Tag = columnName, // Store the column name in the Tag property for easy retrieval
                Checked = true, // You can set the default state here
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

    }
}