namespace DVLD.UI
{
    public partial class StreetTestAppointmentForm : BaseForm
    {
        public StreetTestAppointmentForm(int lDLApplicationID)
        {
            InitializeComponent();
            ctrlTestAppoinment1.Load(lDLApplicationID);
        }
    }
}
