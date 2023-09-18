using BitMexInterrigator.BitMex.Classes;
using BitMexInterrigator.BitMex.Controllers;
using BitMexInterrogator.BitMex.Controllers;

namespace BitMexInterrigator
{
    public partial class InstrumentForm : Form
    {
        private InstrumentManagerController instrumentManager = new InstrumentManagerController();
        private UIDoodadsController UIDoodads;

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
            UIDoodads = new UIDoodadsController(this);
            InitializeColumnSelections();
        }
        
        private async void btnGetTradeableInstruments_Click(object sender, EventArgs e)
        {
            List<Instrument>? instruments = new List<Instrument>();
            instruments = await instrumentManager.GetTradeableInstruments();
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