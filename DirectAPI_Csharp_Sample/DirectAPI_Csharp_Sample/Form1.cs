using System;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Net;
using System.IO;

namespace DirectAPI_Csharp_Sample
{
    //=====================================================
    //Sample Direct API request - C#.net
    //Thomas Hagan
    //Integration Consultant
    //Sage Payment Solutions
    //November 22nd, 2016
    //Application is intended for instructional use only.
    //If you have any questions, please feel free to email
    //the Integration Support team at sdksupport@sage.com
    //Also, please make sure to register for API credentials
    //at our developer portal: https://developer.sagepayments.com
    //======================================================
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btProcess_Click(object sender, EventArgs e)
        {
            //TH - Test Data. This is the test account infomation we provide
            //in the API Sandbox. Please contact us at sdksupport@sage.com if
            //you need a unique test account and receive the Merchant ID and
            //Merchant Key. In order to get your own Client ID and Client Secret
            //you must register at https://developer.sagepayments.com and setup
            //an App under My Apps. Please let us know if you have any questions.
            string merchantId = "173859436515";
            string merchantKey = "P1J2V8P2Q3D8";

            //TH - The Client ID and Client Key should be hard coded and not displayed
            //in the production product. These are your API credentials used for
            //security and tracking purposes.
            string clientId = "W8yvKQ5XbvAn7dUDJeAnaWCEwA4yXEgd";
            string clientSecret = "iLzODV5AUsCGWGkr";

            //TH - http://requestb.in is a good resource for troubleshooting.
            string strUrl = txtURL.Text;

            string verb = txtVerb.Text;
            string contentType = "application/json";
            string strRequest = txtJSONRequest.Text;
            var nl = Environment.NewLine;
            
            //TH - Building timestamp. Needs to be epoch in seconds.
            TimeSpan t = DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0);
            string timestamp = t.TotalSeconds.ToString();
            //TH - Previously used timestamp for Nonce, changed to Guid.
            //Nonce should be a unique value per transaction.
            Guid g = Guid.NewGuid();
            string nonce = g.ToString();


            //TH - Build the Authorization
            string authToken = verb + strUrl + strRequest + merchantId + nonce + timestamp;
            byte[] hash_authToken = new HMACSHA512(Encoding.ASCII.GetBytes(clientSecret)).ComputeHash(Encoding.ASCII.GetBytes(authToken));
            string hash64_authToken = Convert.ToBase64String(hash_authToken);


            //TH - Make sure the URL string has been included.
            if (String.IsNullOrEmpty(strUrl) == true)
            {
                txtJSONResponse.Text = "Error: Please make sure the URL field is not blank.";
                return;
            }

            //TH - Send the request
            if (verb == "GET")
            {
                request_GET(verb, strUrl, merchantId, merchantKey, nonce, timestamp, clientId, clientSecret);
            }
            else
            {
                request_POST(verb, strUrl, strRequest, merchantId, merchantKey, nonce, timestamp, clientId, clientSecret, contentType);
            }
            
            
        }

        private void btLoadVaultRequest_Click(object sender, EventArgs e)
        {
            //TH - Request variables
            string strCardNumber = "5454545454545454";
            string strExpDate = "0920";
            string strURL = "https://api-cert.sagepayments.com/token/v1/tokens";
            string strVerb = "POST";

            //TH - load request message
            string strRequestVault =
                "{\"cardData\":{\"number\":\"" + strCardNumber +
                "\",\"expiration\":\"" + strExpDate +
                "\"}}";

            txtJSONRequest.Text = strRequestVault;
            txtURL.Text = strURL;
            txtVerb.Text = strVerb;
        }

        private void btLoadSaleRequest_Click(object sender, EventArgs e)
        {

            //TH - Request variables
            string strOrderNumber = "Invoice " + DateTime.Now.Millisecond;
            string strTotalAmount = "7";
            string strCardNumber = "5454545454545454";
            string strExpDate = "0920";
            string strURL = "https://api-cert.sagepayments.com/bankcard/v1/charges?type=Sale";
            string strVerb = "POST";

            //!!!!!!!!!!!!!!!!!!!!!>>>IMPORTANT<<<!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            //TH - This is the bare minimum request for a Sale or Authorization
            //More information may be needed to meet the requirements for a 
            //qualified transaction. Most card-not-present transactions and transactions
            //where the card was entered manually will require the addition of the street
            //address, zip code, and the cvv value to qualify for the best rate.
            //!!!!!!!!!!!!!!!!!!!!!>>>IMPORTANT<<<!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

            //TH - load request message
            string strRequest =
                "{\"Ecommerce\":{\"OrderNumber\":\"" + strOrderNumber +
                "\",\"Amounts\":{\"Total\":\"" + strTotalAmount +
                "\"},\"CardData\":{\"Number\":\"" + strCardNumber +
                "\",\"Expiration\":\"" + strExpDate +
                "\"}}}";

            txtJSONRequest.Text = strRequest;
            txtURL.Text = strURL;
            txtVerb.Text = strVerb;
        }

        private void btLoadGetDetail_Click(object sender, EventArgs e)
        {
            //TH - Request variables
            string strURL = "https://api-cert.sagepayments.com/bankcard/v1/charges/";
            //TH - There is no request string with a GET Charges Detail request.
            string strRequest = "";
            string strVerb = "GET";
            string strReference = "DC6GFbyDO0";

            txtJSONRequest.Text = strRequest;
            txtURL.Text = strURL + strReference;
            txtVerb.Text = strVerb;
            txtReference.Text = strReference;
        }

        private void request_POST(string verb, string strUrl, string strRequest, string merchantId, string merchantKey, string nonce, string timestamp, string clientId, string clientSecret, string contentType)
        {
            var nl = Environment.NewLine;

            //TH - Build the Authorization
            string authToken = verb + strUrl + strRequest + merchantId + nonce + timestamp;
            byte[] hash_authToken = new HMACSHA512(Encoding.ASCII.GetBytes(clientSecret)).ComputeHash(Encoding.ASCII.GetBytes(authToken));
            string hash64_authToken = Convert.ToBase64String(hash_authToken);


            //TH - Make sure the URL string has been included.
            if (String.IsNullOrEmpty(strUrl) == true)
            {
                txtJSONResponse.Text = "Error: Please make sure the URL field is not blank.";
                return;
            }

            //TH - Initiate Web Request
            var web_request = (HttpWebRequest)WebRequest.Create(strUrl);

            //TH - Set the headers and details
            var web_request_headers = web_request.Headers;
            Console.WriteLine("Configuring web_request to include headers for Sage Direct API");
            web_request_headers["clientId"] = clientId;
            web_request_headers["merchantId"] = merchantId;
            web_request_headers["merchantKey"] = merchantKey;
            web_request_headers["nonce"] = nonce;
            web_request_headers["timestamp"] = timestamp;
            web_request_headers["authorization"] = hash64_authToken;
            web_request.Method = verb;

            //TH - Format the request
            var byteArray = Encoding.ASCII.GetBytes(strRequest);

            //TH - Send the data
            web_request.ContentType = contentType;
            web_request.ContentLength = byteArray.Length;
            var datastream = web_request.GetRequestStream();
            datastream.Write(byteArray, 0, byteArray.Length);
            datastream.Close();

            //TH - Get the Response and Catch any errors.
            try
            {
                var web_response = (HttpWebResponse)web_request.GetResponse();
                Console.WriteLine(web_response.StatusDescription);
                datastream = web_response.GetResponseStream();

                var reader = new StreamReader(datastream);
                string responseFromServer = reader.ReadToEnd();
                Console.WriteLine(responseFromServer);
                reader.Close();
                datastream.Close();
                web_response.Close();

                //TH - Display response.
                txtJSONResponse.Text = "Server Status Code: " + web_response.StatusCode + nl + "Server Status: " + web_response.StatusDescription + nl + "API Response: " + responseFromServer;

            }
            catch (Exception exception)
            {
                txtJSONResponse.Text = "Server Response: " + exception.Message;
            }
        }

        private void request_GET(string verb, string strUrl, string merchantId, string merchantKey, string nonce, string timestamp, string clientId, string clientSecret)
        {
            var nl = Environment.NewLine;

            //TH - Build the Authorization
            string authToken = verb + strUrl + merchantId + nonce + timestamp;
            byte[] hash_authToken = new HMACSHA512(Encoding.ASCII.GetBytes(clientSecret)).ComputeHash(Encoding.ASCII.GetBytes(authToken));
            string hash64_authToken = Convert.ToBase64String(hash_authToken);


            //TH - Make sure the URL string has been included.
            if (String.IsNullOrEmpty(strUrl) == true)
            {
                txtJSONResponse.Text = "Error: Please make sure the URL field is not blank.";
                return;
            }

            //TH - Initiate Web Request
            var web_request = (HttpWebRequest)WebRequest.Create(strUrl);

            //TH - Set the headers and details
            var web_request_headers = web_request.Headers;
            Console.WriteLine("Configuring web_request to include headers for Sage Direct API");
            web_request_headers["clientId"] = clientId;
            web_request_headers["merchantId"] = merchantId;
            web_request_headers["merchantKey"] = merchantKey;
            web_request_headers["nonce"] = nonce;
            web_request_headers["timestamp"] = timestamp;
            web_request_headers["authorization"] = hash64_authToken;
            web_request.Method = verb;

            //TH - Get the Response and Catch any errors.
            try
            {
                var web_response = (HttpWebResponse)web_request.GetResponse();
                Console.WriteLine(web_response.StatusDescription);
                var datastream = web_response.GetResponseStream();

                var reader = new StreamReader(datastream);
                string responseFromServer = reader.ReadToEnd();
                Console.WriteLine(responseFromServer);
                reader.Close();
                datastream.Close();
                web_response.Close();

                //TH - Display response.
                txtJSONResponse.Text = "Server Status Code: " + web_response.StatusCode + nl + "Server Status: " + web_response.StatusDescription + nl + "API Response: " + responseFromServer;

            }
            catch (Exception exception)
            {
                txtJSONResponse.Text = "Server Response: " + exception.Message;
            }
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            //TH - Clear Fields
            txtJSONRequest.Text = "";
            txtJSONResponse.Text = "";
            txtReference.Text = "";
            txtURL.Text = "";
            txtVerb.Text = "";
        }
    }
}
