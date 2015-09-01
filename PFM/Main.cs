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
using System.Net.Sockets;
using System.IO;
using System.Text.RegularExpressions;
using System.Web;
using System.Collections.Specialized;
using System.Globalization;
using System.Runtime.Serialization.Json;

namespace PFM
{

    public partial class MainForm : Form
    {

        private TcpClient client;
        public StreamReader STR;
        public string receive;

        private TcpClient clientHTTP;
        public StreamReader STRHTTP;
        public string receiveHTTP;

        public Boolean HTTPstart;

        public MainForm()
        {
            InitializeComponent();
        }

        TcpListener listenerHTTP = new TcpListener(IPAddress.Any, 80);
        TcpListener listener = new TcpListener(IPAddress.Any, 18888);



        static byte[] GetBytes(string str)
        {
            byte[] bytes = new byte[str.Length * sizeof(char)];
            System.Buffer.BlockCopy(str.ToCharArray(), 0, bytes, 0, bytes.Length);
            return bytes;
        }

        static string GetString(byte[] bytes)
        {
            char[] chars = new char[bytes.Length / sizeof(char)];
            System.Buffer.BlockCopy(bytes, 0, chars, 0, bytes.Length);
            return new string(chars);
        }

        private void SendError(TcpClient Client, int Code)
        {
            // Получаем строку вида "200 OK"
            // HttpStatusCode хранит в себе все статус-коды HTTP/1.1
            string CodeStr = Code.ToString() + " " + ((HttpStatusCode)Code).ToString();
            // Код простой HTML-странички
            string Html = "<html><body><h1>" + CodeStr + "</h1></body></html>";
            // Необходимые заголовки: ответ сервера, тип и длина содержимого. После двух пустых строк - само содержимое
            string Str = "HTTP/1.1 " + CodeStr + "\nContent-type: text/html\nContent-Length:" + Html.Length.ToString() + "\n\n" + Html;
            // Приведем строку к виду массива байт
            byte[] Buffer = Encoding.ASCII.GetBytes(Str);
            // Отправим его клиенту
            Client.GetStream().Write(Buffer, 0, Buffer.Length);
            // Закроем соединение
            Client.Close();
        }


        public static string DataTableToJSON(DataTable Dt)
        {
            string[] StrDc = new string[Dt.Columns.Count];

            string HeadStr = string.Empty;
            for (int i = 0; i < Dt.Columns.Count; i++)
            {

                StrDc[i] = Dt.Columns[i].Caption;
                HeadStr += "\"" + StrDc[i] + "\":\"" + StrDc[i] + i.ToString() + "¾" + "\",";

            }

            HeadStr = HeadStr.Substring(0, HeadStr.Length - 1);

            StringBuilder Sb = new StringBuilder();

            Sb.Append("[");

            for (int i = 0; i < Dt.Rows.Count; i++)
            {

                string TempStr = HeadStr;

                for (int j = 0; j < Dt.Columns.Count; j++)
                {

                    TempStr = TempStr.Replace(Dt.Columns[j] + j.ToString() + "¾", Dt.Rows[i][j].ToString().Trim());
                }
                //Sb.AppendFormat("{{{0}}},",TempStr);

                Sb.Append("{" + TempStr + "},");
            }

            Sb = new StringBuilder(Sb.ToString().Substring(0, Sb.ToString().Length - 1));

            if (Sb.ToString().Length > 0)
                Sb.Append("]");

            return StripControlChars(Sb.ToString());

        }
        //To strip control characters:

        //A character that does not represent a printable character but //serves to initiate a particular action.

        public static string StripControlChars(string s)
        {
            return Regex.Replace(s, @"[^\x20-\x7F]", "");
        }



        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;

            DateTime a = DateTime.UtcNow;

            int i1 = 0;
            int i2 = 0;
            int i3 = 0;
            int i4 = 0;
            int i5 = 0;
            int i6 = 0;
            int i7 = 0;
            int i8 = 0;

            int c1 = 0;
            int c2 = 0;
            int c3 = 0;

            int cnt_1 = 0;
            int cnt_2 = 0;
            int cnt_3 = 0;
            int cnt_line_1 = 0;
            int cnt_line_2 = 0;
            int cnt_line_3 = 0;

            bool is_1_line_present = false;
            bool is_2_line_present = false;
            bool is_3_line_present = false;


            while (client.Connected)
            {
                try
                {

                    receive = STR.ReadLine();
                    this.debugBox.Invoke(new MethodInvoker(delegate()
                    {
                        debugBox.Text = receive;
                    }));


                    //MessageBox.Show(receive);

                    switch (receive)
                    {


                        case "1":
                            i1 += 1;
                            this.txtL1.Invoke(new MethodInvoker(delegate ()
                            {
                                txtL1.Text = i1.ToString();
                            }));

                            break;
                        case "2":
                            i2 += 1;
                            this.txtL2.Invoke(new MethodInvoker(delegate ()
                            {
                                txtL2.Text = i2.ToString();
                            }));
                            break;
                        case "3":
                            i3 += 1;
                            this.txtL3.Invoke(new MethodInvoker(delegate ()
                            {
                                txtL3.Text = i3.ToString();
                            }));
                            break;
                        case "4":
                            i4 += 1;
                            this.txtL4.Invoke(new MethodInvoker(delegate ()
                            {
                                txtL4.Text = i4.ToString();
                            }));
                            break;
                        case "5":
                            i5 += 1;
                            this.txtL5.Invoke(new MethodInvoker(delegate ()
                            {
                                txtL5.Text = i5.ToString();
                            }));
                            break;
                        case "6":
                            i6 += 1;
                            this.txtL6.Invoke(new MethodInvoker(delegate ()
                            {
                                txtL6.Text = i6.ToString();
                            }));
                            break;

                        case "7":

                            if (i1 != 0 && i2 != 0)
                            {
                                cnt_line_1++;
                                cnt_1 = cnt_1 + Math.Max(i1, i2); ;

                                this.txtR1.Invoke(new MethodInvoker(delegate ()
                                {
                                    txtR1.Text = cnt_line_1.ToString();
                                }));

                                this.txtC1.Invoke(new MethodInvoker(delegate ()
                                {
                                    txtC1.Text = cnt_1.ToString();
                                }));

                            };


                            if (i3 != 0 && i4 != 0)
                            {
                                cnt_line_2++;
                                cnt_2 = cnt_2 + Math.Max(i3, i4); ;

                                this.txtR2.Invoke(new MethodInvoker(delegate ()
                                {
                                    txtR2.Text = cnt_line_2.ToString();
                                }));

                                this.txtC2.Invoke(new MethodInvoker(delegate ()
                                {
                                    txtC2.Text = cnt_2.ToString();
                                }));

                            };




                            if (i5 != 0 && i6 != 0)
                            {
                                cnt_line_3++;
                                cnt_3 = cnt_3 + Math.Max(i5, i6); ;

                                this.txtR3.Invoke(new MethodInvoker(delegate ()
                                {
                                    txtR3.Text = cnt_line_3.ToString();
                                }));

                                this.txtC3.Invoke(new MethodInvoker(delegate ()
                                {
                                    txtC3.Text = cnt_3.ToString();
                                }));

                            };






                            pfmDataSet.output_lenghtRow out_rasp = pfmDataSet.output_lenght.FindByid(Convert.ToInt32(this.comboBox2.SelectedValue.ToString()));
                            pfmDataSet.sizesRow out_size = pfmDataSet.sizes.FindByid(Convert.ToInt32(this.comboBox3.SelectedValue.ToString()));
                            pfmDataSet.prod_typesRow out_prod_types = pfmDataSet.prod_types.FindByid(Convert.ToInt32(this.comboBox4.SelectedValue.ToString()));

                            if (out_rasp.l1 != 0)
                            {
                               
                                pfmDataSet.output_productRow newProductRow;

                                newProductRow = pfmDataSet.output_product.Newoutput_productRow();
                                newProductRow.l = out_rasp.l1;
                                newProductRow.w = out_size.w;
                                newProductRow.h = out_size.h;
                                newProductRow.type_product = out_prod_types.id;
                                newProductRow.cnt = Math.Max(i1, i2);
                                newProductRow.dt = DateTime.Now;
                               //DateTime a = DateTime.UtcNow;

                                this.pfmDataSet.output_product.Rows.Add(newProductRow);

                                this.output_productTableAdapter.Update(this.pfmDataSet.output_product);
                                
                            }


                            i1 = 0;
                            i2 = 0;
                            i3 = 0;
                            i4 = 0;
                            i5 = 0;
                            i6 = 0;
                            this.txtL1.Invoke(new MethodInvoker(delegate ()
                            {
                                txtL1.Text = i1.ToString();
                            }));
                            this.txtL2.Invoke(new MethodInvoker(delegate ()
                            {
                                txtL2.Text = i2.ToString();
                            }));
                            this.txtL3.Invoke(new MethodInvoker(delegate ()
                            {
                                txtL3.Text = i3.ToString();
                            }));
                            this.txtL4.Invoke(new MethodInvoker(delegate ()
                            {
                                txtL4.Text = i4.ToString();
                            }));
                            this.txtL5.Invoke(new MethodInvoker(delegate ()
                            {
                                txtL5.Text = i5.ToString();
                            }));
                            this.txtL6.Invoke(new MethodInvoker(delegate ()
                            {
                                txtL6.Text = i6.ToString();
                            }));

                            break;

                        case "9":

                            if (debugBox.BackColor == Color.Red)
                            {
                                this.debugBox.Invoke(new MethodInvoker(delegate ()
                                {
                                    debugBox.BackColor = Color.Green;
                                }));

                            }
                            else
                            {
                                this.debugBox.Invoke(new MethodInvoker(delegate ()
                                {
                                    debugBox.BackColor = Color.Red;
                                }));


                            }



                            break;
                        default:
                            
                            break;
                    }


                    //receive = STR.ReadLine();
                    //this.lineSum.Invoke(new MethodInvoker (delegate() 
                    //    {
                    //        lineSum.AppendText(" === " + receive + " === \n" );
                    //    }
                    //));
                    receive = "";
                }
                catch(Exception x)
                {
                    MessageBox.Show(x.Message.ToString());
                
                }
                    
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pfmDataSet.prod_types". При необходимости она может быть перемещена или удалена.
            this.prod_typesTableAdapter.Fill(this.pfmDataSet.prod_types);
            // TODO: This line of code loads data into the 'pfmDataSet.output_product' table. You can move, or remove it, as needed.
            this.output_productTableAdapter.Fill(this.pfmDataSet.output_product);
            // TODO: This line of code loads data into the 'pfmDataSet.sizes' table. You can move, or remove it, as needed.
            this.sizesTableAdapter.Fill(this.pfmDataSet.sizes);
            // TODO: This line of code loads data into the 'pfmDataSet.sizes' table. You can move, or remove it, as needed.
            this.sizesTableAdapter.Fill(this.pfmDataSet.sizes);

            // TODO: This line of code loads data into the 'pfmDataSet.output_lenght' table. You can move, or remove it, as needed.
            this.output_lenghtTableAdapter.Fill(this.pfmDataSet.output_lenght);
            // TODO: This line of code loads data into the 'pfmDataSet.input_length' table. You can move, or remove it, as needed.
            this.input_lengthTableAdapter.Fill(this.pfmDataSet.input_length);


//            listenerHTTP.Start();
//            clientHTTP = listenerHTTP.AcceptTcpClient();
//            STRHTTP = new StreamReader(clientHTTP.GetStream());
//            backgroundWorkerHTTP.RunWorkerAsync();


        }

        private void backgroundWorkerHTTP_DoWork(object sender, DoWorkEventArgs e)
        {


            TcpListener serverHTTP;
            Int32 port = 80;
            IPAddress localAddr = IPAddress.Parse("0.0.0.0");
            serverHTTP = new TcpListener(localAddr, port);
            serverHTTP.Start();
            Byte[] bytes = new Byte[256];
            DateTime beg;
            DateTime end;
            String begs;
            String ends;
            String sql_resp = "---";

            // Объявим строку, в которой будет хранится запрос клиента
            string Request = "";
            // Буфер для хранения принятых от клиента данных
            byte[] Buffer = new byte[1024];
            byte[] Buffer1 = new byte[1024];
            // Переменная для хранения количества байт, принятых от клиента
            int Count;

            while (true)
            {
                DateTime thisDay = DateTime.Today;
                TcpClient clientHTTP = serverHTTP.AcceptTcpClient();
                NetworkStream streamHTTP = clientHTTP.GetStream();
                Request = "";
                sql_resp = "---";
                // Читаем из потока клиента до тех пор, пока от него поступают данные
                while ((Count = clientHTTP.GetStream().Read(Buffer, 0, Buffer.Length)) > 0)
                {
                    // Преобразуем эти данные в строку и добавим ее к переменной Request
                    Request += Encoding.ASCII.GetString(Buffer, 0, Count);
                    // Запрос должен обрываться последовательностью \r\n\r\n
                    // Либо обрываем прием данных сами, если длина строки Request превышает 4 килобайта
                    // Нам не нужно получать данные из POST-запроса (и т. п.), а обычный запрос
                    // по идее не должен быть больше 4 килобайт
                    if (Request.IndexOf("\r\n\r\n") >= 0 || Request.Length > 4096)
                    {
                        break;
                    }
                };

                // Парсим строку запроса с использованием регулярных выражений
                // При этом отсекаем все переменные GET-запроса
                Match ReqMatch = Regex.Match(Request, @"^\w+\s+([^\s\?]+)[^\s]*\s+HTTP/.*|");

                // Если запрос не удался
                if (ReqMatch == Match.Empty)
                {
                    // Передаем клиенту ошибку 400 - неверный запрос
                    SendError(clientHTTP, 400);
                    return;
                }

                // Получаем строку запроса
                string RequestUri = ReqMatch.Groups[1].Value;

                // Приводим ее к изначальному виду, преобразуя экранированные символы
                // Например, "%20" -> " "
                RequestUri = Uri.UnescapeDataString(RequestUri);

                // Если в строке содержится двоеточие, передадим ошибку 400
                // Это нужно для защиты от URL типа http://example.com/../../file.txt
                if (RequestUri.IndexOf("..") >= 0)
                {
                    SendError(clientHTTP, 400);
                    return;
                }

                // Если строка запроса оканчивается на "/", то добавим к ней index.html
                if (RequestUri.EndsWith("/"))
                {
                    RequestUri += "index.html";
                }

                // Parse the query string variables into a NameValueCollection.
                NameValueCollection qscoll = HttpUtility.ParseQueryString(RequestUri);
                // Iterate through the collection.
                StringBuilder sb = new StringBuilder();
                foreach (String s in qscoll.AllKeys)
                {
                    sb.Append(s + " - " + qscoll[s] + "<br />");
                }

                try
                {
                    beg = DateTime.ParseExact(qscoll[0].ToString(), "yyyyMMddhhmmss", CultureInfo.InvariantCulture);
                    begs = beg.ToString();
                }
                catch
                {
                    begs = "---";
                    beg = DateTime.Now;
                }

                try
                {
                    end = DateTime.ParseExact(qscoll[1].ToString(), "yyyyMMddhhmmss", CultureInfo.InvariantCulture);
                    ends = end.ToString();
                }
                catch
                {
                    ends = "---";
                    end = DateTime.Now;

                }

                if (begs != "---" && ends != "---")
                {



                    // pfmDataSet.output_lenghtRow out_rasp = pfmDataSet.output_lenght.FindByid(Convert.ToInt32(this.comboBox2.SelectedValue.ToString()));
                    // pfmDataSet.sizesRow out_size = pfmDataSet.sizes.FindByid(Convert.ToInt32(this.comboBox3.SelectedValue.ToString()));


                    sql_resp = "123";
                    String q = "dt >= '" + begs + "' AND dt <='" + end + "'";

                    DataRow[] dr = pfmDataSet.output_product.Select(q);
                    DataTable dtt = pfmDataSet.output_product;

                    dr.CopyToDataTable<DataRow>(dtt, LoadOption.Upsert);

                    sql_resp = DataTableToJSON(dtt);

                }


                // string Html = "<html><body><h1>It works!</h1></body></html>";
                string Html = sql_resp;
                // Необходимые заголовки: ответ сервера, тип и длина содержимого. После двух пустых строк - само содержимое
                string Str = "HTTP/1.1 200 OK\nContent-type: text/html\nContent-Length:" + Html.Length.ToString() + "\n\n" + Html;

                Buffer = Encoding.ASCII.GetBytes(Str);


                streamHTTP.Write(Buffer, 0, Buffer.Length);



                clientHTTP.Close();
            }

        }



        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
             
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pfmDataSetBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void RaspParamFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            RaspParamsForm RaspParamsForm = new RaspParamsForm();
            RaspParamsForm.Show();

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            Application.Exit();

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //TcpListener listener = new TcpListener(IPAddress.Any, 18888);
            listener.Start();
            client = listener.AcceptTcpClient();


            STR = new StreamReader(client.GetStream());

            backgroundWorker1.RunWorkerAsync();

            if (HTTPstart == false)
            {
                backgroundWorkerHTTP.RunWorkerAsync();
                HTTPstart = true;
            }
            

            btnStart.Visible = false;
            btnStop.Visible = true;

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            //listener.Stop();

            STR.Close();

            //listener.Stop();


            client.Close();

            backgroundWorker1.CancelAsync();
 //           backgroundWorkerHTTP.CancelAsync();

            btnStart.Visible = true;
            btnStop.Visible = false;

        }

        private void debugBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            pfmDataSet.output_lenghtRow out_rasp = pfmDataSet.output_lenght.FindByid(Convert.ToInt32(this.comboBox2.SelectedValue.ToString()));
            pfmDataSet.sizesRow out_size = pfmDataSet.sizes.FindByid(Convert.ToInt32(this.comboBox3.SelectedValue.ToString()));


            pfmDataSet.output_productRow newProductRow;

            newProductRow = pfmDataSet.output_product.Newoutput_productRow();
            newProductRow.l = out_rasp.l1;
            newProductRow.w = out_size.w;
            newProductRow.h = out_size.h;
            newProductRow.type_product = 1;
            newProductRow.cnt = 11;
            newProductRow.dt = DateTime.Now;
            //DateTime a = DateTime.UtcNow;

            this.pfmDataSet.output_product.Rows.Add(newProductRow);

            this.output_productTableAdapter.Update(this.pfmDataSet.output_product);


        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
