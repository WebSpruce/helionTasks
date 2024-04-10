using PPTrackService;
using System.Diagnostics;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;

namespace HelionTask2WForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void CheckBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(username.Text))
                {
                    MessageBox.Show("Username cannot be empty or null.", "Error");
                }
                else if (string.IsNullOrEmpty(password.Text))
                {
                    MessageBox.Show("Password cannot be empty or null.", "Error");
                }
                else if (string.IsNullOrEmpty(number.Text))
                {
                    MessageBox.Show("Tracking number cannot be empty or null.", "Error");
                }
                else
                {
                    var response = await Track(username.Text, password.Text, number.Text);
                    if (response != null && response.@return != null)
                    {
                        SetCorrectMessage(response);
                    }
                    else
                    {
                        statusLabel.Text = "RESPONSE ERROR";
                    }
                }

            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Form1 CheckBtn_Click error: {ex}");
                MessageBox.Show("Check shipments error", "Error");
            }

        }

        private async Task<sprawdzPrzesylkeResponse> Track(string username, string password, string number)
        {
            try
            {
                SledzeniePortTypeClient sledzeniePortType = new SledzeniePortTypeClient(GetBindingTracking(),
                    new EndpointAddress("https://tt.poczta-polska.pl/Sledzenie/services/Sledzenie.SledzenieHttpSoap11Endpoint/"));
                sledzeniePortType.ClientCredentials.UserName.UserName = username;
                sledzeniePortType.ClientCredentials.UserName.Password = password;

                return await sledzeniePortType.sprawdzPrzesylkeAsync(number);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Form1 Track error: {ex}");
                return new sprawdzPrzesylkeResponse();
            }
        }
        private void SetCorrectMessage(sprawdzPrzesylkeResponse response)
        {
            if (response.@return.status == -1)
            {
                statusLabel.Text = "There is no shipment with this number in the system.";
            }
            else if (response.@return.status == -99)
            {
                statusLabel.Text = "Error.";
            }
            else if (response.@return.status == -2)
            {
                statusLabel.Text = "The given tracking number is incorrect.";
            }
            else if (response.@return.status == 2)
            {
                statusLabel.Text = "The given tracking number is in the system, but there are no events in the given period.";
            }
            else if (response.@return.status == 1)
            {
                statusLabel.Text = "There are other shipments with this number.";
            }
            else if (response.@return.status == 1)
            {
                statusLabel.Text = "OK.";
            }
        }
        private void CancelBtn_Click(object sender, EventArgs e)
        {
            username.Text = string.Empty;
            password.Text = string.Empty;
            number.Text = string.Empty;
            statusLabel.Text = "STATUS";
        }
        public static System.ServiceModel.Channels.Binding GetBindingTracking()
        {
            CustomBinding customBinding = new CustomBinding();
            var securityBindingElement2 = TransportSecurityBindingElement.CreateUserNameOverTransportBindingElement();
            securityBindingElement2.IncludeTimestamp = false;
            customBinding.Elements.Add(securityBindingElement2);
            var messageelement = new TextMessageEncodingBindingElement(MessageVersion.CreateVersion(EnvelopeVersion.Soap11, AddressingVersion.None), Encoding.UTF8);
            customBinding.Elements.Add(messageelement);
            var transportElement = new HttpsTransportBindingElement();
            transportElement.MaxReceivedMessageSize = 20000000;
            transportElement.UseDefaultWebProxy = false;
            transportElement.RequireClientCertificate = false;
            customBinding.Elements.Add(transportElement);

            return customBinding;
        }
    }
}
