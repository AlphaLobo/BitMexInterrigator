using BitMexInterrigator.BitMex.Classes;
using BitMexInterrigator.BitMex.Controllers;
using BitMexInterrogator.BitMex.Controllers;

namespace BitMexInterrigator
{
    public partial class InstrumentForm : Form
    {
        private InstrumentManager instrumentManager = new InstrumentManager();
        private UIDoodads UIDoodads;

        public DataGridView DgInstruments
        {
            get { return dgInstruments; }
        }

        public GroupBox GroupBoxColumnSelections
        {
            get { return groupBoxColumnSelections; }
        }
        public InstrumentForm()
        {
            InitializeComponent();         
            UIDoodads = new UIDoodads(this); // Pass the controls here
            InitializeColumnSelections();
        }

        
        private async void btnGetTradeableInstruments_Click(object sender, EventArgs e)
        {
            List<Instrument>? instruments = new List<Instrument>();
            instruments = await instrumentManager.getTradeableInstrumentsAsync();

            dgInstruments.DataSource= instruments;

        }

        private void InitializeColumnSelections()
        {
            // Get the properties of the Instrument class
            var instrumentProperties = typeof(Instrument).GetProperties();

            // Populate the UI with column selection options
            foreach (var property in instrumentProperties)
            {
                // Add checkboxes for each property to the groupBoxColumnSelections
                UIDoodads.AddColumnSelectionOption(property.Name);
            }

            // Add the groupBoxColumnSelections to the form's controls
           // this.Controls.Add(UIDoodads.groupBoxColumnSelections);
        }    

    }
}