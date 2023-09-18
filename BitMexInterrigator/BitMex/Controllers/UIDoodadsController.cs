using BitMexInterrigator;
using System.Diagnostics.Metrics;

namespace BitMexInterrogator.BitMex.Controllers
{
    public class UIDoodadsController
    {
        private List<string> selectedColumns = new List<string>();
        public InstrumentForm instrumentForm;

        public UIDoodadsController(InstrumentForm instrumentForm)
        {
            this.instrumentForm = instrumentForm;
        }

        public string[] getColumnSelections()
        {
            var instrumentProperties = typeof(Instrument).GetProperties();
            var propertyNames = instrumentProperties.Select(property => property.Name).ToArray();
            return propertyNames;
        }

        int rowCount = 0;
        int colCount = 0;
        const int checkBoxWidth = 150;
        const int checkBoxHeight = 20;
        const int horizontalSpacing = 10;
        const int verticalSpacing = 5;
        public void AddColumnSelectionOption(string columnName)
        {
            CheckBox checkBox = new CheckBox
            {
                Text = columnName,
                Name = $"checkBox{columnName}",
                Tag = columnName,
                Checked = true,
                Width = checkBoxWidth,
                Height = checkBoxHeight,
                AutoSize = false
            };

            selectedColumns.Add(columnName);

            int x = colCount * (checkBoxWidth + horizontalSpacing) + 10;
            int y = rowCount * (checkBoxHeight + verticalSpacing) + 10;

            checkBox.Location = new Point(x, y);

            colCount++;
            if (colCount >= 11)
            {
                colCount = 0;
                rowCount++;
            }

            checkBox.CheckedChanged += ColumnSelectionOption_CheckedChanged;

            instrumentForm.GroupBoxColumnSelections.Controls.Add(checkBox);
        }

        private void ColumnSelectionOption_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            string columnName = checkBox.Tag.ToString();

            if (checkBox.Checked)
            {
                selectedColumns.Add(columnName);
            }
            else
            {
                selectedColumns.Remove(columnName);
            }

            UpdateListViewColumns();
        }

        private void UpdateListViewColumns()
        {
            var columns = instrumentForm.DgInstruments.Columns.Cast<DataGridViewColumn>().ToList();

            foreach (var column in columns)
            {
                column.Visible = true;
            }

            foreach (var column in columns)
            {
                if (!selectedColumns.Contains(column.HeaderText))
                {
                    column.Visible = false;
                }
            }
        }
    }
}
