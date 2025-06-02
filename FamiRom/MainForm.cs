using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Diagnostics;

namespace FamiRom
{
    public partial class MainForm: Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

         private readonly Dictionary<int, string> mapperNames = new Dictionary<int, string>
         {
           { 0, "No Mapper/NROM" },
           { 1, "MMC1" },
           { 2, "UxRom"},
           { 3, "CNROM"},
           { 4, "MMC3"},
           { 5, "MMC5"},
           { 7, "AxRom"},
           { 9, "MMC2"},
           { 10, "MMC4"},
           { 11, "Color Dreams"},
           { 13, "CPROM"},
           { 21, "VRC2/VRC4"},
           { 22, "VRC2/VRC4"},
           { 23, "VRC2/VRC4"},
           { 24, "VRC6"},
           { 25, "VRC2/VRC4"},
           { 26, "VRC6"},
           { 28, "Action 53"},
           { 30, "UNROM 512"},
           { 35, "J.Y. Company ASIC"},
           { 64, "RAMBO-1"},
           { 66, "GxRom"},
           { 69, "Sunsoft FME-7"},
           { 73, "VRC3"},
           { 75, "VRC1"},
           { 79, "NINA-003-006"},
           { 82, "Taito X1-017"},
           { 85, "VRC7"},
           { 90, "J.Y. Company ASIC"},
           { 104, "PEGASUS 5 IN 1"},
           { 105, "NES-EVENT"},
           { 111, "GTROM"},
           { 126, "126/422/534"},
           { 128, "265"},
           { 135, "Errata"},
           { 141, "TC-A003-72"},
           { 146, "NINA-003-006"},
           { 155, "MMC1"},
           { 166, "167"},
           { 182, "114"},
           { 185, "CNROM"},
           { 209, "J.Y. Company ASIC"},
           { 211, "J.Y. Company ASIC"},
           { 249, "T9552"},
           { 390, "236"},
           { 422, "534"},
           { 431, "396"},
           { 536, "195"},
           { 537, "195"},
           { 552, "Taito X1-017"},

         };

        private void Selectbtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Famicom ROMs (*.nes)|*.nes|All Files (*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    byte[] data = File.ReadAllBytes(ofd.FileName);

                    if (data.Length < 8)
                    {
                        OutputLabel.Text = "[Error] The file is too small to be a .nes file.";
                        return;
                    }

                    if (data[0] != 'N' || data[1] != 'E' || data[2] != 'S' || data[3] != 0x1A)
                    {
                        OutputLabel.Text = "[Error] Invalid iNES header.";
                        return;
                    }

                    int prgSize = data[4] * 16; // PRG
                    int chrSize = data[5] * 8;  // CHR

                    // Flags
                    byte flags6 = data[6];
                    byte flags7 = data[7];

                    int mapper = (flags7 & 0xF0) | (flags6 >> 4); // Mapper 
                    string mapperName = mapperNames.TryGetValue(mapper, out string name) ? name : "Unknown";
                    bool verticalMirroring = (flags6 & 0x01) != 0; // Mirroring
                    bool fourScreen = (flags6 & 0x08) != 0;
                    string mirroringType = fourScreen ? "Four-screen" : (verticalMirroring ? "Vertical" : "Horizontal");
                    bool hasTrainer = (flags6 & 0x04) != 0; // Trainer
                    bool hasBattery = (flags6 & 0x02) != 0; // Battery
                    bool isNES2 = (flags7 & 0x0C) == 0x08; // Header type

                    bool isPlayChoice10 = (data[7] & 0x02) != 0; // PlayChoice 10
                    bool isVsUnisystem = (data[7] & 0x01) != 0; // Vs. Unisystem
                    string systemType = isPlayChoice10 ? "PlayChoice-10" : (isVsUnisystem ? "VS Unisystem" : "Standard NES/Famicom");

                    byte[] prgRom = new byte[prgSize * 1024];
                    Array.Copy(data, 16, prgRom, 0, prgRom.Length);

                    uint crcPrg = Crc32.Compute(prgRom);
                    string crcPrgHex = crcPrg.ToString("X8");


                    OutputLabel.Text = $"File: {Path.GetFileName(ofd.FileName)}\n" +
                                     $"PRG-ROM: {prgSize} KiB\n" +
                                     $"CHR-ROM: {chrSize} КiB\n" +
                                     $"Mapper: {mapper} ({mapperName})\n" +
                                     $"Mirroring: {mirroringType}\n" +
                                     $"Trainer: {(hasTrainer ? "Yes" : "No")}\n" +
                                     $"Battery: {(hasBattery ? "Yes" : "No")}\n" +
                                     $"Header Format: {(isNES2 ? "NES 2.0" : "iNES")}\n" + 
                                     $"System: {systemType}\n" +
                                     $"PRG-ROM CRC32: {crcPrgHex}";

                }
                catch (Exception ex)
                {
                    OutputLabel.Text = "[Error] " + ex.Message;
                }
            }
        }

        private void IconStrip_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://www.deviantart.com/malaert64/art/Tech-Pixel-Art-Donkey-Kong-Famicom-Cartridge-853765378",
                UseShellExecute = true
            });
        }

        private void NesDevStrip_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://www.nesdev.org",
                UseShellExecute = true
            });
        }

        private void AboutToolStrip_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        private void GitHubStrip_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://github.com/Sek13H/FamiRom",
                UseShellExecute = true
            });
        }

        public static class Crc32
        {
            private static readonly uint[] table = new uint[256];

            static Crc32()
            {
                const uint polynomial = 0xEDB88320;
                for (uint i = 0; i < table.Length; i++)
                {
                    uint crc = i;
                    for (int j = 0; j < 8; j++)
                        crc = (crc & 1) != 0 ? (crc >> 1) ^ polynomial : crc >> 1;
                    table[i] = crc;
                }
            }

            public static uint Compute(byte[] bytes)
            {
                uint crc = 0xFFFFFFFF;
                foreach (byte b in bytes)
                {
                    byte index = (byte)((crc & 0xFF) ^ b);
                    crc = (crc >> 8) ^ table[index];
                }
                return ~crc;
            }
        }

        public static byte[] ExtractFdsDiskData(byte[] data)
        {
            List<byte> result = new List<byte>();
            bool insideBlock = false;

            foreach (byte b in data)
            {
                if (b == 0x01) // Start of disk side
                {
                    insideBlock = true;
                    continue;
                }

                if (b == 0x03) // End of disk side
                {
                    insideBlock = false;
                    continue;
                }

                if (insideBlock)
                {
                    result.Add(b);
                }
            }

            return result.ToArray();
        }

        private void SelectFDSBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Famicom Disk System ROMs (*.fds)|*.fds|All Files (*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    byte[] data = File.ReadAllBytes(ofd.FileName);

                    // if (data.Length < 16 || data[0] != 'F' || data[1] != 'D' || data[2] != 'S' || data[3] != 0x1A)
                    //  {
                    //    OutputFDSLabel.Text = "[Error] Invalid FDS header.";
                    //      return;
                    //  }

                    int sideCount = 0; // Count Sides

                     for (int i = 0; i < data.Length - 1; i++)
                     {
                       if (data[i] == 0x01 && data[i + 1] == 0x2A) 
                        {
                            sideCount++;
                        }
                     }

                     // CRC32
                    byte[] useful = ExtractFdsDiskData(data);
                    uint crc32 = Crc32.Compute(useful);
                    string crcHex = crc32.ToString("X8");


                    OutputFDSLabel.Text = $"File: {Path.GetFileName(ofd.FileName)}\n" +
                                          $"Overall size: {data.Length / 1024} KiB\n" +
                                          $"Sides: {sideCount}\n" +
                                          $"CRC32: {crcHex}\n";
                }
                catch (Exception ex)
                {
                    OutputFDSLabel.Text = "[Error] " + ex.Message;
                    return;
                }
            }
        }
    }
}
