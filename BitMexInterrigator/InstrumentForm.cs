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
            UIDoodads = new UIDoodads(this);
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
            var instrumentProperties = typeof(Instrument).GetProperties();

            foreach (var property in instrumentProperties)
            {
                UIDoodads.AddColumnSelectionOption(property.Name);
            }
        }    

    }
}