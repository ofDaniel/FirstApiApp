using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;


namespace FirstApiApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TEST SITE: https://docs.postman-echo.com/ 


        }
        private static readonly HttpClient client = new HttpClient();
        //private static readonly FirstApiApp.helpers.JsonHelper JsonHelper = new FirstApiApp.helpers.JsonHelper();

        private async void button2_Click(object sender, EventArgs e)
        {
     
            //Perfrom the get
            var responseString =  await client.GetStringAsync("https://postman-echo.com/get?foo1=bar1&foo2=bar2");

            //deserialize to string
            dynamic parsedJson = JsonConvert.DeserializeObject(responseString);
            
            //pretty print and output
            tbBasicOutput.AppendText(JsonConvert.SerializeObject(parsedJson, Formatting.Indented));

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbBasicOutput.Clear();

        }

        private void btnBasicPostClear_Click(object sender, EventArgs e)
        {
            tbBasicPostOutput.Clear();

        }

        private async void btnBasicPostPOST_Click(object sender, EventArgs e)
        {


            var values = new Dictionary<string, string>
             {
                { tbBasicPostField1Name.Text.ToString(), tbBasicPostField1Value.Text.ToString() }
             };

            var content = new FormUrlEncodedContent(values);


            var response = await client.PostAsync(tbBasicPostURL.Text.ToString(), content);
            var responseString = await response.Content.ReadAsStringAsync();

            

            //deserialize to string
            dynamic parsedJson = JsonConvert.DeserializeObject(responseString);

            //pretty print and output
            tbBasicPostOutput.AppendText("Status Code: " + response.StatusCode.ToString() + Environment.NewLine);

            tbBasicPostOutput.AppendText(JsonConvert.SerializeObject(parsedJson, Formatting.Indented));

           

        }

        private async void button3_Click(object sender, EventArgs e)
        {
            //new request
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(tbAuthBasicGetUrl.Text);
            request.Method = "GET";
            request.Accept = "application/json; charset=utf-8";

            //add auth
            string encodedpass = System.Convert.ToBase64String(System.Text.Encoding.GetEncoding("ISO-8859-1").GetBytes(tbAuthBasicGetUser.Text + ":" + tbAuthBasicGetPass.Text));

            //define response
            request.Headers.Add("Authorization", "Basic " + encodedpass);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            
            //define the header
            WebHeaderCollection header = response.Headers;
            string responseText;
            var encoding = ASCIIEncoding.ASCII;
            using (var reader = new System.IO.StreamReader(response.GetResponseStream(), encoding))
            {
                responseText = reader.ReadToEnd();
            }

           //output
            tbAuthBasicGetOutput.AppendText("Response code: " + response.StatusCode.ToString() + Environment.NewLine);
            tbAuthBasicGetOutput.AppendText("responseTexte: " + responseText + Environment.NewLine);
            

            //deserialize to string
            //dynamic parsedJson = JsonConvert.DeserializeObject(response);

            //pretty print and output
           // tbAuthBasicGetOutput.AppendText(JsonConvert.SerializeObject(parsedJson, Formatting.Indented));

        }

      

       

       
    }
}
