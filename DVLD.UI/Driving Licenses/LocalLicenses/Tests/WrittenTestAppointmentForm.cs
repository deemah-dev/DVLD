namespace DVLD.UI
{
    public partial class WrittenTestAppointmentForm : BaseForm
    {
        public WrittenTestAppointmentForm(int lDLApplicationID)
        {
            InitializeComponent();
            ctrlTestAppoinment1.Load(lDLApplicationID);
        }
    }
}
