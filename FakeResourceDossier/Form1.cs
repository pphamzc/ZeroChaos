using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZeroChaos.Service.Services;
using ZeroChaos.Business.Entities;

namespace FakeResourceDossier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ResourceEducationService service = new ResourceEducationService();

            ResourceEducationLanguageResponse moo = service.GetResourceEducationLanguageResponseByResourceID(10);

            ResourceService se = new ResourceService();

            se.GetResourceDossierResponseByResourceID(1);
            se.GetResourcePersonalInformationResponseByResourceID(1);
            se.GetResourceProjectReviewResponseByResourceID(1);
            se.GetResourceRequisitionSubmissionResponseByResourceID(1);
            se.GetResourceResumeAttachmentResponseByResourceID(1);

            ResourcePersonalInformationResponse rsp = new ResourcePersonalInformationResponse();

        }
    }
}
