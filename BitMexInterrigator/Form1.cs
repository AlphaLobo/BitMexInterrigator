using BitMexInterrigator.BitMex.Classes;
using BitMexInterrigator.BitMex.Controllers;
using BitMexInterrogator.BitMex.Controllers;

namespace BitMexInterrigator
{
    public partial class Form1 : Form
    {
        private InstrumentManager instrumentManager = new InstrumentManager();
        private UIDoodads UIDoodads;
        public Form1()
        {
            InitializeComponent();         
            UIDoodads = new UIDoodads(groupBoxColumnSelections, lvInstruments); // Pass the controls here
            InitializeColumnSelections();
        }

        
        private async void btnGetTradeableInstruments_Click(object sender, EventArgs e)
        {
            List<Instrument>? instruments = new List<Instrument>();
            instruments = await instrumentManager.getTradeableInstrumentsAsync();




            foreach (Instrument instrument in instruments)
            {
                if(instrument.state.ToLower() == "open")
                {


                    lvItem.SubItems.Add(instrument.symbol);
                    lvItem.SubItems.Add(instrument.state);

                    //  lvInstruments.Items.Add(lvItem);
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
                // Add checkboxes for each property to the groupBoxColumnSelections
                UIDoodads.AddColumnSelectionOption(property.Name);
            }

            // Add the groupBoxColumnSelections to the form's controls
            this.Controls.Add(UIDoodads.groupBoxColumnSelections);
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

        

    }
}