namespace DVLD.UI
{
    public partial class VisionTestAppointmentForm : BaseForm
    {
        public VisionTestAppointmentForm(int lDLApplicationID)
        {
            InitializeComponent();
            ctrlTestAppoinment1.Load(lDLApplicationID);
        }
    }
}
