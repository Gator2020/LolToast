using Desktop.Robot.Extensions;
using Microsoft.Web.WebView2.WinForms;
using Newtonsoft.Json.Converters;
using System;
using System.Data;
using System.Diagnostics;
using System.DirectoryServices.ActiveDirectory;
using System.IO;
using System.Linq.Expressions;
using System.Media;
using System.Net;
using System.Net.Quic;
using System.Net.Security;
using System.Net.Sockets;
using System.Reflection.Emit;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Xml;

namespace UnityMessage
{
    public partial class Form1 : Form
    {
        Socket ClientSock;
        public Form1()
        {

            InitializeComponent();

        }
        public int ClickWindow(Process p)
        {
            Desktop.Robot.Robot WM_Char = new Desktop.Robot.Robot();
            WM_Char.MouseMove(int.Parse(p.MainWindowHandle.ToString()), int.Parse(p.MainWindowHandle.ToString()));
            WM_Char.Click();
            webView22.ExecuteScriptAsync(ClickWindow(p).ToString());

            return 0;

        }
        public string PostBufferMsg()
        {
            foreach (Process p in ClientHabboProcs)
            {
                Desktop.Robot.Robot WM_Char = new Desktop.Robot.Robot();

                byte[] ClickWindowByte = Encoding.ASCII.GetBytes(ClickWindow(p).ToString());


            }
            return PostBufferMsg();
        }
        public WebView2 Browser;
        public Container ContainerHandle;
        public List<HabboClient> Clients = new List<HabboClient>();
        public WebView2 BrowserClient;
        public static Socket Accepted = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        class WindowThreadMemory : Form1
        {
            public int PostMessage()
            {
                Desktop.Robot.Robot WM_char = new Desktop.Robot.Robot();
                WM_char.CombineKeys(Desktop.Robot.Key.Control, Desktop.Robot.Key.V);
                WM_char.CombineKeys(Desktop.Robot.Key.Enter, Desktop.Robot.Key.Enter);
                WM_char.GetMousePosition();
                var Script = "var xhr = new XMLHTTPrequest();";
                base.Browser.ExecuteScriptAsync(Script);

                WM_char.Click();
                return 0;
            }
            public List<HabboClient> ClientFormHandles = new List<HabboClient>();

            public string XHRScript(Socket Client, HttpRequestMessage ScriptPost)
            {

                if (base.Browser.Cursor.Handle != IntPtr.Zero)
                {
                    Desktop.Robot.Robot WM_char = new Desktop.Robot.Robot();
                    WM_char.MouseMove(MousePosition.X, MousePosition.Y);
                    WM_char.Click();
                    WM_char.GetMousePosition();
                    var Script = "var xhr = new XMLHTTPrequest();";

                    Client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    Client.Connect(new IPEndPoint(IPAddress.Parse("69.172.200.161"), 443));

                    if (ScriptPost != null)
                    {

                        Client.Send(Encoding.ASCII.GetBytes(PostMessage().ToString()));

                    }
                    base.Browser.ExecuteScriptAsync(Script);
                }

                return base.Browser.CoreWebView2.ExecuteScriptAsync("document.elementFromPoint(" + PostMessage() + "," + PostMessage() + ";").ToString();

            }
            public static byte[] ScriptMessage { get; set; }




            public string OpenClickEvent()
            {
                try
                {
                    WebRequest GetRequest = (HttpWebRequest)WebRequest.Create("https://pastebin.com/raw/TF9MauVKt");
                    GetRequest.Method = "GET";
                    Stream OBJStreamReader = GetRequest.GetResponse().GetResponseStream();
                    StreamReader SR = new StreamReader(OBJStreamReader);
                    string Result = SR.ReadToEnd().ToString();
                    while (Result != null)
                    {

                        HttpClient WebHttp = new HttpClient();
                        WebHttp.BaseAddress = GetRequest.RequestUri;
                        using (var httpReqMessage = new HttpRequestMessage(HttpMethod.Post, base.Browser.Source))
                        {
                            Socket ClientSock = null;
                            byte[] ContentData = Encoding.UTF8.GetBytes(XHRScript(ClientSock, httpReqMessage));
                            var DataMsg = new StringContent(Encoding.ASCII.GetString(ContentData, 0, ContentData.Length), Encoding.ASCII, "application/json");
                            //lientSock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                            var Script_Content = "var dispatchEvent = \"dispatchEvent\"; dispatchEvent=document.createAttribute(dispatchEvent);\r\n\r\nlet event = new MouseEvent(\"click\", {\r\n    bubbles: true,\r\n    cancelable: true,\r\n    clientX: 100,\r\n    clientY: 100\r\n\r\n}); console.log(dispatchEvent);\r\nvar ElementObj = null;\r\nfor(var x =0; x<100;x++){var elem = document.elementFromPoint(x,x); elem.valueOf=dispatchEvent; ElementObj=elem; if(ElementObj=elem){console.log(elem+dispatchEvent+" + DataMsg + ");}console.log(ElementObj+elem)}\r\nvar ev = ElementObj.dispatchEvent(event); for(var x= 0; x<19302;){var oImg=document.createElement(\"image\"); ElementObj.setAttribute(\"dispatchEvent\",dispatchEvent); ElementObj.setAttribute(\"src\",\"http://localhost:30001\"); var imgData=document.appendChild(oImg); var Data = ElementObj.dispatchEvent(null);console.log(\"sending\"+imgData+document.elementFromPoint(x,x)+ev);}";
                            var String_Content = new StringContent(Script_Content, Encoding.UTF8, "application/json");



                            httpReqMessage.Content = new StringContent(XHRScript(ClientSock, httpReqMessage) + Script_Content, Encoding.UTF8, "applcation/json");



                            var Data = XHRScript(ClientSock, httpReqMessage);
                            base.Browser.ExecuteScriptAsync(Data);
                            WebHttp.SendAsync(httpReqMessage).Wait();



                        }
                    }
                }
                catch (Exception ex)
                {
                    HttpClient Client = new HttpClient();

                    Client.BaseAddress = base.Browser.Source;
                    using (var HttpRequestMessage = new HttpRequestMessage(HttpMethod.Post, base.Browser.Source))
                    {


                    }


                }
                return OpenClickEvent();
            }
        }
        public static Socket AcceptedSocket = null;

        public static List<int> Process_IDS = new List<int>();
        public static List<IntPtr> ClientHandles = new List<IntPtr>();
        public class RecieveClientHandler : Form1
        {

            public AsyncCallback AsyncCallback { get; set; }
            public Socket WebSocket { get; set; } = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            public RecieveClientHandler(Socket Client)
            {
                SocketAsyncEventArgs EventArgs = new SocketAsyncEventArgs();
                Microsoft.Web.WebView2.WinForms.WebView2 BrowserClient = new Microsoft.Web.WebView2.WinForms.WebView2();
                BrowserClient.Source = new Uri("https://www.habbo.com");

                MessageBox.Show(BrowserClient.Source.ToString() + BrowserClient.Handle.ToString() + DateTime.Now.ToString());
                Client.BeginReceive(new byte[] { }, 0, 0, SocketFlags.None, AcceptCallback, null);
            }
            public void AcceptCallback(IAsyncResult AR)
            {
                [DllImport("user32.dll", SetLastError = true)]
                static extern void keybd_event(byte bScan, byte bKey, int dwFlags, int dwExtraInfo);
                static extern IntPtr SetParent(IntPtr hwndChild, IntPtr hwndNewParent);
                foreach (Process p in base.ClientHabboProcs)
                {
                    const uint DOWN = 0x0002;
                    const uint UP = 0x0004;
                    [DllImport("user32.dll")]
                    static extern void mouse_event(uint dwFlags, int dx, int dy, uint dwData, int dwExtraInfo);
                    Desktop.Robot.Robot wm_char = new Desktop.Robot.Robot();
                    wm_char.GetMousePosition();
                    MousePosition.X.Equals(WebSocket.Receive(new byte[] { }));
                    mouse_event(UP, MousePosition.X, MousePosition.Y, 0, 0);
                    wm_char.MouseMove(MousePosition.X, MousePosition.Y);
                    MousePosition.Y.Equals(WebSocket.Receive(new byte[] { }));
                    mouse_event(DOWN, MousePosition.X, MousePosition.Y, 0, 0);
                    wm_char.GetMousePosition();
                    wm_char.Click();
                    Type objRef = null;
                    objRef.Equals(Invoke((System.Windows.Forms.MethodInvoker)delegate { SendKeys.Send("^V"); keybd_event(0x00, 0, 0x0001, 0); SendKeys.Send("{ENTER}"); keybd_event(0x01, 0, 0x0000, 0); keybd_event(0x0D, 0, 0x0001, 0); wm_char.CombineKeys(Desktop.Robot.Key.Control, Desktop.Robot.Key.V); wm_char.CombineKeys(Desktop.Robot.Key.Shift, Desktop.Robot.Key.Enter); }));
                    p.MainWindowHandle.Equals(WebSocket.Receive(new byte[] { }));
                    SetParent(WebSocket.Handle, p.MainWindowHandle);
                    SetParent(p.Handle, WebSocket.Handle);
                    var RecvBuffer = new byte[] { (byte)int.Parse(objRef.ToString()) };
                    Array.Resize<byte>(ref RecvBuffer, base.ClientSock.Send(RecvBuffer, 0, RecvBuffer.Length, 0));
                }
            }
        }
        public string PostMessageAsync(object sender, EventArgs e)
        {
            #region sortBytes
            [DllImport("user32.dll")]
            static extern IntPtr SetParent(IntPtr Hwnd, IntPtr HwndnewParent);
            SetParent(SendMessage(sender, e), Process.GetCurrentProcess().MainWindowHandle);
            foreach (Process p in ClientProcs)
            {
                using (var BinaryRead = new BinaryReader(new MemoryStream(new byte[] { (byte)p.MainWindowHandle })))
                {
                    byte[] WindowHwnd = Encoding.ASCII.GetBytes(p.MainWindowHandle.ToString());
                    while (WindowHwnd.Length > 0)
                    {
                        for (int i = 0; i < WindowHwnd.Length; i++)
                        {
                            WindowThreadMemory HWnD = new WindowThreadMemory();
                            p.Equals(BinaryRead.Read(Encoding.ASCII.GetBytes((string)HWnD.PostMessage().ToString())));
                            p.Equals(BinaryRead.Read(Encoding.Default.GetBytes((string)HWnD.PostMessage().ToString())));
                            using (var BinaryWriter = new BinaryWriter(new MemoryStream(new byte[] { (byte)p.MainWindowHandle })))
                            {

                                List<byte[]> WindowAarrays = new List<byte[]>();


                                foreach (byte b in Encoding.ASCII.GetBytes(p.MainWindowHandle.ToString()))
                                {
                                    WindowAarrays.Add(new byte[] { (byte)p.Handle });
                                    WindowAarrays.Add(new byte[] { (byte)p.MainWindowHandle });
                                    WindowAarrays.Add(new byte[] { (byte)int.Parse(Encoding.ASCII.GetBytes(p.MainWindowHandle.ToString())) });

                                }
                                foreach (byte[] SelectWindow in WindowAarrays)
                                {
                                    WindowAarrays.Add(new byte[] { (byte)int.Parse(Encoding.Default.GetBytes(p.MainWindowHandle.ToString())) });
                                    for (int Window = 0; Window < SelectWindow.Length; Window++)
                                    {
                                        foreach (byte Windowbyte in Encoding.Default.GetBytes(HWnD.PostMessage().ToString()))
                                        {
                                            byte[] StreamMessage = new byte[] { (byte)int.Parse(Encoding.Default.GetBytes(HWnD.PostMessage().ToString())) };
                                            SelectWindow[i] += StreamMessage[i];
                                            SelectWindow[i].Equals(StreamMessage[i]);
                                        }
                                    }
                                }
                            }
                        }

                    }

                }
                #endregion
            }
            Form1 F = new Form1();
            WindowThreadMemory W = new WindowThreadMemory();
            W.PostMessage();
            W.OpenClickEvent();

            return PostMessageAsync(sender, e);
        }
        public IntPtr SendMessage(object sender, EventArgs e)
        {
            try
            {
                WebRequest HttpReq = (HttpWebRequest)WebRequest.Create("https://www.habboEmulatorNetwork.000webhostapp.com");
                HttpReq.Method = "GET";
                Stream Objstreamreader = HttpReq.GetResponse().GetResponseStream();
                StreamReader SR = new StreamReader(Objstreamreader);
                if (SR.ReadToEnd != null)
                {
                    foreach (Process p in ClientProcs)
                    {
                        PostMessageAsync(sender, e);
                        using (var stream = new MemoryStream(new byte[] { (byte)p.MainWindowHandle }))
                        {
                            byte[] WindowMemoryBuffer = Encoding.Default.GetBytes(p.MainWindowTitle.ToString());
                            BinaryWriter BW = new BinaryWriter(new MemoryStream(WindowMemoryBuffer));
                            byte[] WriteToClient = Encoding.Default.GetBytes(PostMessageAsync(sender, e));
                            foreach (byte b in WriteToClient)
                            {
                                BW.Write(b);
                                BW.Write(WriteToClient);
                                for (int i = 0; i < WindowMemoryBuffer.Length; i++)
                                {
                                    BinaryReader BR = new BinaryReader(new MemoryStream(WindowMemoryBuffer));
                                    BR.Read(WindowMemoryBuffer);
                                    byte[] WindHwnd = new byte[stream.Length];
                                    BR.Read(WindHwnd);



                                }
                            }

                        }

                    }
                }
            }
            catch (Exception ex)
            {
                PostMessageAsync(sender, e);
            }
            return SendMessage(sender, e);

        }
        Listener L;
        public string OpenFiles(OpenFileDialog Sync1, OpenFileDialog Sync)
        {

            return Process.Start(Sync1.FileName.ToString()).ToString() + Process.Start(Sync.FileName.ToString()).ToString();


        }
        public List<string> FilePaths = new List<string>();
        public IntPtr PanelHandle { get; set; }
        public List<HabboClient> ClientForms = new List<HabboClient>();
        public IntPtr RecieveMessageAsync(Process p, Socket Accepted)
        {
            HabboClient H = new HabboClient();
            foreach (HabboClient X in ClientForms)
            {
                byte[] Buffer = new byte[] { (byte)(IntPtr)nint.Parse(Encoding.ASCII.GetBytes(p.MainWindowHandle.ToString())), 0x0D, (byte)Accepted.SendBufferSize };
                int Rec = Accepted.Receive(Buffer, 0, Buffer.Length, 0);
                for (int i = 0; i < Rec; i++)
                {

                    switch (Rec)
                    {
                        //int data = Rec;
                        // int Data = 0 + Rec;
                        case 0:
                            {
                                do
                                {
                                    Array.Resize(ref Buffer, Rec);
                                }
                                while (Rec > 0);
                                break;
                            }
                        default:
                            {
                                if (Rec > 0)
                                {
                                    while (p.MainWindowHandle != IntPtr.Zero)
                                    {
                                        Desktop.Robot.Robot WM_char = new Desktop.Robot.Robot();
                                        WM_char.GetMousePosition();
                                        Array.Resize(ref Buffer, Rec);
                                        string Data = Encoding.ASCII.GetString(Buffer, 0, Rec);
                                        richTextBox1.Text += Data.ToString();
                                        foreach (string Files in FilePaths)
                                        {
                                            var Proc = Process.Start(Files);
                                            SoundPlayer S = new SoundPlayer();
                                            try
                                            {

                                            }
                                            catch (WebException ex)
                                            {

                                            }
                                        }


                                    }
                                }
                            }
                            break;
                    }
                }
            }
            return IntPtr.Zero;


            return H.Cursor.Handle;
        }
        public List<Process> ClientHabboProcs = new List<Process>();
        public IntPtr RecvMsg;
        public string StreamMessage(string msg)
        {
            while (msg.Length > 0)
            {
                Desktop.Robot.Robot wm_char = new Desktop.Robot.Robot();
                wm_char.CombineKeys(Desktop.Robot.Key.Control, Desktop.Robot.Key.V);
                wm_char.CombineKeys(Desktop.Robot.Key.Enter, Desktop.Robot.Key.Enter);
                webView21.ExecuteScriptAsync(msg);
                var Msg = new StringContent(msg, Encoding.ASCII, "application/json");
                byte[] Buffer = Encoding.ASCII.GetBytes(Msg.ToString());
                using (var Memstream = new MemoryStream(Buffer))
                {
                    Memstream.Read(Buffer, 0, Buffer.Length);
                    var Bw = new BinaryConverter();
                    try
                    {
                        foreach (Process Proc in ClientHabboProcs)
                        {
                            if (Proc.MainWindowHandle != IntPtr.Zero)
                                foreach (byte b in Buffer)
                                {
                                    while (Proc.MainWindowHandle != IntPtr.Zero)
                                    {
                                        var FSdATA = wm_char.CombineKeys(Desktop.Robot.Key.Control, Desktop.Robot.Key.V, Desktop.Robot.Key.Enter);
                                        byte[] PostMsgByte = new byte[] { (byte)int.Parse(FSdATA.ToString()) };
                                        var MsgDat = new StringContent(Encoding.ASCII.GetString(Buffer) + Encoding.ASCII.GetString(PostMsgByte), Encoding.ASCII, "application/json");


                                        while (FSdATA != null)
                                        {
                                            byte[] DecodeInt = Encoding.ASCII.GetBytes(MsgDat.ToString());
                                            AccessFile.Write(DecodeInt, 0, AcceptedHandler);
                                            using (var MemstreamFile = new FileStream(AccessFile.Name, FileMode.Open, FileAccess.ReadWrite))
                                            {
                                                OpenFileDialog ofd = new OpenFileDialog();
                                                ofd.FileName = AccessFile.Name.ToString();
                                                Process[] ClientsWIndows = Process.GetProcessesByName(ofd.FileName);
                                                foreach (Process p in ClientsWIndows)
                                                {
                                                    BinaryWriter bw = new BinaryWriter(new MemoryStream(new byte[] { (byte)p.MainWindowHandle }));
                                                    bw.Write(DecodeInt, int.Parse(p.MainWindowTitle.ToString()), AcceptedHandler);
                                                    StreamWriter sw = new StreamWriter(bw.ToString());
                                                    sw.Write(msg);
                                                    sw.Write(DecodeInt);
                                                    foreach (byte Buf in DecodeInt)
                                                    {

                                                    }





                                                    foreach (byte windowHandle in PostMsgByte)
                                                    {
                                                        byte[] hwnd = Encoding.Default.GetBytes(p.MainWindowHandle.ToString());

                                                        PostIndex(hwnd, PostMsgByte);
                                                        PostIndex(hwnd, DecodeInt);
                                                        PostIndex(PostMsgByte, hwnd);
                                                        PostIndex(DecodeInt, hwnd);


                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                        }
                    }
                    catch (Exception ex)
                    {
                        checkedListBox1.Items.Add(ex.Message.ToString());
                    }
                }
            }
            return StreamMessage(msg);
        }
        public Socket AcceptedClient;
        public static List<Process> Emulator = new List<Process>();
        public Process[] ClientList = { };
        public IntPtr Wm_charClick()
        {
            Desktop.Robot.Robot WM_Char = new Desktop.Robot.Robot();
            WM_Char.Click();
            WM_Char.GetMousePosition();
            WM_Char.CombineKeys(Desktop.Robot.Key.Control, Desktop.Robot.Key.Enter);
            WM_Char.CombineKeys(Desktop.Robot.Key.Enter, Desktop.Robot.Key.Enter);


            return IntPtr.Zero;
        }
        public string PostIndex(byte[] Client, byte[] server)
        {
            foreach (byte b in Client)
            {
                for (int i = 0; i < server.Length; i++)
                {
                    server[i] += Client[i];
                    server[i].Equals(Client[i]);
                }
            }
            return PostIndex(server, Client);

        }
        public int AcceptedHandler;
        public IntPtr OpenReadByte(Socket e)
        {
            string path = "";
            byte[] FsStream = File.ReadAllBytes(path);
            int rec = e.Receive(FsStream, 0, FsStream.Length, 0);


            if (rec > 0)
            {
                AcceptedHandler = rec;

                Array.Resize(ref FsStream, rec);
                string msg = Encoding.ASCII.GetString(FsStream, 0, FsStream.Length);
                Console.WriteLine(msg);
                while (Process.GetCurrentProcess().MainWindowHandle != IntPtr.Zero)
                {
                    try
                    {

                        using (var Binaryw = new BinaryWriter(new MemoryStream(FsStream, 0, FsStream.Length)))
                        {
                            Binaryw.Write(msg);
                            foreach (byte B in FsStream)
                            {
                                MemoryStream MS = new MemoryStream(FsStream);
                                MS.Read(FsStream, 0, FsStream.Length);
                                byte[] Hwnd = new byte[] { (byte)nint.Parse(Process.GetCurrentProcess().MainWindowHandle.ToString()), (byte)e.SendBufferSize, 0x0D };
                                for (int i = 0; i < Hwnd.Length; i++)
                                {
                                    Hwnd[i] = B;
                                    Hwnd[i] = FsStream[i];
                                    PostIndex(FsStream, Hwnd);

                                    PostIndex(Hwnd, FsStream);
                                }


                            }
                        }
                    }
                    catch (SocketException Ex)
                    {
                        Console.WriteLine(Ex.Message.ToString());

                    }
                }
            }

            foreach (Process p in ClientHabboProcs)
            {

                try
                {
                    Desktop.Robot.Robot WMchar = new Desktop.Robot.Robot();
                    webView21.Source = new Uri("https://www.habbo.com/client");
                    webView21.Source = new Uri("https://www.localhost:30001");
                    //WMchar.CombineKeys(Desktop.Robot.Key.Control, Desktop.Robot.Key.V);

                    WMchar.Click();
                    WMchar.CombineKeys(Desktop.Robot.Key.Enter);
                    WMchar.CombineKeys(Desktop.Robot.Key.Control, Desktop.Robot.Key.V);
                    WMchar.CombineKeys(Desktop.Robot.Key.Enter, Desktop.Robot.Key.Enter);

                    byte[] Accepted = Encoding.ASCII.GetBytes(PostBufferMsg().ToString());
                    p.Equals(e.Receive(Accepted, 0, int.Parse(p.MainWindowHandle.ToString()), 0));
                    var Hwnd = p.MainWindowHandle == e.Receive(Accepted, 0, Accepted.Length, 0);
                    Array.Resize(ref Accepted, (int)p.MainWindowHandle);
                }
                catch (Exception ex)
                {
                    Socket AcceptedSock = e.Accept();
                    byte[] Buffer = new byte[e.SendBufferSize];
                    int xrec = AcceptedSock.Receive(Buffer, 0, Buffer.Length, 0);
                    int recHwnd = e.Receive(Buffer, 0, Buffer.Length, 0);
                    if (rec > 0)
                    {
                        Array.Resize(ref Buffer, rec);
                        checkedListBox1.Items.Add(Encoding.ASCII.GetString(Buffer, 0, rec));

                    }
                    {
                        Array.Resize(ref Buffer, rec);
                        checkedListBox1.Items.Add(Encoding.ASCII.GetString(Buffer, 0, rec));
                        richTextBox1.Text += "Incomming message";
                        listView1.Items.Add(p.MainWindowTitle.ToString());

                        using (var BW = new BinaryWriter(new MemoryStream(new byte[] { 0x0D, (byte)int.Parse(Encoding.Default.GetBytes(p.MainWindowHandle.ToString())), (byte)e.SendBufferSize, (byte)AcceptedSock.ReceiveBufferSize })))
                        {
                            BW.Write(Buffer, 0, Buffer.Length);
                            WebRequest GetConnection = (HttpWebRequest)WebRequest.Create("http://localhost:30001");
                            GetConnection.Method = "GET";

                            Stream OBJ = GetConnection.GetResponse().GetResponseStream();
                            StreamReader SR = new StreamReader(OBJ);
                            byte[] DefaultMsg = Encoding.ASCII.GetBytes(SR.ReadToEnd().ToString());
                            foreach (byte b in DefaultMsg)
                            {

                                byte[] Hwnd = new byte[] { (byte)int.Parse(Encoding.Default.GetBytes(SR.ReadToEnd().ToString())), (byte)int.Parse(Encoding.Default.GetBytes(p.MainWindowHandle.ToString())) };
                                PostIndex(Buffer, Hwnd);

                                PostIndex(Hwnd, Buffer);
                                PostIndex(Buffer, Hwnd);
                                richTextBox1.Text += ex.Message.ToString();

                            }

                        }

                    }



                }
            }


            return OpenReadByte(e);

        }
        public Socket ServerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);



        public async Task HostStuffOnLocalhostAsync()
        {
            var listenerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            listenerSocket.Bind(new IPEndPoint(IPAddress.Any, 1320));
            listenerSocket.Listen();

            Form1 Client = new Form1();


            Socket acceptedSocket = listenerSocket.Accept();
            byte[] Buffer = new byte[AcceptedSocket.SendBufferSize];

            int rec = acceptedSocket.Receive(Buffer, 0, Buffer.Length, 0);


            ServeContentAsync(acceptedSocket);
            string Msg = Encoding.ASCII.GetString(Buffer, 0, rec);


            while ((acceptedSocket = await listenerSocket.AcceptAsync()) is not null)
            {

                ServerSocket = acceptedSocket;

                _ = ServeContentAsync(acceptedSocket);
                richTextBox1.Text += acceptedSocket.RemoteEndPoint.ToString() + DateTime.Now;
                ServeContentAsync(acceptedSocket);
                // fire and forget a task to handle the accepted connection



                NetworkStream.Write(Encoding.ASCII.GetBytes(Msg));





            }

        }
        public static NetworkStream NetworkStream { get; private set; }
        public async Task SendResponseAsync(NetworkStream stream, string path)
        {
            // now if we want to send over content, we have first put its length into the 
            // Content-Length HTTP header, it tells the browser how many bytes to expect. It otherwise wouldnt know when to stop reading :)




            // if (rec > 0)



            string filePath = "\"C:\\Users\\akpoj\\OneDrive\\Desktop\\Load.html\"";
            if (!File.Exists(filePath))
                filePath = "\"C:\\Users\\akpoj\\OneDrive\\Desktop\\Load.html\"";
            OpenFileDialog OFFD = new OpenFileDialog();
            OFFD.FileName = "\"C:\\Users\\akpoj\\OneDrive\\Desktop\\JsFile.js\"";
            MessageBox.Show("conenction");

            byte[] contentBytes = File.ReadAllBytes(OFFD.FileName);

            string contentType = Path.GetExtension(filePath) switch
            {
                ".js" => "application/javascript",


                ".html" or _ => "text/html"

            };

            // First write the response header to the underlying stream. 
            using var sw = new StreamWriter(stream, Encoding.UTF8);
            sw.WriteLine("HTTP/1.1 200 OK");
            sw.WriteLine($"Content-Length: {contentBytes.Length}");
            sw.WriteLine($"Content-Type: {contentType}");
            sw.WriteLine("Connection: close");
            sw.WriteLine(); // End of headers

            await sw.FlushAsync();

            // Now we can copy the entire file to the http response stream
            await stream.WriteAsync(contentBytes);

            //  await stream.WriteAsync(contentBytes);
            NetworkStream = stream;
            //    await stream.WriteAsync(PromptUser);
            await stream.WriteAsync(contentBytes);



            stream.Write(contentBytes);
            ServerSocket.SendFile(OFFD.FileName);

            ServerSocket.Send(contentBytes, 0, contentBytes.Length, 0);


            //SetParent(SetWindow(), p.MainWindowHandle);





            await stream.FlushAsync();

            //
            // Flush the buffer to send the shit over the wire (not actually in this case, we're localhost)

        }
        public async Task ServeContentAsync(Socket socket)
        {



            using var ns = new NetworkStream(socket, ownsSocket: true);
            using var sr = new StreamReader(ns);

            while (true)
            {

                // richTextBox1.Text += StringMsg;
                string? requestLine = await sr.ReadLineAsync();
                if (string.IsNullOrEmpty(requestLine)) break;

                // Handle HTTP request headers, 
                // TODO: We can write simple HTTP Server to send that JS file over

                // We want to atleast parse the request line, i.e.
                // GET /some-path\r\n
                string[] requestLineParts = requestLine.Split(' ', StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries);
                if (requestLineParts.Length < 3) break; // we done, invalid

                string method = requestLineParts[0];
                string path = requestLineParts[1];

                // Keep reading headers until empty line i.e. \r\n\r\n
                while (true)
                {
                    string headerLine = await sr.ReadLineAsync();
                    if (string.IsNullOrEmpty(headerLine))
                        break; // If we found empty line, bail out of this while loop.

                    // TODO: Collect headers here if you care about them
                }

                await SendResponseAsync(ns, path);
            }


        }
        public char ReplaceHeader()
        {
            Desktop.Robot.Robot WM_Char = new Desktop.Robot.Robot();
            WM_Char.Click();
            WM_Char.CombineKeys(Desktop.Robot.Key.Control, Desktop.Robot.Key.V);
            WM_Char.CombineKeys(Desktop.Robot.Key.Enter, Desktop.Robot.Key.Enter);
            return ReplaceHeader();

        }
        public static List<byte[]> ObjectClients = new List<byte[]>();

        public IntPtr SendReqMsg(string Content)
        {
            while (webView21.Cursor.Handle != IntPtr.Zero)
            {
                [DllImport("user32.dll")]
                static extern IntPtr SetParent(IntPtr hwnd, IntPtr hwndNewParent);
                webView21.Source = new Uri("https://www.habbo.com/");
                HttpClient HClient = new HttpClient();
                HClient.BaseAddress = webView21.Source;
                using (var HttpReqMsg = new HttpRequestMessage(HttpMethod.Post, webView21.Source))
                {
                    var Conent = Newtonsoft.Json.JsonConvert.SerializeObject(Content);
                    var Encode = new StringContent(Conent, Encoding.UTF8, "application/json");
                    var Decode = new StringContent(Conent, Encoding.ASCII, "application/json");
                    HttpReqMsg.Content = Encode;
                    HttpReqMsg.Content = Decode;
                    HClient.Send(HttpReqMsg);
                    HClient.SendAsync(HttpReqMsg).Wait();
                    webView21.ExecuteScriptAsync(Conent + Content + Encode + Decode);
                    foreach (Process p in ClientHabboProcs)
                    {
                        SetParent(SendReqMsg(Content), p.MainWindowHandle);
                    }
                }

                foreach (Process p in ClientHabboProcs)
                {
                    SetParent(SendReqMsg(Content), p.MainWindowHandle);

                }
            }
            return IntPtr.Zero;

        }
        public WebRequest AcceptRequest(Socket e)
        {

            AcceptRequest(e).Equals((HttpWebRequest)WebRequest.Create("http://pastebin.com/raw/TF9MauVK"));
            AcceptRequest(e).Method = "GET";
            Stream ObjStreamReader = AcceptRequest(e).GetResponse().GetResponseStream();
            StreamReader SR = new StreamReader(ObjStreamReader);
            string Result = SR.ReadToEnd().ToString();
            if (Result != null)
            {
                string filepath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                DirectoryInfo d = new DirectoryInfo(filepath);

                foreach (var _file in d.GetFiles("*.swf"))
                {
                    OpenFileDialog OFD = new OpenFileDialog();
                    OFD.FileName = _file.ToString();



                    byte[] FileData = System.IO.File.ReadAllBytes(OFD.FileName);
                    ObjectClients.Add(FileData);

                    using (var Memstream = new MemoryStream(FileData))
                    {
                        BinaryWriter BW = new BinaryWriter(Memstream);
                        byte[] Data = Encoding.Default.GetBytes(ReplaceHeader().ToString());

                        BW.Write(Data);
                        foreach (byte b in Data)
                        {
                            for (int i = 0; i < Data.Length; i++)
                            {
                                Memstream.Read(new byte[] { Data[i] }, 0, Data.Length);
                                Memstream.Write(new byte[] { Data[i] }, 0, Data.Length);

                                BW.Write(new byte[] { Data[i] }, 0, Data.Length);
                                Memstream.Write(new byte[] { Data[i] }, 0, Data.Length);
                                BinaryReader BR = new BinaryReader(Memstream);

                                BR.Read(new byte[] { Data[i] }, 0, Data.Length);
                                Memstream.Read(new byte[] { Data[i] }, 0, Data.Length);






                            }

                            BW.Write(b);


                        }


                        foreach (var xfile in d.GetFiles("*.XML"))
                        {
                            OpenFileDialog OFD2 = new OpenFileDialog();
                            OFD2.FileName = xfile.ToString();
                            byte[] FileDataAsync = File.ReadAllBytes(OFD2.FileName);
                            ObjectClients.Add(FileDataAsync);

                        }


                        string path = "C:\\Users\\akpoj\\AppData\\Roaming\\Habbo Launcher\\downloads\\air\\179\\Habbo.exe";

                        FileStream FS = new FileStream(path, FileMode.Open, FileAccess.Read);

                        var Proc = new Process();
                        Proc.StartInfo.UseShellExecute = false;
                        Proc.StartInfo.RedirectStandardOutput = false;
                        Proc.StartInfo.RedirectStandardInput = false;
                        Proc.StartInfo.FileName = FS.Name;
                        Proc.Start();


                        Process[] Clients = Process.GetProcessesByName(Proc.ProcessName.ToString());

                        foreach (Process p in Clients)
                        {
                            try
                            {
                                if (p.MainWindowHandle != Proc.MainWindowHandle)
                                {
                                    byte[] Buffer = new byte[] { (byte)int.Parse(File.ReadAllBytes(FS.Name.ToString())), (byte)(IntPtr)int.Parse(Encoding.ASCII.GetBytes(p.MainWindowHandle.ToString())), (byte)e.SendBufferSize, (byte)e.ReceiveBufferSize, 0x0D, 0x01, 0x5A, 0x02 };
                                    foreach (byte[] Window in ObjectClients)
                                    {
                                        ObjectClients.Add(Buffer);

                                        int rec = e.Receive(Window, 0, Window.Length, 0);

                                        Proc.Kill();



                                        richTextBox1.Text += Result.ToString();

                                        foreach (char s in Encoding.ASCII.GetString(Window, 0, rec))
                                        {




                                            string resultRepalced = Encoding.ASCII.GetString(Buffer, 0, rec).Replace(s, ReplaceHeader());
                                            SendReqMsg(resultRepalced);


                                            string MsgDecoded = Encoding.ASCII.GetString(Buffer, 0, rec);
                                            Console.WriteLine(resultRepalced);

                                        }
                                    }
                                }

                            }
                            catch (WebException ex)
                            {
                                NetworkStream NS = new NetworkStream(e);
                                byte[] Message = Encoding.ASCII.GetBytes(ReplaceHeader().ToString());
                                NS.Write(Message, 0, Message.Length);

                            }
                        }

                    }

                    //
                    return AcceptRequest(e);

                }
            }
            return AcceptRequest(e);
        }
        public IntPtr PostMessageReq(Socket e)
        {
            return PostMessageReq(e);

        }
        public string InvokeThreadAsyncMethod()
        {
            var Filepath = "C:\\Users\\George\\Downloads\\Phillips, Craig & Dean - Revelation Song (Pseudo Video).mp3";
            try
            {

                OpenFileDialog OFD = new OpenFileDialog();
                OFD.FileName = Filepath;
                if (OFD.FileName.ToString().Length >= 0)

                {
                    SoundPlayer S = new SoundPlayer(Filepath);
                    S.Play();

                }
            }
            catch (WebException webEx)
            {

                SoundPlayer S = new SoundPlayer(Filepath);
                S.Play();
            }
            return InvokeThreadAsyncMethod();

        }
        static uint DOWN = 0x0002;
        static uint UP = 0x0004;
        [DllImport("user32.dll")]
        static extern void mouse_event(uint dwFlags, int dx, int dy, uint dwData, int dwExtraInfo);

        static void Click()
        {
            mouse_event(DOWN, 800, 800, 0, 0);
            Thread.Sleep(100);
            mouse_event(UP, 800, 800, 0, 0);
        }
        public int InterceptClientId()
        {
            [DllImport("user32.dll", SetLastError = true)]
            static extern void keybd_event(byte Bscan, byte bKey, int dwFlags, int dwExtraInfo);
            [DllImport("user32.dll")]
            static extern void mouse_event(uint dwFlags, int dx, int dy, uint dwData, int dwExtraInfo);
            static extern IntPtr SetParent(IntPtr hwndChild, IntPtr hwndNewParent);
            const uint Mouse_Down = 0x0002;
            const uint Mouse_up = 0x0004;
            Desktop.Robot.Robot wm_char = new Desktop.Robot.Robot();
            keybd_event(0x01, 0, 0x0000, 0);
            keybd_event(0x00, 0, 0x0001, 0);
            keybd_event(0x0D, 0, 0x0000, 0);
            mouse_event(DOWN, MousePosition.X, MousePosition.Y, 0, 0);
            mouse_event(UP, MousePosition.X, MousePosition.Y, 0, 0);
            SetParent(InterceptClientId(), Mainproc.MainWindowHandle);
            using (BinaryReader BR = new BinaryReader(new MemoryStream(Encoding.Default.GetBytes(Mainproc.StandardOutput.ToString()))))
            {
                wm_char.MouseMove(int.Parse(Mainproc.MainWindowHandle.ToString()), int.Parse(Mainproc.MainWindowHandle.ToString()));
                wm_char.Click();
                BR.Read(new byte[] { (byte)Mouse_up, (byte)Mouse_Down });
            }

            return MousePosition.X;
        }

        public byte[] PostClientId()
        {

            [DllImport("user32.dll", SetLastError = true)]
            static extern void keybd_event(byte Bkey, byte Bscan, int dwFlags, int dwExtraInfo);
            Desktop.Robot.Robot wm_char = new Desktop.Robot.Robot();
            List<byte[]> ArraySegmenet = new List<byte[]>();
            HttpClient hclient = new HttpClient(); HClient.BaseAddress = new Uri("https://www.habbo.com/hotel/logout");
            ArraySegmenet.Add(PostClientId());
            if (HClient.BaseAddress.ToString().Length >= 0)
            {
                using (BinaryWriter BW = new BinaryWriter(new MemoryStream(Encoding.UTF8.GetBytes(Mainproc.StandardOutput.ToString()))))
                {
                    HttpRequestMessage HMessage = new HttpRequestMessage(HttpMethod.Post, "http://localhost:443");
                    List<object> ClientModules = new List<object>();
                    Control RichTextBox = new Control();
                    var HMessageItem = new RichTextBox();
                    HMessageItem.Handle.Equals(Mainproc.MainWindowHandle);
                    HMessageItem.Dock = DockStyle.Fill;
                    [DllImport("user32.dll")]
                    static extern IntPtr SetParent(IntPtr Hwndchild, IntPtr hwndNewParent);
                    SetParent(HMessageItem.Handle, Mainproc.MainWindowHandle);
                    HMessageItem.Show();
                    SetParent(HMessageItem.Handle, Mainproc.MainWindowHandle);
                    HMessageItem.Show();
                    HMessageItem.CanSelect.Equals(true);
                    RichTextBox = HMessageItem;
                    ClientModules.Add(RichTextBox);
                    foreach (var items in ClientModules)
                    {
                        var InvokeAsync = RichTextBox.Invoke((System.Windows.Forms.MethodInvoker)delegate { keybd_event(0x00, 0, 0x0001, 0); keybd_event(0x0D, 0, 0x0000, 0); SendKeys.Send("^V"); SendKeys.Send("{ENTER}"); wm_char.GetMousePosition(); mouse_event(DOWN, MousePosition.X, MousePosition.Y, 0, 0); });
                        HMessage.Content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(InvokeAsync.ToString()), Encoding.UTF8, "application/json");
                        webView21.Source = new Uri("http://69.172.200.161");
                        var SendAsync = HClient.SendAsync(HMessage);
                        SendAsync.Wait(ClientModules.Count);
                        webView21.ExecuteScriptAsync(SendAsync.ToString());

                    }




                    return Encoding.Default.GetBytes(Mainproc.StandardInput.ToString());
                }
            }

            return PostClientId();
        }
        public class HMessage
        {
            public string MethodInvoker { get; set; }
            public HMessage(Socket e)
            {
                const int CTRL = 0x11;
                const int V = 0x56;
                MethodInvoker = PostMessage();
                MethodInvoker.Equals((PostMessage()));
                MethodInvoker.Equals((String)PostMessage());
                MethodInvoker = (string)PostMessage();

            }
            public string PostMessage()
            {
                SendKeys.Send("^V");
                SendKeys.Send("{ENTER}");
                [DllImport("user32.dll", SetLastError = true)]
                static extern void keybd_event(byte Bscan, byte Bkey, int dwFlags, int dwExtraInfo);
                Desktop.Robot.Robot wm_char = new Desktop.Robot.Robot();
                const int CTRL = 0x11;
                const int V = 0x56;
                const int Return = 0x0D;

                keybd_event(0x00, 0, 0x0001, 0); keybd_event(0x01, 0, 0x0000, 0); keybd_event(CTRL, 0, 0x0000, 0); keybd_event(CTRL, 0, 0x00001, 0); keybd_event(V, 0, 0x0000, 0); keybd_event(V, 0, 0x0000, 0); keybd_event(Return, 0, 0x0000, 0); keybd_event(Return, 0, 0x0001, 0);
                wm_char.GetMousePosition();
                wm_char.MouseMove(MousePosition.X, MousePosition.Y);
                wm_char.GetMousePosition();
                wm_char.CombineKeys(Desktop.Robot.Key.Control, Desktop.Robot.Key.V);
                SendKeys.Send("^V");
                Console.WriteLine(PostMessage());
                wm_char.CombineKeys(Desktop.Robot.Key.Shift, Desktop.Robot.Key.Enter);

                return MethodInvoker;
            }
        }
        public void AcceptIncomming(Socket e)
        {
            MessageBox.Show(e.RemoteEndPoint.ToString());
            HttpClient Hclient = new HttpClient();
            Hclient.BaseAddress = new Uri("https://www.habbo.com");
            using (var HttpReqMsg = new HttpRequestMessage(HttpMethod.Post, "http://localhost:443"))
            {
                HMessage SocketOutputRecieved = new HMessage(e);
                HttpReqMsg.Content = new StringContent(SocketOutputRecieved.MethodInvoker, Encoding.ASCII, "application/json");
                var SendAsync = Hclient.SendAsync(HttpReqMsg);
                SendAsync.Wait(int.Parse(e.Handle.ToString()));
                webView21.Source = new Uri("http://69.172.200.161");
                foreach (var items in ClientHabboProcs)
                {
                    [DllImport("user32.dll", SetLastError = true)]
                    static extern IntPtr SetParent(IntPtr hwndChild, IntPtr hwndNewParent);
                    SetParent(e.Handle, items.MainWindowHandle);
                    SetParent(items.Handle, e.Handle);
                    SetParent(webView21.Handle, e.Handle);
                    SetParent(webView21.Handle, items.MainWindowHandle);
                }

                webView21.ExecuteScriptAsync(File.ReadAllText("C:\\Users\\Georg\\OneDrive\\Desktop\\PostMessage.js") + SendAsync.ToString());


            }


            richTextBox1.Text += e.RemoteEndPoint.ToString() + DateTime.Now.ToString();


        }
        public void Socket_Accepted(Socket e)
        {
            var Filepath = "\"C:\\Users\\George\\Downloads\\Phillips, Craig & Dean - Revelation Song (Pseudo Video).wav\"";
            OpenFileDialog OFD = new OpenFileDialog();

            AcceptIncomming(e);
            AcceptIncomming(e);
            PostMessageReq(e);
            ClientSock.Close();
            ClientSock.Dispose();
            ClientSock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            SocketAsyncEventArgs EventArgs = new SocketAsyncEventArgs();
            EventArgs.SetBuffer(new byte[e.SendBufferSize]);
            EventArgs.SetBuffer(new byte[e.ReceiveBufferSize]);
            ClientSock.Equals(e.AcceptAsync(EventArgs));

            Console.Write(true);
            ClientSock = e.Accept();
            Console.Write(false);
            ClientSock.AcceptAsync(EventArgs);
            listView2.Items.Add(e.RemoteEndPoint.ToString());


        }
        public static List<Process> ClientProcs = new List<Process>();
        public HabboClient ActiveWindow = new HabboClient();
        public IntPtr LoadClient()
        {
            WebRequest GetReq = (HttpWebRequest)WebRequest.Create("https://www.localhost:443");
            GetReq.Method = "GET";
            Stream ObjstreamReader = GetReq.GetResponse().GetResponseStream();
            StreamReader SR = new StreamReader(ObjstreamReader);
            string rESULT = SR.ReadToEnd().ToString();
            if (rESULT != null)
            {
                Desktop.Robot.Robot wm_char = new Desktop.Robot.Robot();
                wm_char.Click();

            }




            return IntPtr.Zero;

        }
        public OpenFileDialog Filestream { get; set; }
        public Container ContainerClient = new Container();
        public Process Kendax = new Process();

        public HabboClient ContainerForm = new HabboClient();

        const string UserHostFile = "C:\\Users\\Desktop\\AppData\\Roaming\\Habbo Launcher\\downloads\\air\\349\\Habbo.exe";


        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                ClientSock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                Mainproc = new Process();
                Mainproc.StartInfo.UseShellExecute = false;
                Mainproc.StartInfo.RedirectStandardError = false;
                Mainproc.StartInfo.RedirectStandardInput = true;
                Mainproc.StartInfo.RedirectStandardOutput = true;
                Mainproc.StartInfo.StandardInputEncoding = Encoding.UTF8;
                var Filename = UserHostFile.Replace("Desktop", Environment.UserName);
                Mainproc.StartInfo.FileName = Filename;
                Mainproc.Start();
                ClientSock.Connect("69.172.200.161", 443);

                webView23.Source = new Uri("https://www.youtube.com/watch?v=imQGaX_ZdiI");
                HabboClient H = new HabboClient();
                H.TopLevel = false;
                H.TopMost = false;

                panel3.Controls.Add(H);

                ClientProcs.Add(Mainproc);


                H.Show();
                ContainerForm = H;
                L = new Listener(443);
                L.SocketAccepted += new Listener.SocketAcceptedHandler(Socket_Accepted);
                L.Start();


                [DllImport("user32.dll")]
                static extern IntPtr SetParent(IntPtr hwnd, IntPtr hwndNewParent);
                SetParent(Mainproc.MainWindowHandle, panel8.Handle);
                //SetParent(Proc.MainWindowHandle, H.PanelHandle
                C = new Container();
                C.TopMost = false;
                C.TopLevel = false;
                //C.TopLevelControl = false;
            }
            catch (WebException webEx)
            {
                OpenFileDialog OFD = new OpenFileDialog();
                MessageBox.Show("Select Client File from directory" + Environment.UserName.ToString() + webEx.Message.ToString() + DateTime.Now.ToString());
                if (Mainproc.ProcessName.ToString().Length <= 1)
                {
                    OFD.ShowDialog();
                    if (OFD.ShowDialog() == DialogResult.OK)
                    {
                        Console.Write(false);
                        Mainproc.StartInfo.FileName = OFD.FileName;
                        Mainproc.Handle.Equals(ClientSock.Handle);
                        Mainproc.MainWindowHandle.Equals(ClientSock.Handle);
                        ClientSock.Handle.Equals(Mainproc.MainWindowHandle);
                        Console.Write(true);
                    }
                }
                webView23.Source = new Uri("https://www.google.com");
                ClientSock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                Mainproc = new Process();
                Mainproc.StartInfo.UseShellExecute = false;
                Mainproc.StartInfo.RedirectStandardError = false;
                Mainproc.StartInfo.RedirectStandardInput = true;
                Mainproc.StartInfo.RedirectStandardOutput = true;
                Mainproc.StartInfo.StandardInputEncoding = Encoding.UTF8;
                //OpenFileDialog OFD = new OpenFileDialog();

                Mainproc.Start();
                ClientSock.Connect("69.172.200.161", 443);

                webView23.Source = new Uri("https://www.youtube.com/watch?v=imQGaX_ZdiI");
                HabboClient H = new HabboClient();
                H.TopLevel = false;
                H.TopMost = false;

                panel3.Controls.Add(H);

                ClientProcs.Add(Mainproc);


                H.Show();
                ContainerForm = H;
                L = new Listener(443);
                L.SocketAccepted += new Listener.SocketAcceptedHandler(Socket_Accepted);
                L.Start();


                [DllImport("user32.dll")]
                static extern IntPtr SetParent(IntPtr hwnd, IntPtr hwndNewParent);
                SetParent(Mainproc.MainWindowHandle, panel8.Handle);
                //SetParent(Proc.MainWindowHandle, H.PanelHandle
                C = new Container();
                C.TopMost = false;
                C.TopLevel = false;

            }



        }


        public void AddMessage(nint message)
        {
            listView1.Items.Add(message.ToString() + "panel");
            PanelWindows.Add(message);
        }
        public List<nint> PanelWindows = new List<nint>();

        public Socket Client_socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        public IntPtr ClickX()
        {
            Process.GetProcesses();

            Desktop.Robot.Robot WMchar = new Desktop.Robot.Robot();
            webView21.Source = new Uri("https://www.habbo.com/client");
            webView21.Source = new Uri("https://www.localhost:30001");
            //WMchar.CombineKeys(Desktop.Robot.Key.Control, Desktop.Robot.Key.V);

            WMchar.Click();
            WMchar.CombineKeys(Desktop.Robot.Key.Enter);
            WMchar.CombineKeys(Desktop.Robot.Key.Control, Desktop.Robot.Key.V);
            WMchar.CombineKeys(Desktop.Robot.Key.Enter, Desktop.Robot.Key.Enter);
            var chars = "A@B#C!DEFG@HIª =JK½ = ½LM¶ =#N` Ø OPQ%R¥ STUVµõW X-^&*$#¬ =^!@+_)(/*-YZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[32];
            var random = new Random();
            Socket Client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            Client.Connect(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 30001));
            for (int i = 0; i < stringChars.Length; i++)
            {
                try
                {
                    stringChars[i] = chars[random.Next(chars.Length)];



                    var finalString = new String(stringChars);
                    var Data = WMchar.Type(finalString);
                    var Input = WMchar.CombineKeys(Desktop.Robot.Key.Enter);
                    var msg = Data + Input.ToString();
                    Client.Send(Encoding.ASCII.GetBytes(msg));
                    Client.Send(Encoding.Default.GetBytes(msg));
                    Client.Send(Encoding.UTF8.GetBytes(msg));
                    Client.Send(Encoding.BigEndianUnicode.GetBytes(msg));
                    Client.Send(Encoding.Latin1.GetBytes(msg));
                    Client.Send(Encoding.Unicode.GetBytes(msg));
                    Client.Send(Encoding.UTF32.GetBytes(msg));
                    Client.Send(Encoding.UTF32.GetBytes((msg)));
                    Client.Send(Encoding.UTF7.GetBytes(msg));

                }
                catch (SocketException ex)
                {
                    Process.GetCurrentProcess().WaitForInputIdle();
                    [DllImport("user32.dll")]
                    static extern IntPtr SetParent(IntPtr hwnd, IntPtr hwndNewParent);
                    SetParent(IntPtr.Zero, IntPtr.Zero);
                    SetParent(Process.GetCurrentProcess().MainWindowHandle, IntPtr.Zero);
                    richTextBox1.Text += ex.Message.ToString();
                    listView1.Items.Add("Error" + ex.Message + Client.Handle);
                }



            }
            return IntPtr.Zero;
        }

        public string PostBufferMsgAsync()
        {
            Desktop.Robot.Robot WM_Char = new Desktop.Robot.Robot();
            WM_Char.Click();
            WM_Char.CombineKeys(Desktop.Robot.Key.Control, Desktop.Robot.Key.V);
            WM_Char.CombineKeys(Desktop.Robot.Key.Enter, Desktop.Robot.Key.Enter);

            return "" + webView23.ExecuteScriptAsync("var elem = " + PostMessageAsync(this, null) + "; elem.parentNode.removeChild(elem);");

        }
        public byte[] SoundInfo()
        {

            var Filename = "C:\\Users\\George\\Downloads\\Phillips, Craig & Dean - Revelation Song (Pseudo Video).mp3";
            SoundPlayer S = new SoundPlayer(Filename);
            S.PlayLooping();

            return SoundInfo();

        }
        public string GetClinetSocket()
        {
            Socket Clinet = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            Clinet.Connect(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 443));
            byte[] Buffer = new byte[1032];
            Buffer = SoundInfo();
            Client.Send(Buffer, 0, Buffer.Length, 0);
            richTextBox1.Text += Encoding.ASCII.GetString(Buffer, 0, Buffer.Length);


            webView21.Source = new Uri("https://www.google.com");
            webView21.ExecuteScriptAsync("document.write('var oimg = document.createElement(\"img\"); oimg.src = \"https://www.google.com/images/branding/googlelogo/1x/googlelogo_color_272x92dp.png\"; document.body.appendChild(oimg);')");
            webView21.ExecuteScriptAsync("document.write('var oimg = document.createElement(\"img\"); oimg.src = \"http://localhost:443/\"; document.body.appendChild(oimg);')");
            return GetClinetSocket();


        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            HttpWebRequest WebReq = (HttpWebRequest)WebRequest.Create("https://www.youtube.com/watch?v=imQGaX_ZdiI");
            WebReq.Method = "GET";
            // Stream OBJ = WebReq.GetResponse().GetResponseStream();
            using (var GetReqStraem = WebReq.GetResponse().GetResponseStream())
            {

                Byte[] Content = Encoding.UTF8.GetBytes(PostBufferMsgAsync());
                GetReqStraem.Write(Content, 0, Content.Length);
                StreamReader sr = new StreamReader(GetReqStraem);
                listView1.Items.Add(sr.ReadToEnd().ToString() + Environment.NewLine);

                richTextBox1.Text += sr.ReadToEnd().ToString() + WebReq.RequestUri.ToString() + DateTime.Now.ToString() + Encoding.Default.GetString(Content);
                HttpClient Hclient = new HttpClient();
                Hclient.BaseAddress = new Uri("http://localhost:443/");
                using (var HttpReqMsg = new HttpRequestMessage(HttpMethod.Post, WebReq.RequestUri))
                {
                    HttpReqMsg.Content = new StringContent(GetClinetSocket().ToString(), Encoding.UTF8, "application/json");
                    var SendAsync = Hclient.SendAsync(HttpReqMsg);
                    SendAsync.Wait(WebReq.RequestUri.ToString().Length);
                    webView23.ExecuteScriptAsync(SendAsync.ToString());
                    GetClinetSocket();

                }

            }




        }
        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer5.Stop();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Interval = int.Parse(textBox1.Text.ToString());
            timer1.Start();
            timer5.Interval = 6903;



        }
        public IntPtr GetMessage(object Sender, EventArgs e)
        {
            _Load();

            return webView21.Cursor.Handle;
        }
        public string _Load()
        {
            MessageBox.Show("Connection");
            return _Load();

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {



        }
        public Socket Client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        public HttpClient HClient;
        public class Web : HttpClient
        {

            public void OpenMessage()
            {
                Form1 Main = new Form1();
                base.BaseAddress = Main.HClient.BaseAddress;
                using (var HttpRequestMessage = new HttpRequestMessage(HttpMethod.Post, base.BaseAddress))
                {
                    var Content = Encoding.ASCII.GetBytes(PostMessage());
                    var Encode = new StringContent(Content.ToString(), Encoding.ASCII);
                    HttpRequestMessage.Content = Encode;
                    base.SendAsync(HttpRequestMessage).Wait();

                }
            }
            public string PostMessage()
            {
                Desktop.Robot.Robot WM_Char = new Desktop.Robot.Robot();
                WM_Char.CombineKeys(Desktop.Robot.Key.Control, Desktop.Robot.Key.V);
                WM_Char.CombineKeys(Desktop.Robot.Key.Enter, Desktop.Robot.Key.Enter);


                return PostMessage();

            }
        }
        public void Open()
        {
            try
            {
                Client.Connect(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1337));
                byte[] Message = Encoding.ASCII.GetBytes("Hello world!");
                Client.Send(Message, 0, Message.Length, 0);

                Client.Disconnect(true);
            }
            catch (SocketException ex)
            {
                Client.Connect(new IPEndPoint(IPAddress.Parse("69.172.200.161"), 1337));
                byte[] Message = Encoding.ASCII.GetBytes("Hello world!");
                Client.Send(Message, 0, Message.Length, 0);


                string Readline = Console.ReadLine();
                while (Readline == null)
                {
                    WebRequest HttpReq = (HttpWebRequest)WebRequest.Create("https://www.habboEmulatorNetwork.000webhostapp.com");
                    HttpReq.Method = "GET";
                    Stream ObjStreamReader = HttpReq.GetResponse().GetResponseStream();
                    StreamReader SR = new StreamReader(ObjStreamReader);
                    string Result = SR.ReadToEnd().ToString();
                    if (Result != null)
                    {

                        WebClient WC = new WebClient();
                        WC.BaseAddress = HttpReq.RequestUri.ToString();
                        using (var stream = WC.OpenWrite("http://www.localhost:1337", "POST"))
                        {
                            HClient.BaseAddress = new Uri("https://pastebin.com/raw/TF9MauVK");
                            Web w = new Web();
                            w.OpenMessage();


                            byte[] Message2 = Encoding.ASCII.GetBytes("HttpMessage From Client");
                            stream.Write(Message2, 0, Message.Length);

                        }

                    }




                }
            }
        }
        public HttpClient ClientSender;
        public WebRequest GetReqSender;
        public static List<int> ProcessHwnd = new List<int>();
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {


            timer2.Interval = 3103;
            timer2.Start();


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public string PostClick(object sender, EventArgs e, int x, int y)
        {
            Desktop.Robot.Robot WM_Char = new Desktop.Robot.Robot();
            //WM_Char.MouseMove(x, y);
            // WM_Char.Click();
            var MessageInterval = (string)PostClick(sender, e, x, y);
            listView1.Items.Add(MessageInterval);
            return PostClick(sender, e, x, y);

        }
        public IntPtr RecieveHandle()
        {
            var handle = Process.GetProcessById(int.Parse(textBox2.Text.ToString()));
            listView1.Items.Add(handle.ToString() + "hwnd" + handle.ProcessName.ToString());

            //   RecieveHandle R = new RecieveHandle();

            var Proc = Process.GetProcessById(int.Parse(textBox2.Text.ToString()));
            Proc.WaitForInputIdle();
            Thread.Sleep(100);
            listView1.Items.Add(Proc.ProcessName.ToString());
            return
                webView21.Cursor.Handle;
        }
        public static IntPtr UserControlHandle { get; set; }
        public IntPtr dispatchEvent()
        {
            Desktop.Robot.Robot Wm_char = new Desktop.Robot.Robot();
            Wm_char.Click();

            return Process.GetCurrentProcess().Handle;
        }
        public string ClickEventInit(object sender, EventArgs e, IntPtr Set)
        {
            [DllImport("user32.dll")]
            static extern IntPtr SetParent(IntPtr hwnd, IntPtr HwndNewParent);
            SetParent(dispatchEvent(), IntPtr.Zero);
            SetParent(dispatchEvent(), Process.GetCurrentProcess().MainWindowHandle);
            SetParent(dispatchEvent(), Set);
            Set = dispatchEvent();
            Console.WriteLine(Set);
            listView1_SelectedIndexChanged(sender, e);
            listView1.Items.Add(Set.ToString());
            Desktop.Robot.Robot WM_char = new Desktop.Robot.Robot();
            WM_char.CombineKeys(Desktop.Robot.Key.Control, Desktop.Robot.Key.V);
            WM_char.CombineKeys(Desktop.Robot.Key.Enter, Desktop.Robot.Key.Enter);
            while (Set != IntPtr.Zero)
            {
                WM_char.GetMousePosition();
                char quotchar = '"';
                var EncodedMessage = "window.location=" + quotchar + "https://www.habbo.com/client" + quotchar + ";";
                var ConnectionMessage = "window.location=" + quotchar + "https://www.localhost:1337" + quotchar + ";";
                var ClickScriptQuote = "\r\nOpenSend();\r\nOpenConnection();\r\nvar dispatchEvent = document.createAttribute(\"dispatchEvent\");\r\nconsole.log(dispatchEvent);\r\nlet event = new MouseEvent(\"click\", {\r\n    bubbles: true,\r\n    cancelable: true,\r\n    clientX: 100,\r\n    clientY: 100\r\n    \r\n    });\r\nfunction OpenSend()\r\n{\r\n    for(var x  = 0 ; x<1032;x++)\r\n    {\r\n        const myEvent = new CustomEvent(event);\r\n        var element = document.elementFromPoint(x,x+1);\r\n        console.log(element+dispatchEvent+element+dispatchEvent+element+dispatchEvent+element+dispatchEvent);\r\n     //   element.setAttribute(\"dispatchEvent\",myEvent);\r\n    //    element.addEventListener(\"dispatchEvent\",myEvent);\r\n        element.dispatchEvent(event);\r\n        element.dispatchEvent(myEvent);\r\n        var XHR2 = new XMLHttpRequest();\r\n        XHR2.open(\"GET\",\"https://www.localhost:1337\");\r\n        var Data = OpenConnection();\r\n        window.location=\"https://www.habbo.com/\";\r\n        XHR2.send(Data);\r\n        console.log(XHR.responseText.toString())\r\n    }\r\n}\r\nfunction OpenConnection()\r\n{\r\n    var XHR = new XMLHttpRequest();\r\n    XHR.open(\"POST\",\"https://www.localhost:1337\");\r\n    var Data = OpenSend();\r\n    XHR.send(Data);\r\n    console.log(XHR.responseText.toString());\r\nfor(var x = 0; x<1337;x++)\r\n{\r\n    const ElementData= [document.elementFromPoint(x,x)];\r\n    var oimg = document.createElement(\"img\");\r\n    for(const el of ElementData)\r\n    {\r\n        var elemntID = document.getElementById(el);\r\n    var ImgAttribute = document.createAttribute(\"classname\");\r\n    console.log(elemntID+ImgAttribute);\r\n    oimg.setAttribute(\"class\",elemntID);\r\n    }\r\n    oimg.setAttribute(\"src\",\"http://www.habbo.com/client\");\r\n\r\n    document.appendChild(oimg);\r\n    \r\n}\r\n\r\n}\r\n";
                var EncodeData = EncodedMessage + ConnectionMessage + ClickScriptQuote;
                var String_content = new StringContent((string)EncodeData, Encoding.UTF8, "application/json");

                timer2.Interval = 1429;

                timer2.Start();



            }



            return ClickEventInit(sender, e, Set);

        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            Desktop.Robot.Robot WM_char = new Desktop.Robot.Robot();
            WM_char.CombineKeys(Desktop.Robot.Key.Control, Desktop.Robot.Key.V);
            WM_char.CombineKeys(Desktop.Robot.Key.Enter, Desktop.Robot.Key.Enter);
            WM_char.Click();

        }
        public List<HabboClient> _HClient = new List<HabboClient>();
        public Container C = new Container();
        public Container MDIparent { get; set; }
        public string ScriptMessage;
        public HabboClient ActiveWindow_ { get; set; }
        public Process[] ClientHabbo = { };
        public string LoadClient(object sender, EventArgs e)
        {
            string[] pages = {"https://www.pastebin.com/raw/TF9MauVK",
"https://cookie-cdn.cookiepro.com/consent/9a83bf35-71d7-4c89-9101-77220edee470/OtAutoBlock.js",
"https://cookie-cdn.cookiepro.com/scripttemplates/otSDKStub.js",
"https://accounts.google.com/gsi/client",
"https://images.habbo.com/habbo-web/america/en/app.77047271.css",
"https://images.habbo.com/habbo-web/america/en/vendor.0edcab33.js",
"https://images.habbo.com/habbo-web/america/en/scripts.7d39df5b.js",
"https://appleid.cdn-apple.com/appleauth/static/jsapi/appleid/1/en_US/appleid.auth.js",
"https://cookie-cdn.cookiepro.com/consent/9a83bf35-71d7-4c89-9101-77220edee470/9a83bf35-71d7-4c89-9101-77220edee470.json",
"https://images.habbo.com/habbo-web-l10n/com.json",
"https://images.habbo.com/habbo-web/america/en/assets/images/sprite.a51705e3.png",
"https://images.habbo.com/habbo-web/america/en/assets/images/sprite@2x.7942f80a.png",
"https://images.habbo.com/habbo-web/america/en/assets/images/backgrounds/hotel.5e0e63d8.png",
"https://cookie-cdn.cookiepro.com/scripttemplates/202311.1.0/otBannerSdk.js",
"https://cookie-cdn.cookiepro.com/consent/9a83bf35-71d7-4c89-9101-77220edee470/96dc850a-6664-4e15-915a-4e65cb823eec/en.json",
"https://connect.facebook.net/en_US/sdk.js",
"https://images.habbo.com/habbo-web-l10n/com.json",
"https://images.habbo.com/habbo-web-news/en/production/front.html",
       " https://images.habbo.com/habbo-web/america/en/assets/images/sprite@2x.7942f80a.png",
        "https://images.habbo.com/habbo-web/america/en/assets/images/sprite.a51705e3.png",
      "  https://images.habbo.com/habbo-web/america/en/assets/fonts/UbuntuCondensed-latin.51eab248.woff2",
       " https://images.habbo.com/habbo-web/america/en/assets/fonts/UbuntuRegular-latin.dae8c8b9.woff2",
      "  https://cookie-cdn.cookiepro.com/scripttemplates/202311.1.0/assets/otFlat.json",
     "   https://cookie-cdn.cookiepro.com/scripttemplates/202311.1.0/assets/v2/otPcTab.json",
      "  https://cookie-cdn.cookiepro.com/scripttemplates/202311.1.0/assets/otCommonStyles.css",
       " https://images.habbo.com/habbo-web-pages/production/common/box_learn_how_to_stay_safe.en.html",
      "  https://images.habbo.com/habbo-web-pages/production/common/box_parents_guide.en.html",
        "https://www.habbo.com/extradata/private/moderations/recentModerations",
       " https://www.habbo.com/api/client/permissions",
      "  https://images.habbo.com/web_images/habbo-web-articles/lpromo_anniversary_sept24.png",
        "https://images.habbo.com/web_images/habbo-web-articles/lpromo_anniversary_sept24_thumb.png",
       " https://images.habbo.com/web_images/habbo-web-articles/lpromo_general_sept24.png",
      "  https://images.habbo.com/web_images/habbo-web-articles/lpromo_general_sept24_thumb.png",
       " https://images.habbo.com/web_images/habbo-web-articles/lpromo_dayofthedeadoffer_sep24.png",
      "  https://images.habbo.com/web_images/habbo-web-articles/lpromo_dayofthedeadoffer_sep24_thumb.png",
      "  https://images.habbo.com/web_images/habbo-web-articles/lpromo_apidocumentation_sep24.png",
       " https://images.habbo.com/web_images/habbo-web-articles/lpromo_apidocumentation_sep24_thumb.png",
      "  https://images.habbo.com/web_images/habbo-web-articles/lpromo_wisharoundworld24.png",
       " https://images.habbo.com/web_images/habbo-web-articles/lpromo_wisharoundworld24_thumb.png",
        "https://images.habbo.com/web_images/habbo-web-articles/lpromo_rhythmicfun24.png",
        "https://images.habbo.com/web_images/habbo-web-articles/lpromo_rhythmicfun24_thumb.png",
        "https://images.habbo.com/web_images/habbo-web-articles/lpromo_gen15_07.png",
        "https://images.habbo.com/web_images/habbo-web-articles/lpromo_gen15_07_thumb.png",
        "https://images.habbo.com/habbo-web/america/en/assets/images/landing/bg_topleft.c16c9d63.png",
        "https://images.habbo.com/habbo-web/america/en/assets/images/landing/bg_topright.00cd59c5.png",
        "https://images.habbo.com/habbo-web/america/en/assets/images/landing/bg_bottomleft.61999d1b.png",
        "https://images.habbo.com/habbo-web/america/en/assets/images/landing/bg_bottomright.0bb434c7.png",
        "https://images.habbo.com/habbo-web/america/en/assets/images/landing/h_pic.9e3bb5d3.png",
        "https://images.habbo.com/habbo-web/america/en/assets/images/landing/h_logo.09606b0e.png",
        "https://images.habbo.com/habbo-web/america/en/assets/images/landing/coll_pic.a26ac6d2.png",
        "https://images.habbo.com/habbo-web/america/en/assets/images/landing/coll_logo.db970961.png",
       " https://images.habbo.com/habbo-web/america/en/assets/images/landing/orig_pic.852d257e.png",
        "https://images.habbo.com/habbo-web/america/en/assets/images/landing/orig_logo.147d68e0.png",
       " https://www.habbo.com/habbo-imaging/avatar/hr-165-42.hd-205-14.ch-215-91.lg-280-1408.sh-290-81%2Cs-2.g-1.d-2.h-2.a-0%2C36777b211ddae28b75b4d366be601f88.png",
        "https://cookie-cdn.cookiepro.com/logos/static/ot_guard_logo.svg",
      "https://cookie-cdn.cookiepro.com/logos/static/cookiepro_logo.png",
      " https://cookie-cdn.cookiepro.com/logos/static/poweredBy_cp_logo.svg",
       "https://connect.facebook.net/en_US/sdk.js?hash=3479fbe154392fe4ad79a43736b22da4",
        "https://images.habbo.com/habbo-web/america/en/assets/images/favicon.08c747be.ico "};

            try
            {
                foreach (string s in pages)
                {

                    WebRequest GetReq = (HttpWebRequest)WebRequest.Create(s);

                    GetReq.Method = "GET";
                    Stream Obj = GetReq.GetResponse().GetResponseStream();
                    StreamReader SR = new StreamReader(Obj);
                    string Result = SR.ReadToEnd().ToString();
                    if (Result != null)
                    {
                        richTextBox3.Text += Result.ToString() + Environment.NewLine;
                        HttpClient Client = new HttpClient();
                        using (var HttpReqMsg = new HttpRequestMessage(HttpMethod.Post, GetReq.RequestUri))
                        {
                            foreach (HabboClient H in _HClient)
                            {
                                [DllImport("user32.dll")]
                                static extern IntPtr SetParent(IntPtr hwnd, IntPtr hwndNewParent);
                                SetParent(H.Handle, IntPtr.Zero);
                                //  SetParent(C.XPanel, IntPtr.Zero);
                                SetParent(H.Handle, panel4.Handle);
                                SetParent(H.Handle, IntPtr.Zero);

                                SetParent(H.Handle, panel5.Handle);




                            }
                        }
                    }
                }





            }
            catch (Exception ex)
            {
                richTextBox3.Text += ex.Message.ToString();
                foreach (HabboClient H in _HClient)
                {
                    [DllImport("user32.dll")]
                    static extern IntPtr SetParent(IntPtr hwnd, IntPtr hwndNewParent);
                    SetParent(H.Handle, IntPtr.Zero);
                    SetParent(C.XPanel, IntPtr.Zero);
                    SetParent(H.Handle, C.XPanel);
                    SetParent(H.Handle, C.YPanel);
                    Process.GetCurrentProcess().Refresh();

                    for (int index = 0; index < _HClient.Count; index++)
                    {
                        SetParent(_HClient[index].Handle, C.XPanel);
                        SetParent(_HClient[index].Handle, IntPtr.Zero);
                        SetParent(C.XPanel, IntPtr.Zero);
                        SetParent(IntPtr.Zero, C.XPanel);
                        SetParent(_HClient[index].Handle, C.YPanel);
                    }




                }
            }




            return LoadClient(sender, e);

        }
        public List<HabboClient> ClientWindows = new List<HabboClient>();


        public FileStream AccessFile;
        private void button3_Click(object sender, EventArgs e)

        {
            try
            {

                var Proc = new Process();
                Proc.StartInfo.UseShellExecute = false;
                OpenFileDialog OFD = new OpenFileDialog();
                string Path = "C:\\Users\\akpoj\\OneDrive\\Desktop\\NovoFantum\\NovoFantum\\bin\\x64\\Debug\\NovoFantum.exe";
                FileStream FS = new FileStream(Path, FileMode.Open, FileAccess.Read);
                Process P = Process.Start(FS.Name);
                while (P.MainWindowHandle != IntPtr.Zero)
                {
                    AccessFile = FS;

                    Process[] Procs = Process.GetProcessesByName(P.ProcessName);
                    foreach (Process p in Procs)
                    {
                        [DllImport("user32.dll")]
                        static extern IntPtr SetParent(IntPtr hwnd, IntPtr hwndNewParent);
                        SetParent(p.MainWindowHandle, ContainerClient.PanelHandle.Handle);
                        Thread.Sleep(100);
                        p.Refresh();
                        PanelHandles.Add(p.Handle);
                        PanelHandles.Add(p.MainWindowHandle);


                        p.WaitForInputIdle();

                    }
                }


            }
            catch (Exception ex)
            {
                var Proc = new Process();
                Proc.StartInfo.UseShellExecute = false;
                OpenFileDialog OFD = new OpenFileDialog();
                string Path = "C:\\Users\\akpoj\\source\\repos\\App\\Kendax\\Kendax\\bin\\x64\\Debug\\net8.0-windows\\Kendax.exe";
                FileStream FS = new FileStream(Path, FileMode.Open, FileAccess.Read);
                Process P = Process.Start(FS.Name);
                while (P.MainWindowHandle != IntPtr.Zero)
                {


                    Process[] Procs = Process.GetProcessesByName(P.ProcessName);
                    foreach (Process p in Procs)
                    {
                        PanelHandles.Add(p.Handle);
                        PanelHandles.Add(p.MainWindowHandle);

                        [DllImport("user32.dll")]
                        static extern IntPtr SetParent(IntPtr hwnd, IntPtr hwndNewParent);
                        SetParent(p.MainWindowHandle, ContainerClient.PanelHandle.Handle);
                        Thread.Sleep(100);
                        p.Refresh();

                        p.WaitForInputIdle();

                    }
                }

            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            [DllImport("user32.dll")]
            static extern IntPtr SetParent(IntPtr hwndParent, IntPtr hwndNewChild);
            SyncFromAllServersErrorCategory s;
            foreach (HabboClient c in ClientForms)
            {
                c.AwaitConnection(sender, e, AcceptedClient, ClientHabbo);

                timer3.Interval = int.Parse(c.Handle.ToString()) - 1000;

            }
            Uri Filepath = new Uri("file:///C:/Users/George/Desktop/ScriptFile.js");

            using (var WC = new WebClient())
            {
                WC.BaseAddress = "https://www.pastebin.com/edit/TF9MauVK";
                var data = WC.DownloadData(Filepath);
                string Result = Encoding.UTF8.GetString(data);
                ScriptMessage = Result;

                webView22.Source = new Uri("http://www.localhost:443");

                MessageBox.Show("script" + Result);



            }




            timer3.Start();



        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public string DataInject = null;

        public string PostMessageData()
        {
            Desktop.Robot.Robot wm_char = new Desktop.Robot.Robot();
            wm_char.CombineKeys(Desktop.Robot.Key.Control, Desktop.Robot.Key.V, Desktop.Robot.Key.Enter);
            var Filepath = "C:\\Users\\George\\Downloads\\Phillips, Craig & Dean - Revelation Song (Pseudo Video).wav";
            SoundPlayer S = new SoundPlayer(Filepath);
            S.Play();
            wm_char.GetMousePosition();

            return PostMessageData();

        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            var Filename = "C:\\Users\\George\\Desktop\\LoginHost.js";
            //  webView23.ExecuteScriptAsync("var elem = document.getelementByClassName('input').innerText="+PostMessageData()+File.ReadAllText(Filename));
            WebRequest GetReq = (HttpWebRequest)WebRequest.Create(webView23.Source.ToString());
            GetReq.Method = "GET";
            Stream OBJ = GetReq.GetResponse().GetResponseStream();
            StreamReader SR = new StreamReader(OBJ);
            HttpClient Hclient = new HttpClient();
            Hclient.BaseAddress = new Uri("http://localhost:443/");
            using (var HttpReqMsg = new HttpRequestMessage(HttpMethod.Post, webView23.Source))
            {
                HttpReqMsg.Content = new StringContent(Encoding.ASCII.GetString(File.ReadAllBytes(Filename)), Encoding.UTF8, "application/json");
                var senAsync = Hclient.SendAsync(HttpReqMsg);
                senAsync.Wait(SR.ReadToEnd().ToString().Length);
                webView23.ExecuteScriptAsync(senAsync.ToString());
                webView23.ExecuteScriptAsync(File.ReadAllText(Filename));


            }
            var ResultNode = SR.ReadToEnd().ToString();
            listView1.Items.Add(ResultNode.ToString() + Environment.NewLine);

        }



        private void label3_Click(object sender, EventArgs e)
        {

        }
        List<IntPtr> PanelHandles = new List<IntPtr>();
        public void AppendProc()
        {
            foreach (Process p in ClientHabboProcs)
            {
                listView1.Items.Add(p.MainWindowTitle.ToString());
                checkedListBox1.Items.Add(p);

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            timer3.Stop();
            Process Client = Process.GetProcessById(int.Parse(textBox3.Text.ToString()));
            Process[] Disposed = Process.GetProcessesByName(Client.ProcessName);
            foreach (var items in Disposed)
            {
                ClientHabboProcs.Add(items);
                try
                {
                    richTextBox4.Text += items.MainWindowHandle.ToString();
                    timer3.Interval = 8901;
                    timer3.Start();
                }
                catch (SocketException SockEx)
                {
                    timer3.Interval = 7189;
                    timer3.Start();
                }
                return;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }


        public class InvokedDelegate
        {
            public FileStream FS;
            public IntPtr PostMessage(Desktop.Robot.Robot Keycode)
            {
                Keycode.CombineKeys(Desktop.Robot.Key.Control, Desktop.Robot.Key.V);
                Keycode.CombineKeys(Desktop.Robot.Key.Shift, Desktop.Robot.Key.Enter);

                Form1 Main = new Form1();
                using (MemoryStream MS = new MemoryStream(Encoding.Default.GetBytes(ClientProcs[0].MainWindowHandle.ToString())))
                {
                    BinaryReader BR = new BinaryReader(MS, Encoding.Default);
                    BR.Read(Encoding.Default.GetBytes(PostClientRecieve()));
                    foreach (var items in ClientProcs)
                    {
                        Process[] Disposed = Process.GetProcessesByName(items.ProcessName);
                        byte[] Buffer = new byte[Disposed.Length];
                        for (int i = 0; i < Buffer.Length; i++)
                        {
                            Buffer[i] += Encoding.UTF32.GetBytes(Disposed[i].MainWindowHandle.ToString())[0];
                            Array.Resize<byte>(ref Buffer, BR.Read(new byte[] { Buffer[i] }));
                            FS.Write(Encoding.ASCII.GetBytes(PostClientRecieve()));
                            Main.BeginInvoke((System.Windows.Forms.MethodInvoker)delegate { SendKeys.Send("{ENTER}"); FS.Write(new byte[] { }); FS.Write(Buffer, 0, Buffer.Length); });
                            return Disposed[i].MainWindowHandle;
                        }
                    }
                    SendKeys.Send("" + PostClientRecieve() + "");
                    SendKeys.SendWait("" + PostClientRecieve());
                    SendKeys.Send("{ENTER}");
                    SendKeys.SendWait("{ENTER}");
                    Keycode.GetMousePosition();
                    Keycode.MouseMove(MousePosition.X, MousePosition.Y);
                    Keycode.Click();
                }
                return ClientHandles[0];
            }
            public virtual string PostClientRecieve()
            {
                [DllImport("user32.dll", SetLastError = true)]
                static extern void keybd_event(byte Bscan, byte Beky, int DwFlags, int DwExtraInfo);
                keybd_event(0x11, 0, 0x0000, 0);
                keybd_event(0x11, 0, 0x00001, 0);
                keybd_event(0x56, 0, 0x0000, 0);
                keybd_event(0x56, 0, 0x00001, 0);
                keybd_event(0x0D, 0, 0x0000, 0);
                keybd_event(0x0D, 0, 0x00001, 0);

                Desktop.Robot.Robot wm_char = new Desktop.Robot.Robot();
                Process[] Disposed = Process.GetProcessesByName(ClientProcs[0].ProcessName);
                for (int i = 0; i < Disposed.Length; i++)
                {
                    ClientProcs.Add(Disposed[i]);
                }
                foreach (System.Diagnostics.Process p in ClientProcs)
                {
                    [DllImport("user32.dll")]
                    static extern IntPtr SetParent(IntPtr hwndChild, IntPtr hwndNewParent);

                    SetParent(PostMessage(wm_char), (nint)p.MainWindowHandle);
                    SetParent(PostMessage(wm_char), (IntPtr)p.Handle);



                    return p.MainWindowTitle.ToString();
                }

                return PostClientRecieve();
            }
            public InvokedDelegate(HttpRequestMessage HMessage)

            {
                var Filename = "C:\\Users\\Desktop\\AppData\\Roaming\\com.sulake.habboair\\Local Store\\#SharedObjects\\fuselogin.sol";
                FS = new FileStream(Filename.Replace("Desktop", Environment.UserName), FileMode.Open, FileAccess.ReadWrite);
                Console.Write(PostMessage());



            }

            public string PostMessage()
            {
                Desktop.Robot.Robot wm_char = new Desktop.Robot.Robot();
                wm_char.CombineKeys(Desktop.Robot.Key.Control);
                SendKeys.Send("^V");
                [DllImport("user32.dll", SetLastError = true)]
                static extern void keybd_event(byte bScan, byte bKey, int dwFlags, int dwExtraInfo);
                keybd_event(0x0D, 0, 0x0001, 0);
                SendKeys.Send("{ENTER}");
                wm_char.CombineKeys(Desktop.Robot.Key.Control, Desktop.Robot.Key.V);
                wm_char.CombineKeys(Desktop.Robot.Key.Shift, Desktop.Robot.Key.Enter);
                keybd_event(0x11, 0, 0x0000, 0);
                keybd_event(0x11, 0, 0x0001, 0);
                keybd_event(0x56, 0, 0x0000, 0);
                keybd_event(0x56, 0, 0x00001, 0);
                keybd_event(0x0D, 0, 0x0000, 0);
                keybd_event(0x0d, 0, 0x0001, 0);
                SendKeys.Send("{ENTER}");
                return PostClientRecieve();
            }

        }
        private void button5_Click(object sender, EventArgs e)
        {

            Desktop.Robot.Robot Auto = new Desktop.Robot.Robot();

            Auto.GetMousePosition();
            Auto.CombineKeys(Desktop.Robot.Key.Control, Desktop.Robot.Key.Enter);
            foreach (var itemDisposen in ClientProcs)
            {
                itemDisposen.MainWindowHandle.Equals(panel8.Handle);
            }

            try
            {
                HttpClient Hclient = new HttpClient();
                Hclient.BaseAddress = new Uri("https://www.habbo.com/api/public/authentication/loginv2");
                using (var HttpReqMsg = new HttpRequestMessage(HttpMethod.Post, "http://localhost:443/Index.html"))
                {
                    InvokedDelegate InvokeAsync = new InvokedDelegate(HttpReqMsg);
                    HttpReqMsg.Content = new StringContent(InvokeAsync.PostClientRecieve(), Encoding.ASCII, "application/json");
                    var SendAsync = Hclient.SendAsync(HttpReqMsg);
                    SendAsync.Wait(Hclient.BaseAddress.ToString().Length);
                    webView21.ExecuteScriptAsync(SendAsync.ToString());


                }


            }
            catch (WebException webEx)
            {
                ClientSock.Close();
                ClientSock.Dispose();
                using (var sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp))
                {
                    sock.Connect("127.0.0.1", 443);
                    ClientSock = sock;
                }

                MessageBox.Show(webEx.Message.ToString() + "The connection was actively refused by the remote host" + DateTime.Now.ToString());
                ClientSock.Connect("69.172.200.161", 443);
            }


        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        public List<Process> WindowMemory = new List<Process>();
        public const string PublicKey = "function dispatchEvent()\r\n{\r\n  var XHR = new XMLHttpRequest();\r\n  XHR.open(\"POST\",\"https://www.habbo.com\");\r\n  for(var x = 0; x < 443;x++)\r\n  {\r\n    console.log(document.elementFromPoint(x,x));\r\n    var elem = document.elementFromPoint(x,x+1);\r\n    XHR.send(elem);\r\n    console.log(XHR.responseText);\r\n    var items = [];\r\n    let oimg = document.querySelectorAll(\"img\");\r\n    for(const el of oimg)\r\n    {\r\n      items.push(el);\r\n    }\r\n    for(var index = 0; index< items.length;index++)\r\n    {\r\n      itmes[0].src=\"http://localhost:443\";\r\n      items[index].src=\"http://localhost:443\";\r\n\r\n      \r\n    }\r\n  }\r\n}\r\n\r\nlet event = new MouseEvent(\"click\",{bubbles:true,cancelable:true,view:window});\r\n\r\nvar myEv = new CustomEvent(\"click\",dispatchEvent);\r\ndocument.addEventListener(\"click\",myEv);\r\ndocument.dispatchEvent(event);";
        public string MethodPost { get; set; }
        public Process Mainproc = new Process();
        public class invokeMethod : EventArgs
        {
            Socket ClientSock;
            public IntPtr PostMessage()
            {
                //Socket ClientSockMsg = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                TcpClient Client = new TcpClient();
                Client.Client = ClientSock;
                Form1 Main = new Form1();
                Client.Client.Send(Encoding.Default.GetBytes(Main.PostMethod()[0]));

                [DllImport("user32.dll")]
                static extern IntPtr SetParent(IntPtr hwndChild, IntPtr hwndNewParent);
                SetParent(IntPtr.Zero, Client.Client.Handle);
                Client.Client.Handle.Equals(Process.GetCurrentProcess().MainWindowHandle);
                SetParent(Process.GetCurrentProcess().MainWindowHandle, PostMessage());
                SetParent(Process.GetCurrentProcess().Handle, Client.Client.Handle);
                return Client.Client.Handle;

            }
            public invokeMethod(string message, IntPtr hwnd)
            {
                Console.Write(message);
                foreach (var items in Form1.ClientHandles)
                {
                    PostMessage();
                    [DllImport("user32.dll")]
                    static extern IntPtr SetParent(IntPtr hwndChild, IntPtr hwndNewParent);
                    SetParent(IntPtr.Zero, items);
                    SetParent(items, IntPtr.Zero);
                    SetParent(hwnd, IntPtr.Zero);
                    SetParent(hwnd, items);
                    SetParent(items, hwnd);
                    hwnd.Equals((IntPtr)items);
                    items.Equals((nint)hwnd);
                    SetParent(PostMessage(), items);

                }

            }
        }

        public string[] PostMethod()
        {
            Process[] Proc = Process.GetProcessesByName(Mainproc.ProcessName);
            foreach (System.Diagnostics.Process p in Proc)
            {

            }
            return PostMethod();

        }

        public string Content { get; set; }
        public string MessageContent()
        {
            [DllImport("user32.dll", SetLastError = true)]
            static extern void keybd_event(byte Bscan, byte Bkey, int DwFlags, int DwExtraInfo);
            SendKeys.Send("^V");
            SendKeys.Send("{ENTER}");
            keybd_event(0x0D, 0, 0x0000, 0);
            keybd_event(0x01, 0x0001, 0, 0);
            Desktop.Robot.Robot wm_char = new Desktop.Robot.Robot();
            wm_char.GetMousePosition();
            wm_char.MouseMove(MousePosition.X, MousePosition.Y);
            wm_char.Click();
            SendKeys.Send("^V");
            keybd_event(0x0D, 0, 0x0000, 0);
            keybd_event(0x01, 0x0001, 0, 0);
            wm_char.CombineKeys(Desktop.Robot.Key.Shift, Desktop.Robot.Key.Enter);
            keybd_event(0x0D, 0, 0x0000, 0);
            foreach (char c in MessageContent())
            {
                Content.Equals(" " + c.ToString().ToCharArray().ToString());
                Content = " " + c.ToString().ToCharArray().ToString();
                wm_char.Type(" " + c.ToString().ToCharArray().ToString());
                SendKeys.SendWait(Content);

                return Content;
            }
            return MessageContent();
        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            WebRequest GetMethod = (HttpWebRequest)WebRequest.Create("https://github.com/nomakta/Kendax-Silver/tree/master/Sulakore");
            GetMethod.Method = "GET";
            GetMethod.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/143.0.0.0 Safari/537.36 Edg/143.0.0.0");
            Stream OBJNode = GetMethod.GetResponse().GetResponseStream();
            StreamReader SR = new StreamReader(OBJNode);
            var Result = SR.ReadToEnd().ToString();
            const string Filepath = "C:\\Users\\George\\Desktop\\2step.js";
            if (Result.ToString().Length >= 0)
            {
                WebClient WC = new WebClient();
                WC.BaseAddress = new Uri("https://www.pastebin.com/raw/TF9Mauvk").ToString();
                Content.Equals(MessageContent());
                Content += "" + MessageContent();
                var PostReqStream = WC.OpenWrite(GetMethod.RequestUri, "POST");
                foreach (IntPtr hwnd in ClientHandles)
                {
                    invokeMethod MethodInvoker = new invokeMethod(Content, hwnd);
                    var DisposeModuleBtnEvent = MethodInvoker;

                    byte[] Buffer = Encoding.Default.GetBytes("{ENTER}" + DisposeModuleBtnEvent.ToString());
                    const string ScriptPostEvent = "var Items = []; let InputStream = document.QuerySelectorAll('input'); for(const el of InputStream){Items.push(el);} for(var x = 0; x < Items.length;x++){document.write(Items[x].outerHTML);}";
                    byte[] WebMessage = Encoding.UTF8.GetBytes(ScriptPostEvent + Convert.ToBase64String(Buffer, 0, Buffer.Length));
                    Desktop.Robot.Robot wm_char = new Desktop.Robot.Robot();
                    foreach (byte b in WebMessage)
                    {
                        richTextBox4.Text += Result;
                        wm_char.Type(Encoding.Default.GetString(Buffer).Replace("{ENTER}", "" + Content));

                        PostReqStream.Write(new byte[] { b }, 0, 0);
                        webView21.Source = new Uri("https://onlinesequencer.net/#t47");
                        webView21.ExecuteScriptAsync(System.IO.File.ReadAllText(Filepath));
                        webView21.ExecuteScriptAsync(PublicKey);
                        wm_char.CombineKeys(Desktop.Robot.Key.Control, Desktop.Robot.Key.V, Desktop.Robot.Key.Enter);
                        wm_char.GetMousePosition();
                        richTextBox4.Text += Result;
                        return;
                    }
                }
            }

        }


        private void button6_Click(object sender, EventArgs e)
        {
            DataInject = textBox4.Text.ToString();

        }
        public Process ProcHabboc;
        public Process[] ClientArray;
        public static HabboClient MainClient;

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

            var ProcHabbo = new Process();

            ProcHabboc = ProcHabbo;
            string path = "C:\\Users\\George\\AppData\\Roaming\\Habbo Launcher\\downloads\\air\\178\\Habbo.exe";
            try
            {

                ProcHabbo = Process.Start(path);

                WebRequest GetReQ = (HttpWebRequest)WebRequest.Create("https://www.localhost:443");
                GetReQ.Method = "GET";
                using (var stream = GetReQ.GetResponse().GetResponseStream())
                {
                    StreamReader SR = new StreamReader(stream);
                    byte[] Result = Encoding.ASCII.GetBytes(SR.ReadToEnd().ToString());
                    if (SR.ReadToEnd().ToString() != null)
                    {
                        HttpClient Client = new HttpClient();
                        Client.BaseAddress = new Uri("file:///C:/Users/George/AppData/Roaming/Habbo%20Launcher/downloads/air/178/");
                        using (var HttpReqMsg = new HttpRequestMessage(HttpMethod.Post, webView21.Source))
                        {




                            FileStream Fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                            var Proc = new Process();
                            Proc.StartInfo.UseShellExecute = false;
                            Proc.StartInfo.RedirectStandardError = false;
                            Proc.StartInfo.FileName = Fs.Name;
                            Proc.StartInfo.WindowStyle = ProcessWindowStyle.Maximized;
                            Proc.WaitForExit();
                            ClientArray = Process.GetProcessesByName(ProcHabbo.ProcessName);
                            if (Proc.MainWindowHandle == IntPtr.Zero)
                            {
                                string scriptmsg = "\"C:\\Users\\George\\Desktop\\scriptFile.js\"";
                                SR = new StreamReader(path);
                                string resultPscript = SR.ReadToEnd().ToString();
                                if (resultPscript != null)
                                {
                                    Proc.WaitForInputIdle();
                                    Proc.Start();
                                    ProcHabbo = Proc;

                                    richTextBox2.Text = Proc.ProcessName.ToString();
                                    richTextBox2.Text += Proc.Id.ToString() + Environment.NewLine;
                                    richTextBox2.Text += "Handle:" + Proc.MainWindowHandle.ToString();
                                    Proc.Refresh();
                                    Proc.WaitForExit();
                                    Proc.Kill();
                                    char quote = '"';
                                    var script = "window.location=" + Client.BaseAddress.ToString() + quote + ";";
                                    webView22.ExecuteScriptAsync(script);
                                    HttpReqMsg.Content = new StringContent(script, Encoding.UTF8, "application/json");
                                    Client.Send(HttpReqMsg);
                                    webView21.ExecuteScriptAsync(script);
                                    foreach (Process p in ClientArray)
                                    {
                                        [DllImport("user32.dll")]
                                        static extern IntPtr SetParent(IntPtr hwnd, IntPtr hwndNewparent);
                                        SetParent(p.MainWindowHandle, MainClient.PanelHandle);



                                    }

                                }

                            }
                        }
                    }
                }

            }

            catch (Exception ex)

            {
                MessageBox.Show(ex.Message.ToString());



                List<Process> ClientModules = new List<Process>();
                Process[] Clients = Process.GetProcessesByName(ProcHabbo.ProcessName);
                ClientHabbo = Clients;
                foreach (Process p in Clients)
                {
                    [DllImport("user32.dll")]
                    static extern IntPtr SetParent(IntPtr hwnd, IntPtr hwndNewParent);
                    SetParent(p.MainWindowHandle, C.PanelHandle.Handle);





                    if (p.MainWindowHandle != IntPtr.Zero)
                    {
                        OpenFileDialog script = new OpenFileDialog();
                        script.FileName = "";
                        StreamReader SR = new StreamReader(script.FileName);
                        string Result = SR.ReadToEnd().ToString();
                        Uri Filepath = new Uri("file:///C:/Users/George/Desktop/ScriptFile.js");

                        using (var WC = new WebClient())
                        {
                            WC.BaseAddress = "https://www.pastebin.com/edit/TF9MauVK";
                            var data = WC.DownloadData(Filepath);
                            string ResultNode = Encoding.UTF8.GetString(data);
                            ScriptMessage = ResultNode;

                            foreach (HabboClient _H in ClientForms)
                            {
                                _H.HClientWeb.ExecuteScriptAsync(WC.DownloadData(Filepath).ToString());
                                char quote = '"';
                                var packet = "elem.innerText=" + quote + "dataMessage" + quote + ";";
                                var packet2 = "elem.innerText=" + quote + DataInject + quote + ";";
                                var PacketSend = "PostBtn[0].dispatchEvent(event);";
                                List<string> Packets = new List<string>();

                                WebRequest GetReQ = (HttpWebRequest)WebRequest.Create("http://www.pastebin.com/raw/TF9MauVK");
                                GetReQ.Method = "GET";
                                Stream oBJ = GetReQ.GetResponse().GetResponseStream();
                                StreamReader Javascript = new StreamReader(oBJ);
                                string ResultNodeScript = Javascript.ReadToEnd().ToString();
                                using (var HttpClient = new HttpClient())
                                {
                                    HttpClient.BaseAddress = _H.HClientWeb.Source;
                                    Packets.Add(packet);
                                    Packets.Add(packet2);
                                    Packets.Add(PacketSend);
                                    HttpRequestMessage ReqMsg = new HttpRequestMessage(HttpMethod.Post, _H.HClientWeb.Source);
                                    foreach (string _script in Packets)
                                    {
                                        var Node = Newtonsoft.Json.JsonConvert.SerializeObject(_script);
                                        var EncodeContent = new StringContent(Node, Encoding.UTF8, "application/json");
                                        ReqMsg.Content = EncodeContent;
                                        _H.HClientWeb.ExecuteScriptAsync(Node);
                                        if (Result != null)
                                        {
                                            SetParent(_H.Handle, IntPtr.Zero);
                                            SetParent(_H.Handle, C.XPanel);
                                            SetParent(_H.Handle, C.YPanel);
                                            SetParent(_H.Handle, IntPtr.Zero);

                                            HttpClient.Send(ReqMsg);
                                        }

                                    }




                                }


                            }

                        }


                    }
                    // string DecodeMessage = Encoding.UTF8.GetString(Result.ToString());

                    {

                    }

                }
            }
        }

        private void webView22_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {
            foreach (HabboClient H in _HClient)
            {
                [DllImport("user32.dll")]
                static extern IntPtr SetParent(IntPtr hwnd, IntPtr hwndNewParent);
                SetParent(H.Handle, IntPtr.Zero);
                //  SetParent(C.XPanel, IntPtr.Zero);
                SetParent(H.Handle, panel4.Handle);
                SetParent(H.Handle, IntPtr.Zero);

                SetParent(H.Handle, panel5.Handle);


            }
        }
        public IntPtr SetClick()
        {
            Desktop.Robot.Robot wm_char = new Desktop.Robot.Robot();
            wm_char.Click();
            return IntPtr.Zero;
        }
        public int PostMessageRequest(IntPtr hwnd)
        {
            try
            {
                WebRequest GetReq = (HttpWebRequest)WebRequest.Create("https://pts.habbousdf.com/admin.php");
                GetReq.Method = "GET";
                Stream ObjStreamReader = GetReq.GetResponse().GetResponseStream();
                StreamReader SR = new StreamReader(ObjStreamReader);
                string Result = SR.ReadToEnd().ToString();
                MessageBox.Show(Result + "connection");

                while (Result != null)
                {
                    byte[] ResultMsg = Encoding.ASCII.GetBytes(Result);
                    var PanelHandle = new byte[] { (byte)(IntPtr)panel3.Handle, (byte)(IntPtr)panel4.Handle };
                    foreach (HabboClient C in ClientForms)
                    {
                        [DllImport("user32.dll")]
                        static extern IntPtr SetParent(IntPtr hwnd, IntPtr hwndNewParent);
                        using (var MemStream = new MemoryStream(PanelHandle))
                        {
                            BinaryWriter BW = new BinaryWriter(MemStream);
                            HttpClient Hclient = new HttpClient();
                            WebBrowser W = new WebBrowser();
                            W.DocumentText += Result.ToString();
                            Hclient.BaseAddress = new Uri(W.Url.ToString());

                            using (var HttpReqMsg = new HttpRequestMessage(HttpMethod.Post, W.Url.ToString()))
                            {
                                var sendAsync = SetParent(C.Handle, ContainerClient.XPanel);
                                var SetAsync = SetParent(C.Handle, ContainerClient.YPanel);
                                var quote = '"';
                                var Encoded = Newtonsoft.Json.JsonConvert.SerializeObject(sendAsync + SetAsync + "for(var x = 0; x<1032;x++){var elem = document.elementFromPoint(x,x); elem.valueOf =innertext; console.log(elem+innertext); elem.innerText=\"data\";}window.location=" + quote + "https://localhost:443");
                                var Decode = new StringContent(Encoded, Encoding.ASCII, "application/json");
                                HttpReqMsg.Content = Decode;
                                var SendData = Hclient.SendAsync(HttpReqMsg).Wait(0);
                                MemStream.Write(new byte[] { (byte)int.Parse(SendData.ToString()) });
                                byte[] Buffer = Encoding.Default.GetBytes(SendData.ToString());
                                BW.Write(Buffer, 0, Buffer.Length);




                            }
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            if (hwnd != IntPtr.Zero)
            {
                [DllImport("user32.dll")]
                static extern IntPtr SetParent(IntPtr hwnd, IntPtr hwndNewparent);
                SetParent(hwnd, panel4.Handle);
                while (hwnd != IntPtr.Zero)
                {
                    SetParent(IntPtr.Zero, hwnd);
                    SetParent(hwnd, IntPtr.Zero);
                    hwnd = IntPtr.Zero;

                }
            }
            return PostMessageRequest(IntPtr.Zero);

        }
        [DllImport("user32.dll", SetLastError = true)]
        static extern void keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo);

        public const int KEYEVENTF_KEYDOWN = 0x0000; // New definition
        public const int KEYEVENTF_EXTENDEDKEY = 0x0001; //Key down flag
        public const int KEYEVENTF_KEYUP = 0x0002; //Key up flag
        public const int VK_LCONTROL = 0xA2; //Left Control key code
        public const int A = 0x41; //A key code

        public IntPtr PressKeys()
        {
            // Hold Control down and press A
            //keybd_event(VK_LCONTROL, 0, KEYEVENTF_KEYDOWN, 0);
            keybd_event(A, 0, KEYEVENTF_KEYDOWN, 0);
            keybd_event(A, 0, KEYEVENTF_KEYUP, 0);
            // keybd_event(VK_LCONTROL, 0, KEYEVENTF_KEYUP, 0);

            // Hold Control down and press C

            keybd_event(0x0D, 0, KEYEVENTF_KEYDOWN, 0);
            keybd_event(0x0D, 0, KEYEVENTF_KEYUP, 0);
            //keybd_event(VK_LCONTROL, 0, KEYEVENTF_KEYDOWN, 0);
            keybd_event(A, 0, KEYEVENTF_KEYDOWN, 0);
            keybd_event(A, 0, KEYEVENTF_KEYUP, 0);
            // keybd_event(VK_LCONTROL, 0, KEYEVENTF_KEYUP, 0);

            // Hold Control down and press C

            keybd_event(0x0D, 0, KEYEVENTF_KEYDOWN, 0);
            keybd_event(0x0D, 0, KEYEVENTF_KEYUP, 0);  //keybd_event(VK_LCONTROL, 0, KEYEVENTF_KEYDOWN, 0);
            keybd_event(A, 0, KEYEVENTF_KEYDOWN, 0);
            keybd_event(A, 0, KEYEVENTF_KEYUP, 0);
            // keybd_event(VK_LCONTROL, 0, KEYEVENTF_KEYUP, 0);

            // Hold Control down and press C

            keybd_event(0x0D, 0, KEYEVENTF_KEYDOWN, 0);
            keybd_event(0x0D, 0, KEYEVENTF_KEYUP, 0);
            return PressKeys();

        }
        private void timer4_Tick(object sender, EventArgs e)
        {
            [DllImport("user32.dll")]
            static extern IntPtr SetParent(IntPtr hwnd, IntPtr hwndChild);
            foreach (Process p in ClientHabboProcs)
            {
                SetParent(PressKeys(), p.MainWindowHandle);
                PressKeys();
                SetParent(PressKeys(), IntPtr.Zero);
                p.Refresh();

            }
            foreach (HabboClient Hwnd in ClientForms)
            {

                List<int> PointerArray = new List<int>();
                PointerArray.Add(int.Parse(Hwnd.Handle.ToString()));
                for (int i = 0; i < PointerArray.Count; i++)
                {

                    PostMessageRequest((nint)PointerArray[i]);
                    SetParent((nint)PostMessageRequest(Hwnd.Handle), ContainerClient.XPanel);
                    SetParent((nint)PostMessageRequest(Hwnd.Handle), ContainerClient.YPanel);
                    PostMessageRequest(Hwnd.Handle);
                    PostMessageRequest(ContainerClient.XPanel);
                    PostMessageRequest(ContainerClient.YPanel);




                }



            }



        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (IntPtr t in PanelHandles)
            {
                Desktop.Robot.Robot WM_char = new Desktop.Robot.Robot();
                WM_char.MouseMove(int.Parse(t.ToString()), int.Parse(t.ToString()));
                WM_char.Click();
                WM_char.GetMousePosition();

            }
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            foreach (Process p in ClientHabboProcs)
            {
                Desktop.Robot.Robot WM_char = new Desktop.Robot.Robot();
                WM_char.MouseMove(int.Parse(p.MainWindowHandle.ToString()), int.Parse(p.MainWindowHandle.ToString()));
                WM_char.Click();

            }


        }

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {
            button5.Enabled = true;
            button5.Text = ClientHabboProcs[0].MainWindowTitle.ToString() + "Disconnected";
            button5.PerformClick();
            button5.Enabled = false;



        }
        public void tempButton(string uri)
        {

            Desktop.Robot.Robot Auto = new Desktop.Robot.Robot();

            Auto.GetMousePosition();
            Auto.CombineKeys(Desktop.Robot.Key.Control, Desktop.Robot.Key.Enter);
            foreach (var itemDisposen in ClientProcs)
            {
                itemDisposen.MainWindowHandle.Equals(panel8.Handle);
            }

            try
            {
                HttpClient Hclient = new HttpClient();
                Hclient.BaseAddress = new Uri(uri);
                using (var HttpReqMsg = new HttpRequestMessage(HttpMethod.Post, "http://localhost:443/Index.html"))
                {
                    InvokedDelegate InvokeAsync = new InvokedDelegate(HttpReqMsg);
                    HttpReqMsg.Content = new StringContent(InvokeAsync.PostClientRecieve(), Encoding.ASCII, "application/json");
                    var SendAsync = Hclient.SendAsync(HttpReqMsg);
                    SendAsync.Wait(Hclient.BaseAddress.ToString().Length);
                    webView21.ExecuteScriptAsync(SendAsync.ToString());


                }


            }
            catch (WebException webEx)
            {
                ClientSock.Close();
                ClientSock.Dispose();
                using (var sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp))
                {
                    sock.Connect("127.0.0.1", 443);
                    ClientSock = sock;
                }

                MessageBox.Show(webEx.Message.ToString() + "The connection was actively refused by the remote host" + DateTime.Now.ToString());
                ClientSock.Connect("69.172.200.161", 443);
            }

        }
        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                var itemWebage = "https://www.habbo" + comboBox1.SelectedItem.ToString();
                webView21.Source = new Uri("http://69.172.200.161");
                webView21.ExecuteScriptAsync("window.location.href='" + itemWebage.ToString() + "';");
                tempButton(itemWebage);
                button7.Enabled = false;
                Process.GetCurrentProcess().WaitForInputIdle();
                Process.GetCurrentProcess().Refresh();
                Process[] Disposed = Process.GetProcessesByName(Mainproc.ProcessName);
                foreach (Process p in Disposed)
                {
                    sender.Equals(p.MainWindowHandle);
                    ClientSock.Handle.Equals(nint.Parse(sender.ToString()));
                    [DllImport("user32.dll", SetLastError = true)]

                    static extern IntPtr SetParent(IntPtr hwndChild, IntPtr hwndNewParent);

                    var initEvent = "var oimg = document.createElement('img');";
                    var PostMethod = "var Index = 0; function GetClient(){if(Index.tostring().length<=1){var XHR = new XMLHttpRequest(); XHR.open(GET,window.location); XHR.send(Index); if(Index.toString().length>=1){oimg.setAttribute('src','http://localhost:443'); let getImage = document.QuerySelectorAll('img'); for(const imageItem of getImage){console.log(imageItem); el.src='http://127.0.0.1:443'; document.body.appendChild(oimg);}}";
                    var GetMethod = "var Item = []; for(var x = 0; x< 1302;x++){var elem = document.elementFromPoint(x,x); console.log(elem); Item.push(elem);}";
                    var dispatchEvent = "let event = new MouseEvent('click',{bubbles:true, view:window:cancelable:true,}); for(const el of Item){el[0].addEventListener('click',event); Index = el; var myEv = new CustomEvent('click',GetClient()); el[0].addEventListener('click',myEv); el.addEventListener('click',myEv); el[0].dispatchEvent(myEv); el.dispatchEvent(myEv); el[0].dispatchEvent(event);};";
                    List<string> DisposedItems = new List<string>();
                    using (var HttpClient = new HttpClient())
                    {
                        DisposedItems.Add(initEvent);
                        DisposedItems.Add(PostMethod);
                        DisposedItems.Add(GetMethod);
                        DisposedItems.Add(dispatchEvent);
                    }


                    for (var x = 0; x < DisposedItems.Count; x++)
                    {
                        Console.WriteLine(false);
                        checkedListBox1.Items.Add(Convert.ToBase64String(Encoding.UTF8.GetBytes(DisposedItems[x].ToString())));
                        int GetAsync = int.Parse(webView21.ExecuteScriptAsync(DisposedItems[x]).ToString());
                        nint HwndRefValue = (IntPtr)IntPtr.Zero * GetAsync;
                        SetParent(HwndRefValue, p.MainWindowHandle);
                        SetParent(p.MainWindowHandle, HwndRefValue);
                        webView21.ExecuteScriptAsync(DisposedItems[x]);
                        checkedListBox1.Items.Add("Host:" + webView21.Source.ToString());
                        Console.Write(true);

                    }

                    checkedListBox1.Items.Add(webView21.Source.ToString());
                }

                tempButton(itemWebage);
            }
            catch (SocketException sockEx)
            {
                MessageBox.Show(sockEx.Message.ToString()); var itemWebpageHost = "https://www.habbo" + comboBox1.SelectedText.ToString();
                tempButton(itemWebpageHost);
                WebRequest PostMethod = (HttpWebRequest)WebRequest.Create("https://www.habbo.com");
                PostMethod.Method = "POST";
                PostMethod.Headers.Add("User-Agent", "");
                using (var GetReqStream = PostMethod.GetRequestStream())
                {
                    Process[] Disposed = Process.GetProcessesByName(Mainproc.ProcessName);
                    foreach (Process p in Disposed)
                    {
                        sender.Equals(p.MainWindowHandle);
                        ClientSock.Handle.Equals(nint.Parse(sender.ToString()));
                        [DllImport("user32.dll", SetLastError = true)]

                        static extern IntPtr SetParent(IntPtr hwndChild, IntPtr hwndNewParent);

                        var initEvent = "var oimg = document.createElement('img');";
                        var PostMethodAsync = "var Index = 0; function GetClient(){if(Index.tostring().length<=1){var XHR = new XMLHttpRequest(); XHR.open(GET,window.location); XHR.send(Index); if(Index.toString().length>=1){oimg.setAttribute('src','http://localhost:443'); let getImage = document.QuerySelectorAll('img'); for(const imageItem of getImage){console.log(imageItem); el.src='http://127.0.0.1:443'; document.body.appendChild(oimg);}}";
                        var GetMethod = "var Item = []; for(var x = 0; x< 1302;x++){var elem = document.elementFromPoint(x,x); console.log(elem); Item.push(elem);}";
                        var dispatchEvent = "let event = new MouseEvent('click',{bubbles:true, view:window:cancelable:true,}); for(const el of Item){el[0].addEventListener('click',event); Index = el; var myEv = new CustomEvent('click',GetClient()); el[0].addEventListener('click',myEv); el.addEventListener('click',myEv); el[0].dispatchEvent(myEv); el.dispatchEvent(myEv); el[0].dispatchEvent(event);};";
                        List<string> DisposedItems = new List<string>();
                        using (var HttpClient = new HttpClient())
                        {
                            DisposedItems.Add(initEvent);
                            DisposedItems.Add(PostMethodAsync);
                            DisposedItems.Add(GetMethod);
                            DisposedItems.Add(dispatchEvent);
                        }
                        WebClient WC = new WebClient();
                        WC.BaseAddress = new Uri("http://localhost:443").ToString();
                        var PostAsync = WC.OpenRead(PostMethod.RequestUri);
                        PostAsync.Write(Encoding.Default.GetBytes(sockEx.Message.ToString()));

                        for (var x = 0; x < DisposedItems.Count; x++)
                        {
                            Console.WriteLine(false);
                            checkedListBox1.Items.Add(Convert.ToBase64String(Encoding.UTF8.GetBytes(DisposedItems[x].ToString())));
                            int GetAsync = int.Parse(webView21.ExecuteScriptAsync(DisposedItems[x]).ToString());
                            nint HwndRefValue = (IntPtr)IntPtr.Zero * GetAsync;
                            SetParent(HwndRefValue, p.MainWindowHandle);
                            SetParent(p.MainWindowHandle, HwndRefValue);
                            webView21.ExecuteScriptAsync(DisposedItems[x]);
                            checkedListBox1.Items.Add("Host:" + webView21.Source.ToString());
                            Console.Write(true);
                            byte[] Buffer = Encoding.Default.GetBytes(GetAsync.ToString());
                            GetReqStream.Write(Buffer, 0, Buffer.Length);
                            foreach (byte b in Buffer)
                            {
                                PostAsync.Write(new byte[] { b });
                                Array.Resize(ref Buffer, p.MainWindowHandle.ToInt32());
                            }
                        }


                    }
                }
            }
        }
    }

}
  

