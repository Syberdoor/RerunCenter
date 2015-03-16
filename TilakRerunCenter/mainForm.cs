using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RerunCenter {

    
    public partial class frmMain : Form {

        
        string fakeDetectionMethod = "<LocalDetectionMethod><Settings><File></File></Settings><Rule xmlns=\"http://schemas.microsoft.com/SystemsCenterConfigurationManager/2009/06/14/Rules\"><Expression><Operator>Equals</Operator><Operands><SettingReference AuthoringScopeId=\"\" DataType=\"Version\" SettingLogicalName=\"X\" Method=\"Value\"/><ConstantValue DataType=\"Version\"/></Operands></Expression></Rule></LocalDetectionMethod>";

        public frmMain() {
            InitializeComponent();
        }

        public void getApplicationDeliveryTypes() {
            gwApplications.Rows.Clear();
            using (ManagementClass mc = new ManagementClass(@"\\" + txtbxComputer.Text + @"\root\ccm\CIModels", "CCM_AppDeliveryTypeSynclet", null)) {

                foreach (ManagementObject mo in mc.GetInstances()) {
                    gwApplications.Rows.Add(new object[] { mo["AppDeliveryTypeName"], mo["Revision"], mo["AppDeliveryTypeId"] });
                }
            }
        }

        private string changeWMIValue(string appDeliveryTypeId, string newValue) {
            string oldDetectionMethod = "";
            ManagementScope mgmtSope = new ManagementScope(@"\\" + txtbxComputer.Text + @"\root\ccm\CIModels", null);
            ObjectQuery objectQuery = new ObjectQuery("SELECT * FROM Local_Detect_Synclet where AppDeliveryTypeId = '" +appDeliveryTypeId + "'" );
            using (ManagementObjectSearcher objectSeacher = new ManagementObjectSearcher(mgmtSope, objectQuery)) {

                foreach (ManagementObject retObject in objectSeacher.Get()) {
                    oldDetectionMethod = retObject["ExpressionXml"].ToString();
                    retObject["ExpressionXml"] = newValue;
                    retObject.Put();
                }

            }
            return oldDetectionMethod;
        }

        private void btnRerun_Click(object sender, EventArgs e) {
            rerunSelectedApp();
        }

        private void rerunSelectedApp() {
            using (ManagementClass mc = new ManagementClass(@"\\" + txtbxComputer.Text + @"\root\ccm\CIModels", "CCM_AppDeliveryType", null)) {

                string appDeliveryTypeId = gwApplications.Rows[gwApplications.CurrentRow.Index].Cells["colAppDeliveryTypeID"].Value.ToString();
                string revision = gwApplications.Rows[gwApplications.CurrentRow.Index].Cells["colRevision"].Value.ToString();
                string oldDetectionMethod = changeWMIValue(appDeliveryTypeId, fakeDetectionMethod);

                ManagementBaseObject inParams = mc.Methods["EnforceApp"].InParameters;
                inParams.SetPropertyValue("ActionType", "Install");
                inParams.SetPropertyValue("AppDeliveryTypeId", appDeliveryTypeId);
                inParams.SetPropertyValue("Revision", revision);
                inParams.SetPropertyValue("SessionId", "1");
                inParams.SetPropertyValue("ContentPath", "");
                inParams.SetPropertyValue("UserSid", "");

                mc.InvokeMethod("EnforceApp", inParams, null);

                changeWMIValue(appDeliveryTypeId, oldDetectionMethod);

                mc.InvokeMethod("EnforceApp", inParams, null);

            }
        }

        private void btnConnect_Click(object sender, EventArgs e) {
            getApplicationDeliveryTypes();
        }

        private void frmMain_Load(object sender, EventArgs e) {
            string[] args = Environment.GetCommandLineArgs();
            if (args.Length > 1) {
                txtbxComputer.Text = args[1]; 
            } else {
                txtbxComputer.Text = System.Environment.MachineName; 
            }          
        }

        private void txtbxComputer_Enter(object sender, EventArgs e) {
            getApplicationDeliveryTypes();
        }
    }
}

