using System.IO.Ports;
using System.Management;

namespace SmartCharging
{
  public partial class Main : Form
  {
    private SerialPort? serialPort;
    private TimeSpan elapsedTime;
    private double totalEnergy;
    private double totalPrice;

    public Main()
    {
      InitializeComponent();
    }

    private void Main_Load(object sender, EventArgs e)
    {
      CBPort.Items.AddRange(new string[] { "Local", "Remote", "TCP" });
      CBPort.SelectedItem = "Local";
      LoadComPorts();
      LoadBaudRates();
      TBAddress.Text = "16";
      TBSerialNumber.Text = "00000000";
      UpdateStatusIndicator(false); // Set initial status to red
      LOGODisplay();
      RBManual.Checked = true;
      LCurrent.Text = "6 A";
      BStartStop.BackColor = Color.LightGreen;
      UpdatePlugIndicator(false);
      TBCurrent.Maximum = 32;
      TBCurrent.Minimum = 6;
      TBCurrent.Value = 6;
      elapsedTime = TimeSpan.Zero;
      LStartTime.Text = elapsedTime.ToString(@"hh\:mm\:ss");
      totalEnergy = 0;
      LEnergy.Text = totalEnergy.ToString("0.00") + " Wh";
      totalPrice = 0;
      LPrice.Text = totalPrice.ToString("0.00") + " TND";
    }
    private void Timer_Tick(object sender, EventArgs e)
    {
      elapsedTime = elapsedTime.Add(TimeSpan.FromSeconds(1));
      LStartTime.Text = elapsedTime.ToString(@"hh\:mm\:ss");

      // Calculate energy based on current and voltage (230V)
      int current = int.Parse(LCurrent.Text.Split(' ')[0]);
      totalEnergy += current * 230 / 3600.0; // Convert to Wh
      if (totalEnergy >= 1000)
      {
        LEnergy.Text = (totalEnergy / 1000).ToString("0.00") + " kWh";
      }
      else
      {
        LEnergy.Text = totalEnergy.ToString("0.00") + " Wh";
      }

      // Calculate price based on energy consumption
      totalPrice = (totalEnergy / 1000) * 0.5; // 0.5 TND per kWh
      LPrice.Text = totalPrice.ToString("0.00") + " TND";
    }

    private void LoadComPorts()
    {
      CBDevice.Items.Clear();
      var searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PnPEntity WHERE Name LIKE '%(COM%)'");
      foreach (var device in searcher.Get())
      {
        var name = device["Name"]?.ToString();
        if (name != null)
        {
          CBDevice.Items.Add(name);
        }
      }
      if (CBDevice.Items.Count > 0)
      {
        CBDevice.SelectedIndex = 0;
      }
    }

    private void LoadBaudRates()
    {
      CBBaudRate.Items.Clear();
      int[] baudRates = { 300, 600, 1200, 2400, 4800, 9600, 14400, 19200, 38400, 57600, 115200, 230400, 460800, 921600 };
      foreach (int baudRate in baudRates)
      {
        CBBaudRate.Items.Add(baudRate);
      }
      CBBaudRate.SelectedItem = 19200; // Set default baud rate to 9600
    }

    private void BChangePath_Click(object sender, EventArgs e)
    {
      using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
      {
        if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
        {
          TBPath.Text = folderBrowserDialog.SelectedPath;
        }
      }
    }

    private void BRefreshFiles_Click(object sender, EventArgs e)
    {
      LBFiles.Items.Clear();
      string selectedPath = TBPath.Text;
      if (Directory.Exists(selectedPath))
      {
        string[] textFiles = Directory.GetFiles(selectedPath, "*.txt");
        foreach (string file in textFiles)
        {
          LBFiles.Items.Add(Path.GetFileName(file));
        }
      }
      else
      {
        MessageBox.Show("The selected path does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void LBFiles_SelectedIndexChanged_1(object sender, EventArgs e)
    {
      if (LBFiles.SelectedItem != null)
      {
        string selectedFile = Path.Combine(TBPath.Text, LBFiles.SelectedItem.ToString());
        if (File.Exists(selectedFile))
        {
          TBTextFile.Text = File.ReadAllText(selectedFile);
        }
      }
    }

    private void BOpen_Click(object sender, EventArgs e)
    {
      if (CBDevice.SelectedItem != null && CBBaudRate.SelectedItem != null)
      {
        string selectedPort = CBDevice.SelectedItem.ToString().Split('(')[1].TrimEnd(')');
        int baudRate = (int)CBBaudRate.SelectedItem;
        int address = int.Parse(TBAddress.Text);

        serialPort = new SerialPort(selectedPort, baudRate)
        {
          Encoding = System.Text.Encoding.UTF8 // Set the encoding to UTF8
        };
        serialPort.DataReceived += SerialPort_DataReceived;
        try
        {
          serialPort.Open();
          this.BeginInvoke((MethodInvoker)delegate
          {
            MessageBox.Show($"Connected to {selectedPort} at {baudRate} baud with address {address}", "Connection Successful");
          });
          UpdateStatusIndicator(true); // Set status to green
        }
        catch (Exception ex)
        {
          MessageBox.Show(ex.Message, "Connection Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
          UpdateStatusIndicator(false); // Set status to red
          return;
        }
      }
      else
      {
        MessageBox.Show("Please select a COM port and baud rate.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
    {
      string data = serialPort.ReadExisting();
      Invoke(new MethodInvoker(delegate
      {
        LBOutput.Items.Add($"Received: {data}");
        UpdateStatusIndicator(true); // Set status to green
      }));
    }

    private void SendData(string data)
    {
      if (serialPort != null && serialPort.IsOpen)
      {
        serialPort.Write(data);
        LBOutput.Items.Add($"Sent: {data}");
        UpdateStatusIndicator(true); // Set status to green
      }
      else
      {
        MessageBox.Show("Serial port is not open.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        UpdateStatusIndicator(false); // Set status to red
      }
    }

    private void BRefreshCOM_Click(object sender, EventArgs e)
    {
      LoadComPorts();
    }

    private void UpdateStatusIndicator(bool isConnected)
    {
      string basePath = AppDomain.CurrentDomain.BaseDirectory;
      if (isConnected)
      {
        PBStatus.Image = Image.FromFile(Path.Combine(basePath, "GreenLED.png")); // Set to green LED
      }
      else
      {
        PBStatus.Image = Image.FromFile(Path.Combine(basePath, "RedLED.png")); // Set to red LED
      }
      PBStatus.SizeMode = PictureBoxSizeMode.StretchImage; // Make the image fill the PictureBox
    }

    private void LOGODisplay()
    {
      string basePath = AppDomain.CurrentDomain.BaseDirectory;
      PBIAT.Image = Image.FromFile(Path.Combine(basePath, "IAT.png"));
      PBIAT.SizeMode = PictureBoxSizeMode.StretchImage;
    }

    private void BClose_Click(object sender, EventArgs e)
    {
      if (serialPort != null && serialPort.IsOpen)
      {
        try
        {
          serialPort.Close();
          this.BeginInvoke((MethodInvoker)delegate
          {
            MessageBox.Show("Serial port closed successfully.", "Connection Closed", MessageBoxButtons.OK, MessageBoxIcon.Information);
          });
          UpdateStatusIndicator(false); // Set status to red
        }
        catch (Exception ex)
        {
          MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
      }
      else
      {
        MessageBox.Show("Serial port is not open.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void RadioButton_CheckedChanged(object sender, EventArgs e)
    {
      if (sender is RadioButton radioButton && radioButton.Checked)
      {
        // Ensure only one radio button is checked
        if (radioButton == RBManual)
        {
          RBAuto.Checked = false;
          RBScheduled.Checked = false;
        }
        else if (radioButton == RBAuto)
        {
          RBManual.Checked = false;
          RBScheduled.Checked = false;
        }
        else if (radioButton == RBScheduled)
        {
          RBManual.Checked = false;
          RBAuto.Checked = false;
        }
      }
    }

    private void RBManuel_CheckedChanged(object sender, EventArgs e)
    {
      RadioButton_CheckedChanged(sender, e);
    }

    private void TBCurrent_Scroll(object sender, EventArgs e)
    {
      // Assuming TBCurrent is a TrackBar and LCurrent is a Label
      int value = TBCurrent.Value;
      if (value < 6)
      {
        value = 6;
      }
      else if (value > 32)
      {
        value = 32;
      }
      LCurrent.Text = value.ToString() + " A";
    }

    private void UpdatePlugIndicator(bool isConnected)
    {
      string basePath = AppDomain.CurrentDomain.BaseDirectory;
      if (isConnected)
      {
        PBPlug.Image = Image.FromFile(Path.Combine(basePath, "PlugOn.png")); // Set to green LED
      }
      else
      {
        PBPlug.Image = Image.FromFile(Path.Combine(basePath, "PlugOff.png")); // Set to red LED
      }
      PBPlug.SizeMode = PictureBoxSizeMode.StretchImage; // Make the image fill the PictureBox
    }
    private void BStartStop_Click(object sender, EventArgs e)
    {
      if (serialPort == null || !serialPort.IsOpen)
      {
        MessageBox.Show("Please Open Communication before starting the charging process.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }

      if (BStartStop.Text == "CHARGE NOW")
      {
        BStartStop.Text = "STOP CHARGING";
        BStartStop.BackColor = Color.OrangeRed;
        UpdatePlugIndicator(true);
        totalEnergy = 0; // Reset total energy
        LEnergy.Text = totalEnergy.ToString("0.00") + " Wh";
        totalPrice = 0; // Reset total price
        LPrice.Text = totalPrice.ToString("0.00") + " TND";
        timer.Start(); // Start the timer
      }
      else
      {
        BStartStop.Text = "CHARGE NOW";
        BStartStop.BackColor = Color.LightGreen;
        UpdatePlugIndicator(false);
        timer.Stop(); // Stop the timer
        elapsedTime = TimeSpan.Zero; // Reset elapsed time
      }
    }
  }
}
